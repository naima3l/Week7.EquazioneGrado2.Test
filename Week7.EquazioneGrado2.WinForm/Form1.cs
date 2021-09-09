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
        private Equation equation = new Equation();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcola_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            c = double.Parse(txtC.Text);

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

            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
        }
    }
}
