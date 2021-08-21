using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class Index : System.Web.UI.Page
    {
        srOperaciones.wbOperacionesSoapClient servicio = new srOperaciones.wbOperacionesSoapClient();
        double nro1, nro2, resultado;

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            GetNumbers();
            resultado = servicio.Sumar(nro1, nro2);
            txtResultado.Text = resultado.ToString();
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            GetNumbers();
            resultado = servicio.Restar(nro1, nro2);
            txtResultado.Text = resultado.ToString();
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            GetNumbers();
            resultado = servicio.Multiplicar(nro1, nro2);
            txtResultado.Text = resultado.ToString();
        }

        protected void btnDividir_Click(object sender, EventArgs e)
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

        protected void btnPotencia_Click(object sender, EventArgs e)
        { 
            GetNumbers();
            resultado = servicio.Potencia(nro1, nro2);
            txtResultado.Text = resultado.ToString();
        }

        protected void btnFactorial_Click(object sender, EventArgs e)
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

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSeno_Click(object sender, EventArgs e)
        {
            GetNumber1();
            resultado = servicio.Seno(nro1);
            txtResultado.Text = resultado.ToString();
        }

        protected void btnTangente_Click(object sender, EventArgs e)
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

        protected void btnInverso_Click(object sender, EventArgs e)
        {
            GetNumber1();
            if(nro1 == 0)
            {
                txtResultado.Text = "Indeterminado";
            }
            else
            {
                resultado = servicio.Inverso(nro1);
                txtResultado.Text = resultado.ToString();
            }
        }

        protected void btnRaizC_Click(object sender, EventArgs e)
        {
            GetNumber1();
            if(nro1 < 0)
            {
                txtResultado.Text = "Es un numero imaginario";
            }
            else
            {
                resultado = servicio.RaizSqr(nro1);
                txtResultado.Text = resultado.ToString();
            }
        }

        protected void btnRaizEn_Click(object sender, EventArgs e)
        {
            GetNumbers();
            if (nro1 < 0 && nro2 % 2 ==0)
            {
                txtResultado.Text = "Es un numero imaginario";
            }
            else
            {
                resultado = servicio.RaizEn(nro1,nro2);
                txtResultado.Text = resultado.ToString();
            }
        }

        void GetNumbers()
        {
            nro1 = double.Parse(txtNro1.Text.Trim());
            nro2 = double.Parse(txtNro2.Text.Trim());
        }

        void GetNumber1()
        {
            nro1 = double.Parse(txtNro1.Text.Trim());
        }
        
    }
}