using GraphicCiv.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GraphicCiv.ViewModels
{
    public class PolylineVM : BaseInpc
    {
        private PolylineData polyline;


        public PolylineVM(PolylineData p, string type, string value)
        {
            polyline = p;
            this.type = type;
            typeValue = value;
        }

        public double Top
        {
            get { return polyline.Top; }
            set
            {
                polyline.Top = value;
            }
        }

        public double Left
        {
            get { return polyline.Left; }
            set
            {
                polyline.Left = value;
            }
        }

        public PointCollection Points
        {
            get { return polyline.Points; }
            set
            {
                polyline.Points = value;
            }
        }

        public PolylineData Polyline { get => polyline; set => Set(ref polyline, value); }

        private string typeValue;
        public string TypeValue { get => typeValue; set => Set(ref typeValue, value); }

        private string type;
        public string Type { get => type; set => Set(ref type, value); }
    }
}
