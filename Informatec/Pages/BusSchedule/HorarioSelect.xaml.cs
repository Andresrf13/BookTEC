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
using Windows.UI.Core;
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
        IEnumerable<Hora> ieHoras = null;
        private bool sabado = false;
        byte tiempo = 0;

        public HorarioSelect()
        {
            this.InitializeComponent();                
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            currentView.BackRequested += CurrentView_BackRequested;
            //currentView.BackRequested -= CurrentView_BackRequested;
            base.OnNavigatedTo(e);
            Rutas objectId = e.Parameter as Rutas;
            tbkTitle.Text = objectId.Nombre;
            gethoras(objectId.ObjectId);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.BackRequested -= CurrentView_BackRequested;
        }

        private void CurrentView_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (Frame.CanGoBack)
                Frame.GoBack();  
        }

        private async Task gethoras(string objectId)
        {
            var query = ParseObject.GetQuery("Hora").WhereEqualTo("horarios", ParseObject.CreateWithoutData("Ruta", objectId));
            IEnumerable<ParseObject> results = await query.FindAsync();          
            var culture = new CultureInfo("es-CR");

             List<Hora> horas = new List<Hora>();

            foreach (var item in results)
            {
                Hora _nuevo = new Hora();
                _nuevo.hora = item.Get<DateTime>("Hora");
                _nuevo.llegada = item.Get<bool>("LLegada");
                bool toggle =  toggleSwitch.IsOn;

                _nuevo.horaformat = _nuevo.hora.ToString("t", culture);             
                _nuevo.sabado = item.Get<bool>("sabado");
                
                horas.Add(_nuevo);
                
            }

            ieHoras = horas.AsEnumerable();

            var resultado = ieHoras.Where(x => x.llegada == true && x.sabado == sabado);

            var selection = ieHoras.Where(x => x.hora.TimeOfDay >= DateTime.Now.TimeOfDay).FirstOrDefault();

            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {                
                gvHoras.Visibility = Visibility.Visible;
                gvHoras.ItemsSource = resultado;
                gvHoras.SelectedItem = (selection != null) ? selection : gvHoras.SelectedItem;
                gvHoras.ScrollIntoView(gvHoras.SelectedItem);
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
            var resultado = ieHoras.Where(x => x.llegada != toggleSwitch.IsOn && x.sabado == sabado);
            gvHoras.ItemsSource = resultado;
            var selection = resultado.Where(x => x.hora.TimeOfDay >= DateTime.Now.TimeOfDay).FirstOrDefault();
            gvHoras.SelectedItem = (selection != null) ? selection : gvHoras.SelectedItem;
            gvHoras.ScrollIntoView(gvHoras.SelectedItem);
        }

        private void btnmanana_Click(object sender, RoutedEventArgs e)
        {            
            var resultado = ieHoras.Where(x => x.llegada != toggleSwitch.IsOn && x.hora.TimeOfDay < TimeSpan.FromHours(12)  && x.sabado == sabado);
            gvHoras.ItemsSource = resultado;
            tiempo = 1;
            var selection = resultado.Where(x => x.hora.TimeOfDay >= DateTime.Now.TimeOfDay).FirstOrDefault();
            gvHoras.SelectedItem = (selection != null) ? selection : gvHoras.SelectedItem;
            gvHoras.ScrollIntoView(gvHoras.SelectedItem);
        }

        private void btntarde_Click(object sender, RoutedEventArgs e)
        {
            var resultado = ieHoras.Where(x => x.llegada != toggleSwitch.IsOn && x.hora.TimeOfDay > TimeSpan.FromHours(12) && x.hora.TimeOfDay < TimeSpan.FromHours(18) && x.sabado == sabado);
            gvHoras.ItemsSource = resultado;
            tiempo = 2;
            var selection = resultado.Where(x => x.hora.TimeOfDay >= DateTime.Now.TimeOfDay).FirstOrDefault();
            gvHoras.SelectedItem = (selection != null) ? selection : gvHoras.SelectedItem;
            gvHoras.ScrollIntoView(gvHoras.SelectedItem);
        }

        private void btnnoche_Click(object sender, RoutedEventArgs e)
        {
            var resultado = ieHoras.Where(x => x.llegada != toggleSwitch.IsOn && x.hora.TimeOfDay >= TimeSpan.FromHours(18) && x.sabado == sabado);
            gvHoras.ItemsSource = resultado;
            tiempo = 3;
            var selection = resultado.Where(x => x.hora.TimeOfDay >= DateTime.Now.TimeOfDay).FirstOrDefault();
            gvHoras.SelectedItem = (selection != null) ? selection : gvHoras.SelectedItem;
            gvHoras.ScrollIntoView(gvHoras.SelectedItem);
        }

      

        private void btnall_Click(object sender, RoutedEventArgs e)
        {
            var resultado = ieHoras.Where(x => x.llegada != toggleSwitch.IsOn && x.sabado == sabado);
            gvHoras.ItemsSource = resultado;
            tiempo = 0;
            var selection = resultado.Where(x => x.hora.TimeOfDay >= DateTime.Now.TimeOfDay).FirstOrDefault();
            gvHoras.SelectedItem = (selection != null) ? selection : gvHoras.SelectedItem;
            gvHoras.ScrollIntoView(gvHoras.SelectedItem);
        }

        private void switchSabados_Click(object sender, RoutedEventArgs e)
        {
            sabado = !sabado;
            switch (tiempo)
            {
                case 0:
                    btnall_Click(null, null);
                    break;
                case 1:
                    btnmanana_Click(null, null);
                    break;
                case 2:
                    btntarde_Click(null, null);
                    break;
                case 3:
                    btnnoche_Click(null, null);
                    break;
                default:
                    break;
            }
        }
    }
}
