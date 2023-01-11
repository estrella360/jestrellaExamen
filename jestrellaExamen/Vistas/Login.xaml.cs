using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jestrellaExamen.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
                DisplayAlert("Sin Datos", "Ingrese usuario y contraseña", "OK");
            else
            {
                if (txtUser.Text == "estudiante2023" && txtPass.Text == "uisrael2023")
                {
                    DisplayAlert("Ingreso existoso", "", "OK");
                    Navigation.PushAsync(new Registro(user, pass));
                }
                else
                    DisplayAlert("Ingreso Fallido", "Ingrese correctamente los datos", "OK");
            }
        }
    }
}