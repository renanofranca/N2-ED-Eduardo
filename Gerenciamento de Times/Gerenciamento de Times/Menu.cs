using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_de_Times
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarJogador pesquisarjogador = new PesquisarJogador();
            pesquisarjogador.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Lista lista = new Lista();
            lista.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Remover remover = new Remover();
            remover.Show();
        }
    }
}
