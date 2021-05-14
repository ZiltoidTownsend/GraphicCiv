using GraphicCiv.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace GraphicCiv.Converters
{
    public class TypeToTypeValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            PolylineVM polyline = (PolylineVM)value;
            if (value != null)
                return CheckType(polyline.Type);
            else
                return "";



            throw new ArgumentException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new ArgumentException();
        }

        public string CheckType(string InType)
        {
            string answer = "";
            switch(InType)
            {
                case "Кампус":
                    answer = "Наука";
                    break;
                case "Центр коммерции":
                    answer = "Золото";
                    break;
                case "Промышленная зона":
                    answer = "Производство";
                    break;
                case "Театральная площадь":
                    answer = "Культура";
                    break;
                default:
                    break;
            }
            return answer;
        }
    }
}
