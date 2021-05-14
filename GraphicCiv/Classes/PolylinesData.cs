using GraphicCiv.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace GraphicCiv.Classes
{
    public class PolylinesData
    {
        PointCollection PointsCenter = new PointCollection { new Point(0, 0), new Point(100, 150), new Point(200, 0), new Point(100, -150), new Point(-100, -150), new Point(-200, 0), new Point(-100, 150) };
        PointCollection PointsFigure = new PointCollection { new Point(0, 100), new Point(100, 50), new Point(100, -50), new Point(0, -100), new Point(-100, -50), new Point(-100, 50) };


        public List<PolylineData> Polylines { get; } = new List<PolylineData>();

        public PolylinesData()
        {
            double TopData = 400;
            double LeftData = 500;

            //Polylines.Add(new PolylineData() { Top = TopData, Left = LeftData, Points = PointsFigure });

            foreach (var pointS in PointsCenter)
            {
                Polylines.Add(new PolylineData() { Top = TopData + pointS.Y, Left = LeftData + pointS.X, Points = PointsFigure, NeighPolylines = new List<PolylineData>()});
            }

            foreach (var Polyline in Polylines)
            {
                foreach (var Point in Polyline.Points)
                {
                    foreach (var Poly in Polylines)
                    {
                        foreach (var Points in Poly.Points)
                        {
                            if (Polyline != Poly && Points.X + Polyline.Left == Point.X + Poly.Left && Point.Y + Polyline.Top == Points.Y + Poly.Top && !Polyline.NeighPolylines.Contains(Poly))
                                Polyline.NeighPolylines.Add(Poly);
                        }
                    }
                }
            }


        }

    }
}
