using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Times
{
    class NodoJogador
    {
        public Jogador Dado { get; set; }
        public NodoJogador Proximo { get; set; }

        public NodoJogador()
        {
            Proximo = null;
        }
    }
}
