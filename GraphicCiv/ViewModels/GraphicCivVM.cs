using GraphicCiv.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicCiv.ViewModels
{
    public class GraphicCivVM : BaseInpc
    {
        private PolylineVM selectedPolyline;
        public PolylineVM SelectedPolyline { get => selectedPolyline; set => Set(ref selectedPolyline, value); }
        public PolylinesVM dataPolylines = new PolylinesVM();
        public PolylinesVM DataPolylines { get => dataPolylines; set => Set(ref dataPolylines, value); }

        private ObservableCollection<string> types = new ObservableCollection<string> { "Кампус", "Центр коммерции", 
            "Правительственная площадь", "Промышленная зона", "Театральная площадь", "Акведук", "Священное место", "" };
        public ObservableCollection<string> Types
        { get => types; set => Set(ref types, value); }

    }
}
