﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Times
{
    class ListaDinamica
    {
        Nodo primeiro = null; // ponteiro para o primeiro elemento da lista        
        int qtde = 0;

        /// <summary>
        /// Método para inserir um valor na lista
        /// </summary>
        /// <param name="anterior">o nodo que será o anterior ao nodo inserido.
        /// Se o novo nodo for o primeiro, passe null</param>
        /// <param name="valor">o valor a ser inserido</param>
        private void InserirNaPosicao(Nodo anterior, string valor)
        {
            Nodo novo = new Nodo();
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
        public void InserirNoInicio(string valor)
        {
            InserirNaPosicao(null, valor);
        }


        /// <summary>
        /// Insere um valor no final da lista
        /// </summary>
        /// <param name="valor"></param>
        public void InserirNoFim(string valor)
        {
            if (qtde == 0)
                InserirNoInicio(valor);
            else
            {
                Nodo aux = primeiro;
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
        public void InserirNaPosicao(string valor, int posicao)
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
                primeiro = primeiro.Proximo;
            else
            {
                //descobre qual é o nodo anterior que será excluido
                Nodo aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

                aux.Proximo = aux.Proximo.Proximo;
            }

            qtde--;
        }


        /// <summary>
        /// Retorna um string com todos os elementos da lista concatenados
        /// </summary>
        /// <returns></returns>
        public string Listar()
        {
            string r = string.Empty;
            Nodo aux = primeiro;
            while (aux != null)
            {
                r = r + Environment.NewLine + aux.Dado;
                aux = aux.Proximo;
            }
            return r.Trim();
        }

        public bool Pesquisa(string valor)
        {
            Nodo aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado == valor)
                    return true;
                aux = aux.Proximo;
            }
            return false;
        }
    }
}
