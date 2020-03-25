using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Times
{
    class Time
    {
        private string nomeTime;
        private string nomeTreinador;
        private ListaJogador listaJogador = new ListaJogador();


        public string NomeTime { get => nomeTime; set => nomeTime = value; }
        public string NomeTreinador { get => nomeTreinador; set => nomeTreinador = value; }
        internal ListaJogador ListaJogador { get => listaJogador; set => listaJogador = value; }

        //Lista com 11 Jogadores
    }
}
