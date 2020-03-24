using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Times
{
    class Nodo
    {
        public string Dado { get; set; }
        public Nodo Proximo { get; set; }

        public Nodo()
        {
            Dado = string.Empty;
            Proximo = null;
        }

    }
}
