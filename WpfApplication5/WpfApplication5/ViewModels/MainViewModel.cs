using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace WpfApplication5.ViewModels
{
    public class MainViewModel
    {
        List<DateTime> listX;
        List<double> listY;
        List<DateTime> listZ;
        List<double> listW;
        DataRetriever test;
        public MainViewModel()
        {

            //listX = new List<double> { 7, 9, 10.5, 9.5, 13, 11.5, 14, 14, 9, 7.5, 9.5, 7.5, 9, 7.5, 7.5, 7 };
            //listY = new List<double> { -12, -9.5, -7.5, -5.5, -3.5, -1.5, 0.5, 8, 2, -1, -3.5, -5, -7, -7.5, -10, -12 };
            //listZ = new List<double> { 7.5, 7.5, 7, 6, 5, 6, 6.5, 7, 7, 6.5, 6, 5, 4.5, 8, 5, 8, 13, 11, 7, 3, 1, -1, -3, -5, -7, -11, -13.5, -11.5, -10, -6, -7.5, -10, -7.5, -8, -8.5, -8.5, -8, -7.5, -6, -7.5, -8, -8.5, -8.5, -7.5, -7, -6, -5, -3.5, -5, -5.5, -5, -4, -2.5, 0 };
            //listW = new List<double> { -7.5, -5, -3, -1.5, -2.5, -1.5, -1, 0, 1, 3, 4, 5.5, 7, 6.5, 5.5, 6.5, 9.5, 10, 9.5, 8.5, 9, 9, 8.5, 8, 10, 12, 13, 10, 8, 7, 5.5, 8, 5.5, 3, 1, -1, -2, -2.5, -3, -2.5, -5, -8, -10, -12, -13, -14, -14.5, -14.5, -14.5, -16, -16.5, -17, -14.5, -14};
            listX = new List<DateTime> { new DateTime(2015, 1, 1), new DateTime(2015, 2, 1), new DateTime(2015, 3, 1), new DateTime(2015, 4, 1), new DateTime(2015, 5, 1), new DateTime(2015, 6, 1) };
            listY = new List<double> { 0, 2000, 3000, 10000, 6000 };
            listZ = new List<DateTime> { new DateTime(2015, 1, 1), new DateTime(2015, 2, 1), new DateTime(2015, 3, 1), new DateTime(2015, 4, 1), new DateTime(2015, 5, 1), new DateTime(2015, 6, 1) };
            listW = new List<double> { 0, 3000, 3125, 9005, 10000 };
            test = new DataRetriever();
            this.Title = "Example 2";
            this.Points = test.RetrieveData(listX, listY);
            this.Points2 = test.RetrieveData(listZ, listW);
//var xAxis = new DateTimeAxis
//{
//    Position = AxisPosition.Bottom,
//    StringFormat = "dd/MM/yyyy",
//    Title = "End of Day",
//    IntervalLength = 75,
//    MinorIntervalType = DateTimeIntervalType.Days,
//    IntervalType = DateTimeIntervalType.Days,
//    MajorGridlineStyle = LineStyle.Solid,
//    MinorGridlineStyle = LineStyle.None,
//};

//Plot = new PlotModel();
//Plot.Axes.Add(xAxis);

        }
        public string Title { get; private set; }

        public IList<DataPoint> Points { get; private set; }
        public IList<DataPoint> Points2 { get; private set; }
    }
}
