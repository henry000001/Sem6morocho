using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sem6morocho
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mostrar : ContentPage
    {
        private const string Url = "http://192.168.1.29/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Sem6morocho.Datos> _post;


        public Mostrar()
        {
            InitializeComponent();
        }

        private async void btnConsultar_Clicked(object sender, EventArgs e)
        {
            var content = await client.GetStringAsync(Url);
            List<Sem6morocho.Datos> posts =JsonConvert.DeserializeObject<List<Sem6morocho.Datos>>(content);
            //_post - new ObservableCollection<Sem6morocho.Datos>(posts);

            MyListView.ItemsSource = _post;
             
        }

        private async  void btnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}