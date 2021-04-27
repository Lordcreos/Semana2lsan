using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana2lsan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnTotal_Clicked(object sender, EventArgs e)
        {
            try
            {
                double dato1 = Convert.ToDouble(TxtDato1.Text);
                double dato2 = Convert.ToDouble(TxtDato2.Text);
                double dato3 = Convert.ToDouble(TxtDato3.Text);
                double dato4 = Convert.ToDouble(TxtDato4.Text);

                double total = ((dato1 * 0.3) + (dato2 * 0.2)) + ((dato3 * 0.3) + (dato4 * 0.2));

                TxtTotal.Text = total.ToString();
                if (total >= 7)
                {
                    DisplayAlert("Alerta", "Aprobado", "Gracias");
                }
                else
                {
                    DisplayAlert("Alerta", "Reprobado", "Gracias");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }
        }
    }
}