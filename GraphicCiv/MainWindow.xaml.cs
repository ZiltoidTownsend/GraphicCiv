using GraphicCiv.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

        //public ObservableCollection<CircleData> SelectedCircles = new ObservableCollection<CircleData>();


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


        }
    }
}
