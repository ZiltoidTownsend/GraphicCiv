using GraphicCiv.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GraphicCiv
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<PolygonHex> Polygons { get; set; } = new List<PolygonHex>
        {
             new PolygonHex {StartPoint = new Point(450, 50)},
            new PolygonHex {StartPoint = new Point(250, 50) },
            new PolygonHex {StartPoint = new Point(350, 200) },


        };

        public MainWindow()
        {
            InitializeComponent();
            
            //PolygonHex polygon = new PolygonHex();
            //polygon.Points = new PointCollection (new[] { new Point(200, 100), new Point(400, 100), new Point(400, 300), new Point(200, 400), new Point(0, 300), new Point(0, 100) });
            //PolygonHex polygonTwo = new PolygonHex();
            //polygonTwo.Points = new PointCollection(new[] { new Point(125, 8), new Point(223, 19), new Point(65, 78) });

            //List<PolygonHex> Polygons = new List<PolygonHex>();
            //Polygons.Add(polygon);
            //Polygons.Add(polygonTwo);

            //DataContext = Polygons;

        }
    }
}
