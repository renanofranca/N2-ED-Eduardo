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
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        ListaTime listaTime = new ListaTime();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtNomeTime.Text.Length != 0 && txtNomeTreinador.Text.Length != 0)
            {
                Time time = new Time();

                time.NomeTime = txtNomeTime.Text.Trim();
                time.NomeTreinador = txtNomeTreinador.Text.Trim();

                //Validar Time existe, e adicionar a Lista
                try
                {
                    VariaveisGlobais.listaTime.Pesquisa(txtNomeTime.Text.Trim(), txtNomeTreinador.Text.Trim());
                    VariaveisGlobais.listaTime.InserirNoFim(time);
                    cbxTimes.Items.Add(txtNomeTime.Text.Trim());

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
            string time = cbxTimes.Text.Trim();
            Jogador jogador = new Jogador();
            if (txtNomeJogador.Text.Trim() == "" || cbxPosicaoJogador.Text.Trim() == "")
            {
                MessageBox.Show("Nome do Jogador ou Posição Não Preenchidos");
                return;
            }
            try
            {
                jogador.Nome = txtNomeJogador.Text.Trim();
                jogador.Numero = int.Parse(txtCamisaJogador.Text.Trim());
                jogador.Posicao = cbxPosicaoJogador.Text.Trim();
            }
            catch
            {
                MessageBox.Show("Numero Da Camisa é Invalido");
                return;
            }

            try
            {
                VariaveisGlobais.listaTime.PesquisarDoJogador(jogador, time);
                VariaveisGlobais.listaTime.InserirJogador(time, jogador);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            txtNomeJogador.Clear();
            txtCamisaJogador.Clear();
            

        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            string timesCadastrados = VariaveisGlobais.listaTime.RetornaSomenteOsTimes();
            string[] timesCadastradosVetor = timesCadastrados.Split('|');

            if(timesCadastrados != "")
            {
                for (int i = 0; i < timesCadastradosVetor.Length; i++)
                {
                    cbxTimes.Items.Add(timesCadastradosVetor[i]);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
