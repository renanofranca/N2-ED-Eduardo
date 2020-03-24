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

        ListaTime listaTime = new ListaTime();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtNomeTime.Text.Length != 0 && txtNomeTreinador.Text.Length != 0)
            {
                Time time = new Time();


                time.NomeTime = txtNomeTime.Text;
                time.NomeTreinador = txtNomeTreinador.Text;

                //Validar Time existe, e adicionar a Lista
                try
                {
                    listaTime.Pesquisa(txtNomeTime.Text, txtNomeTreinador.Text);
                    listaTime.InserirNoFim(time);
                    cbxTimes.Items.Add(txtNomeTime.Text);

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                txtNomeTime.Clear();
                txtNomeTreinador.Clear();
            }
            else
            {
                MessageBox.Show("Nome do Time ou do Treinador não preenchidos");
            }
        }

        private void cbxTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCadastrarJogador.Enabled = true;
        }

        private void btnCadastrarJogador_Click(object sender, EventArgs e)
        {
            Jogador jogodaor = new Jogador();
            string time = cbxTimes.Text;


        }
    }
}
