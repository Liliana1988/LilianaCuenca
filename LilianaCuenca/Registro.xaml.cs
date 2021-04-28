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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string clave )
        {
          

            InitializeComponent();

            //lblUsuario.Text = usuario;
            //lblClave.Text = clave;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

            try
            {

                double dato1 = Convert.ToDouble(txtMonto.Text);
                
                
               double calculo = (1800 - dato1)  ;
               double calculo1 = (calculo/3);

               double calculo2 = (1800 * 0.05);
               double calculo3 = (calculo1 + calculo2);



                txtPago.Text = calculo3.ToString();

            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");

            }


        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {


          //await

            string nombre = txtNombre.Text;
            string monto = txtMonto.Text;
            string pago = txtPago.Text;

            DisplayAlert("Elemento guardado con exito", "resultado", "aceptar");

            await Navigation.PushAsync(new Resumen(nombre,monto,pago));

                
           
             
        }
    }
}