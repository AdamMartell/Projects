using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace WpfApplication5
{
    class DataRetriever
    {
        public List<DataPoint> RetrieveData(List<DateTime> listX, List<double> listY)
        {
            List<DataPoint> Points = new List<DataPoint> { };
            for (int x = 0; ((x < listX.Count) && (x < listY.Count)); x++)
            {
                Points.Add(new DataPoint(DateTimeAxis.ToDouble(listX[x]), listY[x]));
            } 
            return Points;
        }
    }
}
