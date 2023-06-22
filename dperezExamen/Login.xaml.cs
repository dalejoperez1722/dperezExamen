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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnIniciaSesion_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string contrasena = "uisrael2023";

            if (txtusuario.Text == usuario && txtcontrasena.Text == contrasena)
            {
                Navigation.PushAsync(new Page2(usuario));
            }
            else
            {
                DisplayAlert("error", "Usuario/Contraseña Incorrecta", "cerrar");
            }

        }
    }
}