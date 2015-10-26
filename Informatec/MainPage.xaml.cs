using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Parse;
using Windows.UI.Core;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Informatec
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {

            this.InitializeComponent();
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            /*  insertCartago();
              insertSanjose();
              inserttibas();
              insertdesampa();
              insertalajuela();
              insertheredia(); */
        }

        private async void insertheredia()
        {
            var myPost = new ParseObject("Ruta")
            {
                { "Nombre", "Heredia" },
                { "Parada", "Frente restaurante el Gran Chaparral" }
            };

            // Create the comment
            var myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 6, 05, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 11, 30, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();
        }

        private async void insertalajuela()
        {
            var myPost = new ParseObject("Ruta")
            {
                { "Nombre", "Alajuela" },
                { "Parada", "Parque Juan Santamaria" }
            };

            // Create the comment
            var myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 6, 05, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

             myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 17, 5, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();
        }

        private async void insertdesampa()
        {
            var myPost = new ParseObject("Ruta")
            {
                { "Nombre", "Desamparados" },
                { "Parada", "Banco Nacional, parque central" }
            };

            // Create the comment
            var myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 6, 30, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();
        }

        private async void inserttibas()
        {
            var myPost = new ParseObject("Ruta")
            {
                { "Nombre", "Tibas" },
                { "Parada", "Parque de tibas, costado oeste" }
            };

            // Create the comment
            var myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 6, 15, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();
        }

        private async void insertSanjose()
        {
            var myPost = new ParseObject("Ruta")
            {
                { "Nombre", "San Jose" },
                { "Parada", "Costado oeste CCSS" }
            };

            // Create the comment
            var myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 6, 35, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 13, 00, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();


            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 14, 00, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 15, 00, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 16, 00, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 17, 00, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 18, 00, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 20, 00, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 21, 00, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 12, 05, 0) }, { "Llegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 13, 5, 0) }, { "Llegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 14, 5, 0) }, { "Llegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 15, 5, 0) }, { "Llegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 16, 5, 0) }, { "Llegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 17, 0, 0) }, { "Llegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 18, 5, 0) }, { "Llegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 19, 5, 0) }, { "Llegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 20, 5, 0) }, { "Llegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 21, 5, 0) }, { "Llegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

        }

        private async void insertCartago()
        {
            var myPost = new ParseObject("Ruta")
            {
                { "Nombre", "Cartago" },
                { "Parada", "Costado de las ruinas de Cartago" }
            };

            // Create the comment
            var myComment = new ParseObject("Hora"){{ "Hora", new DateTime(2015,10,21, 7, 0,0) },{ "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

             myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 7, 10, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

             myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 7, 15, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

             myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 7, 20, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 7, 30, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 7, 40, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 7, 50, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 8, 00, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();


            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 9, 00, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 9, 15, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 10, 00, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 11, 00, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 11, 30, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 11, 40, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 12, 50, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 13, 00, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 13, 50, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 14, 30, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 15, 25, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 16, 10, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 16, 45, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 17, 00, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 17, 15, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 17, 30, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 17, 45, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 18, 00, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 18, 15, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 18, 30, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 18, 45, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 19, 15, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 19, 45, 0) }, { "LLegada", true }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 7, 20, 0) }, { "LLegada", true }, { "sabado", true } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 8, 0, 0) }, { "LLegada", true }, { "sabado", true } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 11, 45, 0) }, { "LLegada", true }, { "sabado", true } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 13, 30, 0) }, { "LLegada", true }, { "sabado", true } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync(); 


            ///SALIDA DEL TEC
            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 8, 30, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 9, 30, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 10, 30, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();


            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 11, 15, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 11, 30, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 12, 00, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 12, 10, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 12, 30, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 13, 10, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 14, 10, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 15, 10, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 15, 40, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 16, 00, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 16, 30, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 16, 40, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 17, 00, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 17, 15, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 17, 30, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 18, 00, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 18, 15, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 18, 30, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 18, 45, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 19, 00, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 19, 35, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 20, 00, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 20, 30, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 21, 00, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 21, 30, 0) }, { "LLegada", false }, { "sabado", false } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 12, 00, 0) }, { "LLegada", false }, { "sabado", true } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 12, 40, 0) }, { "LLegada", false }, { "sabado", true } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 16, 00, 0) }, { "LLegada", false }, { "sabado", true } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();

            myComment = new ParseObject("Hora") { { "Hora", new DateTime(2015, 10, 21, 17, 00, 0) }, { "LLegada", false }, { "sabado", true } };
            // Add a relation between the Post and Comment
            myComment["horarios"] = myPost;
            // This will save both myPost and myComment
            await myComment.SaveAsync();
        }

        private void btnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            splitView.IsPaneOpen = !splitView.IsPaneOpen;
        }

        private void stpHorario_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(ScheduleBus));
        }
    }
}
