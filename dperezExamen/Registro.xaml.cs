using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dperezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        private string usuario;
        private string cuota1;
        private string montoinicial;
        private string nombre;
        private string apellido;
        private string edad;
        private string montoinicial1;

        public Page2(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario Conectado: " + usuario;
            this.usuario = usuario;
      
           
        }

        private void dpPaises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dpCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPagomensual_Clicked(object sender, EventArgs e)
        {
            double MontoInicial = Convert.ToDouble(txtMontoInicial.Text);
            double valorTotal = 1800;
            double cuota;

            if (MontoInicial >1800 || MontoInicial <=0)
            {

                DisplayAlert("ERROR", "EL VALOR INGRESADO NO ES CORRECTO", "CERRAR");

            }
            else
            {
                cuota = ((valorTotal - MontoInicial) / 3) + 90;
                txtPagoMensual.Text = cuota.ToString();
                cuota1 = cuota.ToString();
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                edad = txtEdad.Text;
                montoinicial1 = valorTotal.ToString();

            }
            

        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3(usuario,cuota1,nombre,apellido,edad,montoinicial1));
        }
    }
}