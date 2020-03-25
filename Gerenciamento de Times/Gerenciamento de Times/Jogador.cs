using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Times
{
    class Jogador
    {
        private string nome;
        private int numero;
        private string posicao;

        public string Nome { get => nome; set => nome = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Posicao { get => posicao; set => posicao = value; }
    }
}
