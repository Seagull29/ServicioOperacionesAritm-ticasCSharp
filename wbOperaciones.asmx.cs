using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServicioOperaciones
{
    /// <summary>
    /// Descripción breve de wbOperaciones
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wbOperaciones : System.Web.Services.WebService
    {

        [WebMethod]
        public double Sumar(double n1, double n2)
        {
            return n1 + n2;
        }

        [WebMethod]
        public double Restar(double n1, double n2)
        {
            return n1 - n2;
        }

        [WebMethod]
        public double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        [WebMethod]
        public double Dividir(double n1, double n2)
        {

           
            return n1 / n2;
        }

        [WebMethod]
        public double Potencia(double b, double potencia)
        {
      
            return Math.Pow(b, potencia);
        }

        [WebMethod]
        public double Factorial(double n1)
        {

            int r = 1;

            for (int i = 1; i <= n1; ++i)
            {
                r *= i;
            }
            return r;
        }

        [WebMethod]
        public double Seno(double n1)
        {

            double grado = n1 * Math.PI / 180;
            return Math.Sin(grado);
        }

        [WebMethod]
        public double Tangente(double n1)
        {
            double grado = n1 * Math.PI / 180;    
            return Math.Tan(grado);
        }

        [WebMethod]
        public double Inverso(double n1)
        {
        
            return 1 / n1;
        }

        [WebMethod]
        public double RaizSqr(double n1)
        {

         
            return Math.Sqrt(n1);
        }

        [WebMethod]
        public double RaizEn(double n1, double n2)
        {

            return Math.Pow(n1, 1 / n2);
        }



        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
    }
}
