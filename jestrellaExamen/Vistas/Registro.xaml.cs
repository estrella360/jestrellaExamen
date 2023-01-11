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
    public partial class Registro : ContentPage
    {
        private string user;
        private string pass;

        public Registro(string user, string pass)
        {
            InitializeComponent();
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;

        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {

            string alumno = txtEstudiante.Text;
            double abono = Convert.ToDouble(txtAbono.Text);
            double saldo = Convert.ToDouble(txtSaldoPendiente.Text);
            double mensualidades = Convert.ToDouble(txtMensualidades.Text);
            double total = Convert.ToDouble(txtTotal.Text);

            double promabono = 4000 - abono;
            txtSaldoPendiente.Text = promabono.ToString();

            double prommensualidad = (promabono/5) * 0.05 + (promabono/5) ;
            txtMensualidades.Text = prommensualidad.ToString();

            double pagoTotal = (prommensualidad * 5) + abono;
            txtTotal.Text = pagoTotal.ToString();

            DisplayAlert("Ingreso Correcto", "Almacenado Correctamente", "OK");

        }


        private void Guardar_Clicked(object sender, EventArgs e)
        {
            string estudiante = txtEstudiante.Text;
            string tot = txtTotal.Text;

            Navigation.PushAsync(new Resumen(estudiante, tot));
        }
    }
}