using System;
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

                InserirNaPosicao(aux, valor);
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


        public bool Pesquisa(string time, string treinador)
        {
            Nodo aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado.NomeTime == time)
                    throw new Exception("Time Já Cadastrado");
                else if(aux.Dado.NomeTreinador == treinador)
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
            Nodo aux = primeiro;
            while (aux != null)
            {
                r = r + Environment.NewLine + aux.Dado.NomeTime;
                aux = aux.Proximo;
            }
            return r.Trim();
        }
    }
}
