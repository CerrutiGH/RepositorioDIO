﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICatalogosJogos.Entities;
using WebAPICatalogosJogos.Exceptions;
using WebAPICatalogosJogos.InputModel;
using WebAPICatalogosJogos.Repositories;
using WebAPICatalogosJogos.ViewModel;

namespace WebAPICatalogosJogos.Services
{
    public class JogoService : IJogoService
    {
        private readonly IJogoRepository _JogoRepository;

        public JogoService (IJogoRepository jogoRepository)
        {
            _JogoRepository = jogoRepository;
        }

        public async Task<List<JogoViewModel>> Obter(int pagina, int quantidade)
        {
            var jogos = await _JogoRepository.Obter(pagina, quantidade);

            return jogos.Select(jogo => new JogoViewModel
            {

                Id = jogo.Id,
                Nome = jogo.Nome,
                Produtora = jogo.Produtora,
                Preco = jogo.Preco


            }).ToList();
        }

        public async Task<JogoViewModel> Obter(Guid id)
        {
            var jogo = await _JogoRepository.Obter(id);
            if (jogo == null)
            {
                return null;
            }
            else
            {
                return new JogoViewModel
                {
                    Id = jogo.Id,
                    Nome = jogo.Nome,
                    Produtora = jogo.Produtora,
                    Preco = jogo.Preco
                };
            }
        } 
        
        public async Task<JogoViewModel> Inserir(JogoInputModel jogo)
        {
            var entidadeJogo = await _JogoRepository.Obter(jogo.Nome, jogo.Produtora);

            if(entidadeJogo.Count > 0)
            {
                throw new JogoJaCadastradoException();
                    
            }
            else
            {
                var jogoInsert = new Jogo
                {
                    Id = Guid.NewGuid(),
                    Nome = jogo.Nome,
                    Produtora = jogo.Produtora,
                    Preco = jogo.Preco
                };

                await _JogoRepository.Inserir(jogoInsert);
                return new JogoViewModel
                {
                    Id = jogoInsert.Id,
                    Nome = jogoInsert.Nome,
                    Produtora = jogoInsert.Produtora,
                    Preco = jogoInsert.Preco
                };
            }
        }

        public async Task Atualizar(Guid id, JogoInputModel jogo)
        {
            var entidadeJogo = await _JogoRepository.Obter(id);
            if(entidadeJogo == null)
            {
                throw new JogoNaoCadastradoException();
            }
            else
            {
                entidadeJogo.Nome = jogo.Nome;
                entidadeJogo.Produtora = jogo.Produtora;
                entidadeJogo.Preco = jogo.Preco;

                await _JogoRepository.Atualizar(entidadeJogo);
            }
        }
        
        public async Task Atualizar(Guid id, double preco)
        {
            var entidadeJogo = await _JogoRepository.Obter(id);
            
            if(entidadeJogo == null)
            {
                throw new JogoNaoCadastradoException();
            }
            else
            {
                entidadeJogo.Preco = preco;
                await _JogoRepository.Atualizar(entidadeJogo);
            }
        }

        public async Task Remover(Guid id)
        {
            var jogo = await _JogoRepository.Obter(id);
            if (jogo == null)
            {
                throw new JogoNaoCadastradoException();
            }
            else
            {
                await _JogoRepository.Remover(id);
            }
        }

        public void Dispose()
        {
            _JogoRepository?.Dispose();
        }
    }
}
