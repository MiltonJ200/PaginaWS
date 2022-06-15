using System;
using System.Web.UI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace PaginaWS
{
    public partial class _Default : Page
    {
        public _Default()
        {
            Load += Page_Load;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var sh = new ServiceReference1.WebService1SoapClient();
            Label1.Text = "Bienvenido: " + Conversions.ToString(sh.Hora());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var suma = new ServiceReference1.WebService1SoapClient();
            int a = (int)Math.Round(Conversion.Val(TextBox1.Text));
            int b = (int)Math.Round(Conversion.Val(TextBox2.Text));
            Label2.Text = suma.Sumar(a, b).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var resta = new ServiceReference1.WebService1SoapClient();
            int a = (int)Math.Round(Conversion.Val(TextBox1.Text));
            int b = (int)Math.Round(Conversion.Val(TextBox2.Text));
            Label2.Text = resta.Restar(a, b).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var multiplicacion = new ServiceReference1.WebService1SoapClient();
            int a = (int)Math.Round(Conversion.Val(TextBox1.Text));
            int b = (int)Math.Round(Conversion.Val(TextBox2.Text));
            Label2.Text = multiplicacion.Multiplicar(a, b).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var division = new ServiceReference1.WebService1SoapClient();
            int a = (int)Math.Round(Convert.ToDouble(TextBox1.Text));
            int b = (int)Math.Round(Convert.ToDouble(TextBox2.Text));
            if (b == 0)
            {
                Label2.Text = "No puedes dividir entre 0, pruebe con otro valor.";
            }
            else
            {
                Label2.Text = division.Dividir(a, b).ToString();
            }
        }
    }
}