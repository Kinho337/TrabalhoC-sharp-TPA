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
    public partial class frm11 : Form
    {
        public frm11()
        {
            InitializeComponent();
        }

        private void btnenquanto_Click(object sender, EventArgs e)
        {
            double N, I, R;
            N = Convert.ToDouble(txtN.Text);
            I = 1;

            while (I < 11)
            {
                R = N * I;

                if (I == 1)
                {
                    txtr1.Text = R.ToString(txtr1.Text);
                }
                if (I == 2)
                {
                    txtr2.Text = R.ToString(txtr2.Text);
                }
                if (I == 3)
                {
                    txtr3.Text = R.ToString(txtr3.Text);
                }
                if (I == 4)
                {
                    txtr4.Text = R.ToString(txtr4.Text);
                }
                if (I == 5)
                {
                    txtr5.Text = R.ToString(txtr5.Text);
                }
                if (I == 6)
                {
                    txtr6.Text = R.ToString(txtr6.Text);
                }
                if (I == 7)
                {
                    txtr7.Text = R.ToString(txtr7.Text);
                }
                if (I == 8)
                {
                    txtr8.Text = R.ToString(txtr8.Text);
                }
                if (I == 9)
                {
                    txtr9.Text = R.ToString(txtr9.Text);
                }
                if (I == 10)
                {
                    txtr10.Text = R.ToString(txtr10.Text);
                }
                I = I + 1;
            }
        }

        private void btnrepita_Click(object sender, EventArgs e)
        {
            double N, I, R;
            N = Convert.ToDouble(txtN.Text);
            I = 1;

            do
            {
                R = N * I;

                if (I == 1)
                {
                    txtr1.Text = R.ToString(txtr1.Text);
                }
                if (I == 2)
                {
                    txtr2.Text = R.ToString(txtr2.Text);
                }
                if (I == 3)
                {
                    txtr3.Text = R.ToString(txtr3.Text);
                }
                if (I == 4)
                {
                    txtr4.Text = R.ToString(txtr4.Text);
                }
                if (I == 5)
                {
                    txtr5.Text = R.ToString(txtr5.Text);
                }
                if (I == 6)
                {
                    txtr6.Text = R.ToString(txtr6.Text);
                }
                if (I == 7)
                {
                    txtr7.Text = R.ToString(txtr7.Text);
                }
                if (I == 8)
                {
                    txtr8.Text = R.ToString(txtr8.Text);
                }
                if (I == 9)
                {
                    txtr9.Text = R.ToString(txtr9.Text);
                }
                if (I == 10)
                {
                    txtr10.Text = R.ToString(txtr10.Text);
                }
                I = I + 1;
            } while (I < 11);
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

        private void btnpara_Click(object sender, EventArgs e)
        {
            double N, I, R;
            N = Convert.ToDouble(txtN.Text);
            for (I = 1; I < 11; I++)
            {
                R = N * I;

                if (I == 1)
                {
                    txtr1.Text = R.ToString(txtr1.Text);
                }
                if (I == 2)
                {
                    txtr2.Text = R.ToString(txtr2.Text);
                }
                if (I == 3)
                {
                    txtr3.Text = R.ToString(txtr3.Text);
                }
                if (I == 4)
                {
                    txtr4.Text = R.ToString(txtr4.Text);
                }
                if (I == 5)
                {
                    txtr5.Text = R.ToString(txtr5.Text);
                }
                if (I == 6)
                {
                    txtr6.Text = R.ToString(txtr6.Text);
                }
                if (I == 7)
                {
                    txtr7.Text = R.ToString(txtr7.Text);
                }
                if (I == 8)
                {
                    txtr8.Text = R.ToString(txtr8.Text);
                }
                if (I == 9)
                {
                    txtr9.Text = R.ToString(txtr9.Text);
                }
                if (I == 10)
                {
                    txtr10.Text = R.ToString(txtr10.Text);
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal frmprincipal = new frmprincipal();
            frmprincipal.Show();
        }
    }
}
