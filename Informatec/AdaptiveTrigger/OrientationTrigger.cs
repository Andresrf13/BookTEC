using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;

namespace Informatec.AdaptiveTrigger
{
    class OrientationTrigger : StateTriggerBase
    {
        private double _minHeight, _minWidth = -1;
     
        private double _currentHeight, _currentWidth;

        private ApplicationViewOrientation _orientation = ApplicationView.GetForCurrentView().Orientation;
        private ApplicationViewOrientation _currentOrientation;

        public double MinHeight { get { return _minHeight; } set { _minHeight = value; } }
        public double MinWidth { get { return _minWidth; } set { _minWidth = value; } }

        public ApplicationViewOrientation Orientation { get { return _orientation; } set { _orientation = value; } }

        public OrientationTrigger()
        {          
            if (Window.Current != null)
            {
                Window.Current.SizeChanged -= Current_SizeChanged;
            }            
            Window.Current.SizeChanged += Current_SizeChanged;
            
        }

       
       

        private void Current_SizeChanged(object sender, Windows.UI.Core.WindowSizeChangedEventArgs e)
        {
            _currentHeight = e.Size.Height;
            _currentWidth = e.Size.Width;
            _currentOrientation = ApplicationView.GetForCurrentView().Orientation;
            UpdateTrigger();
        }

     

        private void UpdateTrigger()
        {
            if (Window.Current != null && (_minWidth>=0 || _minHeight >= 0) )
            {
                if( _minHeight >= 0 && _minWidth >= 0)
                {
                    SetActive((_currentHeight >= _minHeight) && (_currentWidth >= _minWidth) && (_currentOrientation.Equals(_orientation)));
                }
                else if(_minHeight >= 0)
                {
                    SetActive(_currentHeight >= _minHeight && (_currentOrientation.Equals(_orientation)));
                }
                else
                {
                    SetActive(_currentWidth >= _minWidth && (_currentOrientation.Equals(_orientation)));
                }
            }
            else
            {
                SetActive(false);
            }
        }

        /*
        public ApplicationViewOrientation Orientation { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public string Name { get; set; }

        public OrientationTrigger()
          {          
            var rawpixelperviewInitial = Windows.Graphics.Display.DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
            double widthInitial = Window.Current.Bounds.Width * rawpixelperviewInitial;
            double heightInitial = Window.Current.Bounds.Height * rawpixelperviewInitial;           
            if (ApplicationView.GetForCurrentView().Orientation.Equals(this.Orientation) && widthInitial >= Width && heightInitial >= Height)
            {
                System.Diagnostics.Debug.WriteLine("entro");
                  this.SetActive(ApplicationView.GetForCurrentView().Orientation.Equals(this.Orientation));
            }

            Window.Current.SizeChanged += (s, e) =>
              {
                  double rawpixelperview = Windows.Graphics.Display.DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
                  double width = e.Size.Width;
                  double height = e.Size.Height;
               
                  System.Diagnostics.Debug.WriteLine("Windows-Orientation"+ ApplicationView.GetForCurrentView().Orientation + " - MediaOrientation: " + this.Orientation);
                 
                  if (Windows.Graphics.Display.DisplayInformation.GetForCurrentView().CurrentOrientation.Equals(this.Orientation) && width >= Width && height >= Height)
                  {
                      System.Diagnostics.Debug.WriteLine("Entro");
                      this.SetActive(Windows.Graphics.Display.DisplayInformation.GetForCurrentView().CurrentOrientation.Equals(this.Orientation));
                  }               
              };              
          } */


        /*  public int Width
          {
              get { return (int)GetValue(WidthProperty); }
              set { SetValue(WidthProperty, value); }
          }

          // Using a DependencyProperty as the backing store for Width.  This enables animation, styling, binding, etc...
          public static readonly DependencyProperty WidthProperty =
              DependencyProperty.Register("Width", typeof(int), typeof(OrientationTrigger), new PropertyMetadata(0, WidthChange));

          private static void WidthChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
          {
              OrientationTrigger obj = (OrientationTrigger)d;
              var rawpixelperview = Windows.Graphics.Display.DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
              double width = Window.Current.Bounds.Width * rawpixelperview;
              double height = Window.Current.Bounds.Width * rawpixelperview;
              System.Diagnostics.Debug.WriteLine("Window-Width:" + width + " - MediaWidth:" + e.NewValue);
              System.Diagnostics.Debug.WriteLine("Window-Height:" + height + " - MediaHeight:" + obj.Height);
              System.Diagnostics.Debug.WriteLine("Windows-Orientation" + ApplicationView.GetForCurrentView().Orientation + " - MediaOrientation: " + obj.Orientation);
              if (ApplicationView.GetForCurrentView().Orientation.Equals(obj.Orientation) && width <= (double)e.NewValue && height <= obj.Height)
              {
                  obj.SetActive(true);
              }
          }


          public int Height
          {
              get { return (int)GetValue(HeightProperty); }
              set { SetValue(HeightProperty, value); }
          }

          // Using a DependencyProperty as the backing store for Height.  This enables animation, styling, binding, etc...
          public static readonly DependencyProperty HeightProperty =
              DependencyProperty.Register("Height", typeof(int), typeof(OrientationTrigger), new PropertyMetadata(0, HeightChange));


          private static void HeightChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
          {
              OrientationTrigger obj = (OrientationTrigger)d;
              var rawpixelperview = Windows.Graphics.Display.DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
              double width = Window.Current.Bounds.Width * rawpixelperview;
              double height = Window.Current.Bounds.Width * rawpixelperview;
              System.Diagnostics.Debug.WriteLine("Window-Width:" + width + " - MediaWidth:" + obj.Width);
              System.Diagnostics.Debug.WriteLine("Window-Height:" + height + " - MediaHeight:" + e.NewValue);
              System.Diagnostics.Debug.WriteLine("Windows-Orientation" + ApplicationView.GetForCurrentView().Orientation + " - MediaOrientation: " + obj.Orientation);
              if (ApplicationView.GetForCurrentView().Orientation.Equals(obj.Orientation) && width <= obj.Width && height <= (double)e.NewValue)
              {
                  obj.SetActive(true);
              }
          }

          public ApplicationViewOrientation Orientation
          {
              get { return (ApplicationViewOrientation)GetValue(OrientationProperty); }
              set { SetValue(OrientationProperty, value); }
          }

          // Using a DependencyProperty as the backing store for Orientation.  This enables animation, styling, binding, etc...
          public static readonly DependencyProperty OrientationProperty =
              DependencyProperty.Register("Orientation", typeof(ApplicationViewOrientation), typeof(OrientationTrigger), new PropertyMetadata(ApplicationViewOrientation.Portrait, OrientationChange));

          private static void OrientationChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
          {
              OrientationTrigger obj = (OrientationTrigger)d;
              var rawpixelperview = Windows.Graphics.Display.DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
              double width = Window.Current.Bounds.Width * rawpixelperview;
              double height = Window.Current.Bounds.Width * rawpixelperview;
              System.Diagnostics.Debug.WriteLine("Window-Width:" + width + " - MediaWidth:" + obj.Width);
              System.Diagnostics.Debug.WriteLine("Window-Height:" + height + " - MediaHeight:" + obj.Height);
              System.Diagnostics.Debug.WriteLine("Windows-Orientation" + ApplicationView.GetForCurrentView().Orientation + " - MediaOrientation: " + e.NewValue);
              if (ApplicationView.GetForCurrentView().Orientation.Equals(e.NewValue) && width <= obj.Width && height <= obj.Height)
              {
                  obj.SetActive(true);
              }
          } */
    }
}

