using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week7.EquazioneGrado2.Core;

namespace Week7.EquazioneGrado2.WinForm
{
    public partial class Form1 : Form
    {
        private double a;
        private double b;
        private double c;
        private double res;
        private Equation equation = new Equation();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            a = double.Parse(txtA.Text);
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            b = double.Parse(txtB.Text);
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            c = double.Parse(txtC.Text);
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            var risultato = equation.RisolviEquazioneDiSecondoGrado(a, b, c);

            if(risultato == null)
            {
                txtRes.Text = "Il delta è negativo e quindi non ammette soluzione";
            }
            else if(risultato.Count() == 2)
            {
                txtRes.Text = $"x1 = {risultato[0]} \nx2= {risultato[1]}";
            }
            else txtRes.Text = $"x1 = x2 = {risultato[0]} ";
        }
    }
}
