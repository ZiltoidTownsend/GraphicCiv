using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GraphicCiv.Classes
{
    public class PolylineData
    {
        public double Top { get; set; }
        public double Left { get; set; }
        public PointCollection Points { get; set; }
        public List<PolylineData> NeighPolylines { get; set; }



    }
}
