﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Times
{
    class ListaJogador
    {
        public NodoJogador primeiro = null; // ponteiro para o primeiro elemento da lista        
        int qtde = 0;

        /// <summary>
        /// Método para inserir um valor na lista
        /// </summary>
        /// <param name="anterior">o nodo que será o anterior ao nodo inserido.
        /// Se o novo nodo for o primeiro, passe null</param>
        /// <param name="valor">o valor a ser inserido</param>
        private void InserirNaPosicao(NodoJogador anterior, Jogador valor)
        {
            NodoJogador novo = new NodoJogador();
            novo.Dado = valor;

            if (anterior == null)
            {
                if (qtde == 0)
                    primeiro = novo;
                else
                {
                    novo.Proximo = primeiro;
                    primeiro = novo;
                }
            }
            else
            {
                novo.Proximo = anterior.Proximo;
                anterior.Proximo = novo;
            }
            qtde++;
        }

        /// <summary>
        /// Insere um valor no início da lista
        /// </summary>
        /// <param name="valor"></param>
        public void InserirNoInicio(Jogador valor)
        {
            InserirNaPosicao(null, valor);
        }


        /// <summary>
        /// Insere um valor no final da lista
        /// </summary>
        /// <param name="valor"></param>
        public void InserirNoFim(Jogador valor)
        {
            if (qtde == 0)
                InserirNoInicio(valor);
            else
            {
                NodoJogador aux = primeiro;
                while (aux.Proximo != null)
                    aux = aux.Proximo;

                InserirNaPosicao(aux, valor);
            }
        }
        /// <summary>
        /// Insere em uma posição, iniciando do 0
        /// </summary>
        /// <param name="valor">valor</param>
        /// <param name="posicao">posicao iniciando do 1</param>
        public void InserirNaPosicao(Jogador valor)
        {            
            //Verificar Posição 
            int contagem = 0;
            NodoJogador aux = primeiro;
            while (aux != null)
            {
                if (valor.Numero > aux.Dado.Numero)
                {
                    contagem++;
                }
                else
                    break;
                aux = aux.Proximo;
            }

            if (contagem > qtde || contagem < 0)
                throw new Exception("Não é possível inserir.");
            if (qtde >= 11)
                throw new Exception("Não é possível inserir. Numero maxio atingido");



            if (contagem == 0)
                InserirNoInicio(valor);     
            else
            {
                //descobre qual é o nodo anterior ao que será incluído
                NodoJogador aux2 = primeiro;
                for (int i = 1; i < contagem; i++)
                    aux = aux.Proximo;

                InserirNaPosicao(aux2, valor);
            }
        }


        /// <summary>
        /// Retorna um string com todos os elementos da lista concatenados
        /// </summary>
        /// <returns></returns>
        public string Listar()
        {
            string r = string.Empty;
            NodoJogador aux = primeiro;
            while (aux != null)
            {
                r = r + Environment.NewLine + aux.Dado;
                aux = aux.Proximo;
            }
            return r.Trim();
        }
        /// <summary>
        /// Retorna um 
        /// </summary>
        /// <returns></returns>
        public void PesquisaJogador(Jogador valor)
        {
            NodoJogador aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado.Nome == valor.Nome || aux.Dado.Numero == valor.Numero)
                    throw new Exception("Jogador ou numero já cadastrado");
                aux = aux.Proximo;
            }
        }

        public bool PesquisaJogador(string valor)
        {
            NodoJogador aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado.Nome == valor)
                    return true;
                aux = aux.Proximo;
            }
            return false;
        }

        //public bool Pesquisa(string time, string treinador)
        //{
        //    NodoJogador aux = primeiro;
        //    while (aux != null)
        //    {
        //        if (aux.Dado.NomeTime == time)
        //            throw new Exception("Time Já Cadastrado");
        //        else if (aux.Dado.NomeTreinador == treinador)
        //            throw new Exception("Técnico Já Cadastrado");
        //        aux = aux.Proximo;
        //    }
        //    return false;
        //}
    }
}
