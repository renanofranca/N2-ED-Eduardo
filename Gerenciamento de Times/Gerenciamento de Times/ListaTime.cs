﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Times
{
    class ListaTime
    {
        public Nodo primeiro = null; // ponteiro para o primeiro elemento da lista        
        public Nodo ultimo = null;
        int qtde = 0;

        /// <summary>
        /// Método para inserir um valor na lista
        /// </summary>
        /// <param name="anterior">o nodo que será o anterior ao nodo inserido.
        /// Se o novo nodo for o primeiro, passe null</param>
        /// <param name="valor">o valor a ser inserido</param>
        private void InserirNaPosicao(Nodo anterior, Time valor)
        {
            Nodo novo = new Nodo();
            novo.Dado = valor;
            if (anterior == null)
            {
                if (qtde == 0)
                {
                    primeiro = novo;
                    novo.Anterior = null;
                }
                else
                {
                    primeiro.Anterior = novo;
                    novo.Proximo = primeiro;
                    primeiro = novo;
                }
            }
            else
            {
                novo.Anterior = ultimo;
                novo.Proximo = anterior.Proximo;
                anterior.Proximo = novo;
            }
            if (novo.Proximo == null)
            {
                ultimo = novo;
            }
            qtde++;
            VariaveisGlobais.quatidadetimes = qtde;
        }

        /// <summary>
        /// Insere um valor no início da lista
        /// </summary>
        /// <param name="valor"></param>
        public void InserirNoInicio(Time valor)
        {
            InserirNaPosicao(null, valor);
        }


        /// <summary>
        /// Insere um valor no final da lista
        /// </summary>
        /// <param name="valor"></param>
        public void InserirNoFim(Time valor)
        {
            if (qtde == 0)
                InserirNoInicio(valor);
            else
            {
                Nodo aux = primeiro;
                while (aux.Proximo != null)
                    aux = aux.Proximo;

                InserirNaPosicao(ultimo, valor);
            }
        }
        /// <summary>
        /// Insere em uma posição, iniciando do 0
        /// </summary>
        /// <param name="valor">valor</param>
        /// <param name="posicao">posicao iniciando do 1</param>
        public void InserirNaPosicao(Time valor, int posicao)
        {
            if (posicao > qtde || posicao < 0)
                throw new Exception("Não é possível inserir.");

            if (posicao == 0)
                InserirNoInicio(valor);
            else
            {
                //descobre qual é o nodo anterior ao que será incluído
                Nodo aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

                InserirNaPosicao(aux, valor);
            }
        }

        /// <summary>
        /// Remove um elemento da lista com base em sua posição, que inicia
        /// do zero
        /// </summary>
        /// <param name="posicao">posição</param>
        public void RemoverDaPosicao(int posicao)
        {
            if (posicao >= qtde || posicao < 0 || qtde == 0)
                throw new Exception("Não é possível remover.");
            if (posicao == 0)
            {
                if (primeiro.Proximo == null)
                {
                    primeiro = null;
                    ultimo = null;
                }
                else
                {
                    primeiro = primeiro.Proximo;
                    primeiro.Anterior = null;
                }
            }
            else
            {
                //descobre qual é o nodo anterior que será excluido
                Nodo aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;
                if (posicao + 1 == qtde)
                {
                    aux.Proximo = aux.Proximo.Proximo;
                    ultimo = aux;
                }
                else
                {
                    aux.Proximo = aux.Proximo.Proximo;
                    aux.Proximo.Anterior = aux;
                }
            }
            qtde--;
        }
        public bool Pesquisa(string time, string treinador)
        {
            Nodo aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado.NomeTime == time)
                    throw new Exception("Time Já Cadastrado");
                else if (aux.Dado.NomeTreinador == treinador)
                    throw new Exception("Técnico Já Cadastrado");
                aux = aux.Proximo;
            }
            return false;
        }

        public void InserirJogador(string time, Jogador jogador)
        {
            Nodo aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado.NomeTime == time)
                {
                    aux.Dado.ListaJogador.InserirNaPosicao(jogador);
                    return;
                }
                aux = aux.Proximo;
            }
        }

        public void PesquisarDoJogador(Jogador jogador, string nomeTime)
        {
            Nodo aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado.NomeTime == nomeTime)
                {
                    aux.Dado.ListaJogador.PesquisaJogador(jogador);
                    return;
                }
                aux = aux.Proximo;

            }
        }

        public string RetornarResultadoPesquisa(string nome)
        {
            string resposta = "";
            Nodo aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado.ListaJogador.PesquisaJogador(nome))
                {
                    resposta += aux.Dado.NomeTime + ";";
                }
                aux = aux.Proximo;
            }

            return resposta;
        }
        public string Listar()
        {
            string r = string.Empty;

            if (VariaveisGlobais.Invertido == false)
            {
                Nodo aux = primeiro;
                return ListarTimes(aux, r);
            }
            else
            {
                Nodo aux = ultimo;
                return ListarInvertido(aux, r);

            }
        }
        public string ListarTimes(Nodo aux, string r)
        {
            if (aux == null)
                return r;
            else
                return r += Environment.NewLine + "Time: " + aux.Dado.NomeTime + " Treinador: " + aux.Dado.NomeTreinador + Environment.NewLine +
                       aux.Dado.ListaJogador.Listar() + Environment.NewLine + ListarTimes(aux.Proximo, r);
        }
        public string ListarInvertido(Nodo aux, string r)
        {
            if (aux == null)
                return r;
            else
                return r += Environment.NewLine + "Time: " + aux.Dado.NomeTime + " Treinador: " + aux.Dado.NomeTreinador + Environment.NewLine +
                       aux.Dado.ListaJogador.Listar() + Environment.NewLine + ListarInvertido(aux.Anterior, r);
        }

        public void RemoverTime(string time)
        {
            int contagem = 0;
            Nodo aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado.NomeTime == time)
                {
                    RemoverDaPosicao(contagem);
                    return;
                }
                contagem++;
                aux = aux.Proximo;
            }

            throw new Exception("Este Time não esta cadastrado");
        }

        public string RetornaSomenteOsTimes()
        {
            string retorno = "";
            if (qtde > 0)
            {
                Nodo aux = primeiro;
                while (aux != null)
                {
                    retorno += aux.Dado.NomeTime + "|";
                    aux = aux.Proximo;
                }
                retorno = retorno.Substring(0, retorno.Length - 1);
            }
            return retorno;

        }

        public void RemoverJogador(string jogador)
        {
            Nodo aux = primeiro;
            while (aux != null)
            {
                aux.Dado.ListaJogador.Removerjogador(jogador);
                aux = aux.Proximo;
            }
            if (VariaveisGlobais.jogadorEncontrado == false || aux != null)
                throw new Exception("Este Jogador não esta cadastrado");
        }
    }
}
