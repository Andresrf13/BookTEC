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
        public OrientationTrigger()
        {                        
           // this.Orientation = ApplicationView.GetForCurrentView().Orientation;
           SetActive(ApplicationView.GetForCurrentView().Orientation.Equals(this.Orientation));
            System.Diagnostics.Debug.WriteLine(this.Orientation +" This");
            System.Diagnostics.Debug.WriteLine(ApplicationView.GetForCurrentView().Orientation);
            var rawpixelperview = Windows.Graphics.Display.DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
            System.Diagnostics.Debug.WriteLine(Window.Current.Bounds.Height * rawpixelperview + " Resolution hight");
            System.Diagnostics.Debug.WriteLine(Window.Current.Bounds.Width * rawpixelperview + " Resolution hight");
            Window.Current.SizeChanged += (s, e) =>
            {
                
                SetActive(ApplicationView.GetForCurrentView().Orientation.Equals(this.Orientation));
            };
            //SetActive(ApplicationView.GetForCurrentView().Orientation.Equals(this.Orientation));
        }

        public ApplicationViewOrientation Orientation { get; set; }
    }
}

