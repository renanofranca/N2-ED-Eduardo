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
    public partial class Remover : Form
    {
        public Remover()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Campo Nomenão preenchido");
                return;
            }
            if (rdbTime.Checked)
            {
                try
                {
                    VariaveisGlobais.listaTime.RemoverTime(txtNome.Text);

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }                
            }
        }

    }
}
