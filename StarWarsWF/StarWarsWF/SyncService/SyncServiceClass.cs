
using StarWarsWF.Connection;
using StarWarsWF.Models;
using StarWarsWF.ModelsAPI;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsWF.SyncService
{
    public class SyncServiceClass
    {


        private const string URL_PLANETAS = "http://swapi.dev/api/planets/";
        private const string URL_NAVES = "http://swapi.dev/api/starships/";
        private const string URL_PILOTOS = "http://swapi.dev/api/people/";

        public Task Sincronizar()
        {
            var tasks = new List<Task>();

            tasks.Add(SincronizarPlanetas());
            tasks.Add(SincronizarNaves());

            Task.WhenAll(tasks);

            return SincronizarPilotos();
        }

        private async Task SincronizarPlanetas()
        {
            var httpClient = new HttpClient();
            var lista = new List<PlanetaAPI>();
            ResultadoAPI<PlanetaAPI> resultadoApi = null;

            do
            {
                resultadoApi = await httpClient.GetFromJsonAsync<ResultadoAPI<PlanetaAPI>>(resultadoApi?.Next ?? URL_PLANETAS);
                lista.AddRange(resultadoApi.Results);
            } while (resultadoApi.Next != null);

            var planetas = lista.Select(item => new Planeta
            {
                IdPlaneta = item.IdPlaneta,
                Nome = item.Name,
                Clima = item.Climate,
                Diametro = item.Diametro,
                Orbita = item.Orbita,
                Rotacao = item.Rotacao,
                Populacao = item.Populacao
            }).ToList();

            using (var dao = new PlanetaActions())
                await dao.InserirPlanetas(planetas);
        }

        private async Task SincronizarNaves()
        {
            var httpClient = new HttpClient();
            var lista = new List<NaveAPI>();
            ResultadoAPI<NaveAPI> resultadoApi = null;

            do
            {
                resultadoApi = await httpClient.GetFromJsonAsync<ResultadoAPI<NaveAPI>>(resultadoApi?.Next ?? URL_NAVES);
                lista.AddRange(resultadoApi.Results);
            } while (resultadoApi.Next != null);

            var naves = lista.Select(item => new Nave
            {
                IdNave = item.IdNave,
                Nome = item.Name,
                Carga = item.Carga,
                Classe = item.Starship_Class,
                Modelo = item.Model,
                Passageiros = item.Passageiros
            }).ToList();

            using (var dao = new NaveActions())
                await dao.InserirNaves(naves);
        }

        private async Task SincronizarPilotos()
        {
            var httpClient = new HttpClient();
            var lista = new List<PilotoAPI>();
            ResultadoAPI<PilotoAPI> resultadoApi = null;

            do
            {
                resultadoApi = await httpClient.GetFromJsonAsync<ResultadoAPI<PilotoAPI>>(resultadoApi?.Next ?? URL_PILOTOS);
                lista.AddRange(resultadoApi.Results.Where(p => p.Starships.Any()).ToList());
            } while (resultadoApi.Next != null);

            var pilotos = lista.Select(item => new Piloto
            {
                IdPiloto = item.IdPiloto,
                Nome = item.Name,
                AnoNascimento = item.Birth_Year,
                IdPlaneta = item.IdPlaneta,
                Naves = item.IdNaves.Select(idNave => new Nave
                {
                    IdNave = int.Parse(idNave)
                }).ToList()
            }).ToList();

            using (var pilotoDao = new PilotoActions())
            {
                await pilotoDao.InserirPilotos(pilotos);
                await pilotoDao.InserirPilotosNaves(pilotos);
            }
        }


    }
}
