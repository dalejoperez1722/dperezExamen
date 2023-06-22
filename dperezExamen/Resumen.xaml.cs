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
    public partial class Page3 : ContentPage
    {
        public Page3(string usuario ,string cuota1,string nombre,string apellido, string edad,string montoinicial1)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario Conectado: " + usuario;
            txtPagoMensual.Text = cuota1;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtEdad.Text = edad;
            txtMontoInicial.Text = montoinicial1;
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {

        }
    }
}