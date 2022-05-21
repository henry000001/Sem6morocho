using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sem6morocho
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnMostrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Mostrar());

        }

        private async void btnActualizar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Actualizar());
        }

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Eliminar());
        }

        private async void btnInsertar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Insertar());


        }
    }
}
