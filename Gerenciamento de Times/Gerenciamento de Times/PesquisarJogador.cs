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
    public partial class PesquisarJogador : Form
    {
        public PesquisarJogador()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            txtRespostaPesquisa.Clear();

           string nomeJogador = txtNomePesquisa.Text;
           string resposta = VariaveisGlobais.PesquisarJogador(nomeJogador);


            string[] respostavet = resposta.Split(';');

            if (resposta == "")
                txtRespostaPesquisa.Text = "Nenhum Jogador Encontrado ";
            else
            {
                for (int i = 0; i < respostavet.Length; i++)
                {
                    txtRespostaPesquisa.Text += respostavet[i] + Environment.NewLine;
                }
            }
        }
    }
}
