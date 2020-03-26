using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Times
{
    class VariaveisGlobais
    {
        private int qtdeTime = 0;
        public ListaTime listaTime = new ListaTime();

        public int QtdeTime { get => qtdeTime; set => qtdeTime = value; }
    }
}
