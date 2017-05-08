using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
//using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NorthwindWPF
{
    /// <summary>
    /// Interaction logic for Overview.xaml
    /// </summary>
    public partial class Overview : Window
    {

        public Overview()
        {
            InitializeComponent();
            NorthwindEntities db = new NorthwindEntities();
            var data = (from d in db.Sales_by_Categories group d by d.CategoryName into grouped select new { Key = grouped.Key, Sum = grouped.Sum(e => (double)e.ProductSales) });
            IEnumerable<Categorysales> datas = from c in data.AsEnumerable() select new Categorysales(c.Key, c.Sum);


            seriesCollection = new SeriesCollection();
            foreach (var item in datas)
            {
                seriesCollection.Add(new PieSeries { Title = item.Categoryname, Values = new ChartValues<ObservableValue> { new ObservableValue(item.Categorysum) }, DataLabels = true});//, LabelPoint = PointLabel 
            }
        }
        public SeriesCollection seriesCollection { get; set; }



        public Func<ChartPoint, string> PointLabel { get; set; }

        private void Chart_OnDataClick(object sender, ChartPoint chartpoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartpoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries)chartpoint.SeriesView;
            selectedSeries.PushOut = 8;
        }
    }
}