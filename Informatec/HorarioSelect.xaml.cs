using Informatec.DataModel;
using Parse;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Informatec
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HorarioSelect : Page
    {
        public HorarioSelect()
        {
            this.InitializeComponent();                
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Rutas objectId = e.Parameter as Rutas;
            tbkTitle.Text = objectId.Nombre;
            gethoras(objectId.ObjectId);
        }

        private async Task gethoras(string objectId)
        {
            var query = ParseObject.GetQuery("Hora").WhereEqualTo("horarios", ParseObject.CreateWithoutData("Ruta", objectId));
            IEnumerable<ParseObject> results = await query.FindAsync();
            List<Hora> horas = new List<Hora>();
            var culture = new CultureInfo("es-CR");
            
            foreach (var item in results)
            {
                Hora _nuevo = new Hora();
                _nuevo.hora = item.Get<DateTime>("Hora");
                _nuevo.llegada = item.Get<bool>("LLegada");
                bool toggle =  toggleSwitch.IsOn;

                _nuevo.horaformat = _nuevo.hora.ToString("t", culture);
                if (_nuevo.hora.TimeOfDay < TimeSpan.FromHours(12))
                {
                    _nuevo.tiempo = "Mañana";
                }else if(_nuevo.hora.TimeOfDay < TimeSpan.FromHours(18))
                {
                    _nuevo.tiempo = "Tarde";
                }
                else
                {
                    _nuevo.tiempo = "Noche";
                }
                _nuevo.sabado = item.Get<bool>("sabado");
                _nuevo.visibility = (toggle != _nuevo.llegada) ? Visibility.Visible : Visibility.Collapsed;
                horas.Add(_nuevo);
            }
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {                
                gvHoras.Visibility = Visibility.Visible;
                gvHoras.ItemsSource = horas;                
                pbCargaRutas.IsIndeterminate = false;
                pbCargaRutas.Visibility = Visibility.Collapsed;
                txtCargando.Visibility = Visibility.Collapsed;
            });
        }


        private void btnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            splitView.IsPaneOpen = !splitView.IsPaneOpen;
        }

        private  void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            bool toggle = toggleSwitch.IsOn;
            List<Hora> horas =  gvHoras.ItemsSource as List<Hora>;
            if(horas != null)
            {
                foreach (var item in horas)
                {
                    item.visibility = (item.visibility != Visibility.Visible) ? Visibility.Visible : Visibility.Collapsed;
                }
                gvHoras.ItemsSource = horas;
               
            }
        }
    }
}
