﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Times
{
    class VariaveisGlobais
    {
        public static ListaTime listaTime = new ListaTime();

        public static bool Invertido = false;

        public static bool jogadorEncontrado = false;

        public static string PesquisarJogador(string nome)
        {
            return listaTime.RetornarResultadoPesquisa(nome);
        }

        public static ListaJogador listaJogador = new ListaJogador();
        public static int quatidadetimes;
    }
}
