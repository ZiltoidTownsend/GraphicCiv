using GraphicCiv.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicCiv.ViewModels
{
    public class PolylinesVM : BaseInpc
    {
        public PolylinesData polylinesData { get; } = new PolylinesData();
        public ObservableCollection<PolylineVM> Polylines { get; } = new ObservableCollection<PolylineVM>();


        public PolylinesVM()
        {

            foreach (PolylineData itemPolyline in polylinesData.Polylines)
            {
                Polylines.Add(new PolylineVM(itemPolyline, "", ""));
            }

        }
     
    }
}
