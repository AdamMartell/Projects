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

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //int highestPrice = 65;
            //List<int> vals = new List<int>() { 10, 20, 30, 40, 50 };
            //int min = vals.Min();
            //int max = vals.Max();
            //max = highestPrice > max ? highestPrice : max;
            //double range = max - min;
            Color d = new Color() { ScA = 1, ScR = .5F, ScG = .5F, ScB = .5F };
            var line = new Line() { X1 = 0, Y1 = 0, X2 = canvas.Width, Y2 = 0, Stroke = new SolidColorBrush(d), StrokeThickness = 2.0 };
            line = new Line() { X1 = 0, Y1 = 0, X2 = canvas.Width, Y2 = 10, Stroke = new SolidColorBrush(d), StrokeThickness = 1.0 };
            canvas.Children.Add(line);
            line = new Line() { X1 = canvas.Width, Y1 = 10, X2 = 0, Y2 = 20, Stroke = new SolidColorBrush(d), StrokeThickness = 1.0 };
            canvas.Children.Add(line);

            //foreach (int val in vals)
            //{
            //    double percent = 1.0 - ((val - min) / range); // 0 is at the top, so invert it by doing 1.0 - xxx
            //    double y = percent * canvas.Height;
            //    // Draw line in a shade of blue/green
            //    c = new Color() { ScA = 1, ScR = 0, ScG = 0.5f, ScB = (float)percent };
            //    line = new Line() { X1 = 0, Y1 = y, X2 = canvas.Width, Y2 = y, Stroke = new SolidColorBrush(c), StrokeThickness = 2.0 };
            //    canvas.Children.Add(line);
            //}
        }
        public void test()
        {
            GridLines test1 = new GridLines();
            test1.GenerateXGridLines();
        }
    }
}
