using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LilianaCuenca
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            //await

            string usuario = txtUsuario.Text;
            string clave = txtPass.Text;
             if (usuario== "estudiante2021" && clave== "uisrael2021")
            {
                await Navigation.PushAsync(new Registro(usuario, clave));
            }
             else
            {
                await DisplayAlert("Ingreso de datos equivocado","resultado","aceptar");
            }
            

        }
    }
}
