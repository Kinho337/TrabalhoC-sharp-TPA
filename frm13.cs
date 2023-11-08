using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhoLHMPCsharp
{
    public partial class frm13 : Form
    {
        public frm13()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        double areatotal;
        private void btncalcular_Click(object sender, EventArgs e)
        {
            double area, comp, larg;

            larg = Convert.ToDouble(txtlarg.Text);
            comp = Convert.ToDouble(txtcomp.Text);

            area = larg * comp;
            areatotal += area;
            txtarea.Text = area.ToString();
            var result = MessageBox.Show("Deseja continuar calculando comodos?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //acima esta a caixa de dialogo ou caixa de mensagem
            if (result == DialogResult.Yes)
            {
                txtnome.Clear();
                txtcomp.Clear();
                txtlarg.Clear();
                txtarea.Clear();
                txtnome.Focus();
            }
            else
            {
                txtareatotal.Visible = true;
                lbltotal.Visible = true;
                txtareatotal.Text = areatotal.ToString();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtarea.Clear();
            txtcomp.Clear();
            txtlarg.Clear();
            txtnome.Clear();
            txtareatotal.Clear();
            txtareatotal.Visible = false;
            lbltotal.Visible = false;
            txtnome.Focus();
        }
    }
}
