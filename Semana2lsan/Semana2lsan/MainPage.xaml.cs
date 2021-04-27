using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana2lsan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }



        private async void btnlogin_Clicked(object sender, EventArgs e)
        {
            try {
                String usuario = Convert.ToString(user.Text);
                String password = Convert.ToString(pass.Text);
                if (usuario == "estudiante2021" && password == "uisrael2021")
                {
                    await Navigation.PushAsync(new login());
                }
                else
                {
                    DisplayAlert("Alerta", "Inserte sus credenciales de forma correcta", "Gracias");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }
        }
    }
}
