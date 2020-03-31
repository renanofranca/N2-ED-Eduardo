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
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
            txtLista.ReadOnly = true;
            txtLista.ScrollBars = ScrollBars.Vertical;
        }
        
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (rdbInvertido.Checked)
                VariaveisGlobais.Invertido = true;
            if (rdbListar.Checked)
                VariaveisGlobais.Invertido = false;

            txtLista.Text = "";
            txtLista.Text = Convert.ToString(VariaveisGlobais.listaTime.Listar());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtLista_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
