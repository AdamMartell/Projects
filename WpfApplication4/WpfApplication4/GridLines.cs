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

namespace WpfApplication4
{
    class GridLines
    {
        public void GenerateXGridLines(Canvas canvas)
        {
            Color d = new Color() { ScA = 1, ScR = .5F, ScG = .5F, ScB = .5F };
            var line = new Line() { X1 = 0, Y1 = 0, X2 = canvas.Width, Y2 = 0, Stroke = new SolidColorBrush(d), StrokeThickness = 2.0 };

            for (int x = 0; x < canvas.Width; x += 10)
            {
                line = new Line() { X1 = x, Y1 = 0, X2 = x, Y2 = canvas.Height, Stroke = new SolidColorBrush(d), StrokeThickness = 1.0 };
                canvas.Children.Add(line);
            }
        }
        public void GenerateYGridLines(Canvas canvas)
        {
            Color d = new Color() { ScA = 1, ScR = .5F, ScG = .5F, ScB = .5F };
            var line = new Line() { X1 = 0, Y1 = 0, X2 = canvas.Width, Y2 = 0, Stroke = new SolidColorBrush(d), StrokeThickness = 2.0 };
            for (int x = 0; x < canvas.Width; x += 10)
            {
                line = new Line() { X1 = 0 , Y1 = x, X2 = canvas.Width, Y2 = x, Stroke = new SolidColorBrush(d), StrokeThickness = 1.0 };
                canvas.Children.Add(line);
            }
        }
    }
}
