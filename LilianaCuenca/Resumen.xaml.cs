using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LilianaCuenca
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre,string monto, string pago)
        {
            InitializeComponent();

          

            lblNombre.Text = nombre;
            lblMonto.Text = monto;
            lblPago.Text = pago;


        }
    }
}