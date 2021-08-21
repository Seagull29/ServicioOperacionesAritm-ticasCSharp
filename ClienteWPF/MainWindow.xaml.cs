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

namespace ClienteWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double nro1, nro2, resultado;
        srOperaciones.wbOperacionesSoapClient servicio = new srOperaciones.wbOperacionesSoapClient();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, RoutedEventArgs e)
        {
            GetNumbers();
            resultado = servicio.Sumar(nro1, nro2);
            txtResultado.Text = resultado.ToString();
        }

        private void btnResta_Click(object sender, RoutedEventArgs e)
        {
            GetNumbers();
            resultado = servicio.Restar(nro1, nro2);
            txtResultado.Text = resultado.ToString();
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            GetNumbers();
            resultado = servicio.Multiplicar(nro1, nro2);
            txtResultado.Text = resultado.ToString();
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            GetNumbers();
            if (nro2 == 0)
            {
                txtResultado.Text = "Indeterminado";
            }
            else
            {
                resultado = servicio.Dividir(nro1, nro2);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnFac_Click(object sender, RoutedEventArgs e)
        {
            GetNumber1();
            if (nro1 == 0)
            {
                resultado = 1;
            }
            else if (nro1 < 0)
            {
                txtResultado.Text = "No existe";
            }
            else
            {
                resultado = servicio.Factorial(nro1);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnPot_Click(object sender, RoutedEventArgs e)
        {
            GetNumbers();
            resultado = servicio.Potencia(nro1, nro2);
            txtResultado.Text = resultado.ToString();
        }

        private void btnSen_Click(object sender, RoutedEventArgs e)
        {
            GetNumber1();
            resultado = servicio.Seno(nro1);
            txtResultado.Text = resultado.ToString();
        }

        private void btnTan_Click(object sender, RoutedEventArgs e)
        {
            GetNumber1();
            if (nro1 == 90 || nro1 == 270)
            {
                txtResultado.Text = "Infinito";
            }
            else
            {
                resultado = servicio.Tangente(nro1);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnInver_Click(object sender, RoutedEventArgs e)
        {
            GetNumber1();
            if (nro1 == 0)
            {
                txtResultado.Text = "Indeterminado";
            }
            else
            {
                resultado = servicio.Inverso(nro1);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnRaiz_Click(object sender, RoutedEventArgs e)
        {
            GetNumber1();
            if (nro1 < 0)
            {
                txtResultado.Text = "Es un numero imaginario";
            }
            else
            {
                resultado = servicio.RaizSqr(nro1);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnRaizn_Click(object sender, RoutedEventArgs e)
        {
            GetNumbers();
            if (nro1 < 0 && nro2 % 2 == 0)
            {
                txtResultado.Text = "Es un numero imaginario";
            }
            else
            {
                resultado = servicio.RaizEn(nro1, nro2);
                txtResultado.Text = resultado.ToString();
            }
        }

        void GetNumbers()
        {
            nro1 = double.Parse(txt1.Text.Trim());
            nro2 = double.Parse(txt2.Text.Trim());
        }

        void GetNumber1()
        {
            nro1 = double.Parse(txt1.Text.Trim());
        }
        
    }
}
