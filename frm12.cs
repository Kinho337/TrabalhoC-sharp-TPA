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
    public partial class frm12 : Form
    {
        public frm12()
        {
            InitializeComponent();
        }

        private void btnenquanto_Click(object sender, EventArgs e)
        {
            double C, I, F;
            C = Convert.ToDouble(txtN.Text);
            I = 0;

            while (I < 100)
            {
                F = (C * 1.8) + 32 + I;

                if (I == 0)
                {
                    txtr1.Text = F.ToString(txtr1.Text);
                }
                if (I == 10)
                {
                    txtr2.Text = F.ToString(txtr2.Text);
                }
                if (I == 20)
                {
                    txtr3.Text = F.ToString(txtr3.Text);
                }
                if (I == 30)
                {
                    txtr4.Text = F.ToString(txtr4.Text);
                }
                if (I == 40)
                {
                    txtr5.Text = F.ToString(txtr5.Text);
                }
                if (I == 50)
                {
                    txtr6.Text = F.ToString(txtr6.Text);
                }
                if (I == 60)
                {
                    txtr7.Text = F.ToString(txtr7.Text);
                }
                if (I == 70)
                {
                    txtr8.Text = F.ToString(txtr8.Text);
                }
                if (I == 80)
                {
                    txtr9.Text = F.ToString(txtr9.Text);
                }
                if (I == 90)
                {
                    txtr10.Text = F.ToString(txtr10.Text);
                }
                I = I + 10;
            }
        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            double C, I, F;
            C = Convert.ToDouble(txtN.Text);

            for (I = 0; I < 100; I = I + 10)
            {
                F = (C * 1.8) + 32 + I;

                if (I == 0)
                {
                    txtr1.Text = F.ToString(txtr1.Text);
                }
                if (I == 10)
                {
                    txtr2.Text = F.ToString(txtr2.Text);
                }
                if (I == 20)
                {
                    txtr3.Text = F.ToString(txtr3.Text);
                }
                if (I == 30)
                {
                    txtr4.Text = F.ToString(txtr4.Text);
                }
                if (I == 40)
                {
                    txtr5.Text = F.ToString(txtr5.Text);
                }
                if (I == 50)
                {
                    txtr6.Text = F.ToString(txtr6.Text);
                }
                if (I == 60)
                {
                    txtr7.Text = F.ToString(txtr7.Text);
                }
                if (I == 70)
                {
                    txtr8.Text = F.ToString(txtr8.Text);
                }
                if (I == 80)
                {
                    txtr9.Text = F.ToString(txtr9.Text);
                }
                if (I == 90)
                {
                    txtr10.Text = F.ToString(txtr10.Text);
                }
            }
        }

        private void btnrepita_Click(object sender, EventArgs e)
        {
            double C, I, F;
            C = Convert.ToDouble(txtN.Text);
            I = 0;

            do
            {
                F = (C * 1.8) + 32 + I;

                if (I == 0)
                {
                    txtr1.Text = F.ToString(txtr1.Text);
                }
                if (I == 10)
                {
                    txtr2.Text = F.ToString(txtr2.Text);
                }
                if (I == 20)
                {
                    txtr3.Text = F.ToString(txtr3.Text);
                }
                if (I == 30)
                {
                    txtr4.Text = F.ToString(txtr4.Text);
                }
                if (I == 40)
                {
                    txtr5.Text = F.ToString(txtr5.Text);
                }
                if (I == 50)
                {
                    txtr6.Text = F.ToString(txtr6.Text);
                }
                if (I == 60)
                {
                    txtr7.Text = F.ToString(txtr7.Text);
                }
                if (I == 70)
                {
                    txtr8.Text = F.ToString(txtr8.Text);
                }
                if (I == 80)
                {
                    txtr9.Text = F.ToString(txtr9.Text);
                }
                if (I == 90)
                {
                    txtr10.Text = F.ToString(txtr10.Text);
                }
                I = I + 10;
            } while (I < 100);

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtr1.Clear();
            txtr2.Clear();
            txtr3.Clear();
            txtr4.Clear();
            txtr5.Clear();
            txtr6.Clear();
            txtr7.Clear();
            txtr8.Clear();
            txtr9.Clear();
            txtr10.Clear();
            txtN.Focus();
        }
    }
}
