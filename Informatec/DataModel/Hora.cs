using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Informatec.DataModel
{
    class Hora
    {
        public DateTime hora { get; set; }

        public string horaformat { get; set; }

        public string tiempo { get; set; }

        public bool llegada { get; set; }
        public bool sabado { get; set; }

        public Visibility visibility { get; set; }
    }
}
