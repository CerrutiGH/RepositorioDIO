using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsWF.ModelsAPI
{
    public class NaveAPI
    {

        public string Name { get; set; }
        public string Model { get; set; }
        public string Passengers { get; set; }
        public string Cargo_Capacity { get; set; }
        public string Starship_Class { get; set; }
        public string Url { get; set; }

        public int Passageiros
        {
            get
            {
                int.TryParse(Passengers, out var retorno);
                return retorno;
            }
        }

        public double Carga
        {
            get
            {
                double.TryParse(Cargo_Capacity, out var retorno);
                return retorno;
            }
        }

        public int IdNave
        {
            get
            {
                return int.Parse(Url?.Split('/').Where(u => !string.IsNullOrEmpty(u)).LastOrDefault());
            }
        }

    }
}
