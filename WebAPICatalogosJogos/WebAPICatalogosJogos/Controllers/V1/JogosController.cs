using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebAPICatalogosJogos.InputModel;
using WebAPICatalogosJogos.Services;
using WebAPICatalogosJogos.ViewModel;
using WebAPICatalogosJogos.Exceptions;

namespace WebAPICatalogosJogos.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {


        private readonly IJogoService _jogoService;

        public JogosController(IJogoService jogoService)
        {
            _jogoService = jogoService;
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<JogoViewModel>>> Obter([FromQuery, Range(1, int.MaxValue)] int pagina = 1, [FromQuery, Range(1, 50)] int quantidade = 5) //Usar async Task para processo assíncrono
        {
            var jogos = await _jogoService.Obter(pagina, quantidade);
            if(jogos.Count() == 0)
            return NoContent();
            return Ok(jogos);
        }

        [HttpGet("{idJogo: guid}")]
        public async Task<ActionResult<JogoViewModel>> Obter([FromRoute] Guid idJogo) 
        {
            var jogo = await _jogoService.Obter(idJogo);
            if (jogo == null)
                return NoContent();
            return Ok(jogo);
        }

        [HttpPost]
        public async Task<ActionResult<JogoViewModel>> InserirJogo([FromBody] JogoInputModel jogoInputModel)
        {
            try
            {
                var jogo = await _jogoService.Inserir(jogoInputModel);
                return Ok(jogo);
            }
            //catch(JogoJaCadastradosException ex)
            catch(JogoJaCadastradoException ex)
            {
                return UnprocessableEntity(ex);
            }

            return Ok();
        }

        [HttpPut("{idJogo:guid}")]
        public async Task<ActionResult> AtualizarJogo( [FromRoute] Guid idJogo, [FromBody] JogoInputModel jogoInputModel)
        {
            try
            {
                await _jogoService.Atualizar(idJogo, jogoInputModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound("Não e possível atualizar um item que não existe.");
            }
            
        }

        [HttpPatch("{idJogo:guid}/preco/{preco:double}")]
        public async Task<ActionResult> AtualizarJogo([FromRoute] Guid idJogo,[FromRoute] double preco)
        {
            try
            {
                await _jogoService.Atualizar(idJogo, preco);
                return Ok();
            }
            catch(Exception ex)
            {
                return NotFound("Não e possível atualizar o preço de um item que não existe.");
            }
        }




        [HttpDelete("{idJogo:guid")]
        public async Task<ActionResult> ApagarJogo([FromRoute] Guid idJogo)
        {
            try{
                await _jogoService.Remover(idJogo);
                return Ok();
            }
            catch(Exception ex)
            {
                return NotFound("Não e possível deletar um item que não existe.");
            }
        }
    }
}
