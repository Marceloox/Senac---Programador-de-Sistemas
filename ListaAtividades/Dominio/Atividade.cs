﻿using ListaAtividades.Dominio;
using ListaAtividades.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades.Dominio
{
    internal class Atividade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Situacao Situacao { get; set; }

        private readonly AtividadeRepositorio repositorio = new();
        
        public bool Criar()
        {
            if (!ValidarTítulo()) 
            {
                return false;
            }

            repositorio.Criar(Titulo);
            return true;
        }

        public bool AtualizarSituacao()
        {
            if (!ValidarId())
            {
                return false;
            }

            if (!ValidarSituacao())
            {
                return false;
            }

            Atividade atividadeEmAndamento = BuscarAtividadeEmAndamento();
            Situacao novaSituacao = BuscarProximaSituacao();

            if (atividadeEmAndamento.Id > 0 && atividadeEmAndamento.Situacao == BuscarProximaSituacao())
            {
                return false;
            }

            repositorio.AtualizarSituacao(Id, (int) novaSituacao);
            return true;
        }

        public Atividade BuscarAtividadeEmAndamento()
        {
            return repositorio.BuscarAtividadeEmAndamento();
        }

        public List<Atividade> ListarAtividadesPendentes()
        {
            return repositorio.ListarAtividadePendentes();
        }

        private bool ValidarId()
        {
            return Id > 0;
        }

        private bool ValidarTítulo()
        {
            return !string.IsNullOrWhiteSpace(Titulo);
        }

        private bool ValidarSituacao()
        {
            return Situacao != Situacao.Concluido;
        }

        private Situacao BuscarProximaSituacao()
        {
            /*if (Situacao == Situacao.Pendente)
            {
                return Situacao.Realizando;
            }

            return Situacao.Concluido;
            */

            return Situacao == Situacao.Pendente ? Situacao.Realizando : Situacao.Concluido;
        }
    }
}
