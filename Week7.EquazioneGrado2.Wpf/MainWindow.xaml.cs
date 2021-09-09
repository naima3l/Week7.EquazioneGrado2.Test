using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Week7.EquazioneGrado2.Core;

namespace Week7.EquazioneGrado2.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double a;
        private double b;
        private double c;
        private Equation equation = new Equation();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            c = double.Parse(txtC.Text);

            var risultato = equation.RisolviEquazioneDiSecondoGrado(a, b, c);

            if (risultato == null)
            {
                txtRes.Text = "Il delta è \nnegativo e quindi \nnon ammette \nsoluzione.";
            }
            else if (risultato.Count() == 2)
            {
                txtRes.Text = $"Il delta è \nmaggiore di zero, \nquindi ci sono \n2 soluzioni:\nx1 = {risultato[0]} \nx2= {risultato[1]}";
            }
            else txtRes.Text = $"Il delta è \nuguale a zero, \nquindi x1 e x2 \nsono uguali:\nx1 = x2 = {risultato[0]} ";

            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
        }
    }
}
