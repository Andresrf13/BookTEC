using Informatec.DataModel;
using Parse;
using System;
using System.Collections.Generic;
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
    public sealed partial class ScheduleBus : Page
    {
        public ScheduleBus()
        {
            this.InitializeComponent();
            getRutas();
        }

        private async Task getRutas()
        {
            var query = ParseObject.GetQuery("Ruta");
            IEnumerable<ParseObject> results = await query.FindAsync();
            List<Rutas> rutas = new List<Rutas>() ;
            foreach (var item in results)
            {
                Rutas _nuevo = new Rutas();
                _nuevo.Nombre = item.Get<string>("Nombre");
                _nuevo.Desc = item.Get<string>("Parada");
                rutas.Add(_nuevo);
            }
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                gvRutas.ItemsSource = rutas;
                pbCargaRutas.IsIndeterminate = false;
                pbCargaRutas.Visibility = Visibility.Collapsed;
                txtCargando.Visibility = Visibility.Collapsed;
            });
        }

        private void btnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            splitView.IsPaneOpen = !splitView.IsPaneOpen;
        }

        
    }
}
