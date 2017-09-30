using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using slnMVCCharts.Context;
using System.Collections;
using System.Web.Helpers;

namespace slnMVCCharts.Controllers
{
    public class MVC_ChartsController : Controller
    {
        // Creating a Chart from Data in MVC, Chart Helper in MVC,
        //

        // GET: /MVC-Charts/
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult CharterColumn()
        {
            var _context = new TestEntities();

            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from c in _context.tblMVCCharts select c);

            results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
            results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Vanilla3D)
            .AddTitle("Chart for Growth [Column Chart]")
                  .AddSeries("Default", chartType: "column", xValue: xValue, yValues: yValue)
                  .Write("bmp");

            return null;
        }
        public ActionResult ChartBar()
        {
            var _context = new TestEntities();

            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from c in _context.tblMVCCharts select c);

            results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
            results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Vanilla3D)
            .AddTitle("Chart for Growth [Bar Chart]")
                  .AddSeries("Default", chartType: "Bar", xValue: xValue, yValues: yValue)
                  .Write("bmp");

            return null;
        }
        public ActionResult ChartPie()
        {
            var _context = new TestEntities();

            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from c in _context.tblMVCCharts select c);

            results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
            results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Vanilla3D)
            .AddTitle("Chart for Growth [Pie Chart]")
                  .AddLegend("Summary")
                  .AddSeries("Default", chartType: "Pie", xValue: xValue, yValues: yValue)
                  .Write("bmp");

            return null;
        }
        public ActionResult ChartThreelinebreak()
        {
            var _context = new TestEntities();

            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from c in _context.tblMVCCharts select c);

            results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
            results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

            /// SeriesChartType.Candlestick
            new Chart(width: 600, height: 400, theme: ChartTheme.Vanilla3D)
            .AddTitle("Chart for Growth [Three Line Break Chart]")
                  .AddSeries("Default", chartType: "Candlestick", xValue: xValue, yValues: yValue)
                  .Write("bmp");

            return null;
        }
        public ActionResult Bubblebreak()
        {
            var _context = new TestEntities();

            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from c in _context.tblMVCCharts select c);

            results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
            results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)

            /// SeriesChartType.Bubble
            .AddTitle("Chart for Growth [Bubble Chart]")
                  .AddLegend("Summary")
                  .AddSeries("Default", chartType: "Bubble", xValue: xValue, yValues: yValue)
                  .Write("bmp");

            return null;
        }
        public ActionResult DoughnutGraph()
        {
            var _context = new TestEntities();

            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from c in _context.tblMVCCharts select c);

            results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
            results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)

            /// SeriesChartType.Doughnut
            .AddTitle("Chart for Growth [Doughnut Chart]")
                    .AddLegend("Summary")
                  .AddSeries("Default", chartType: "Doughnut", xValue: xValue, yValues: yValue)
                  .Write("bmp");

            return null;
        }
        public ActionResult ChartStackedBar100()
        {
            var _context = new TestEntities();

            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from c in _context.tblMVCCharts select c);

            results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
            results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)

            /// SeriesChartType.StackedBar100
            .AddTitle("Chart for Growth [StackedBar100 Chart]")
                  .AddSeries("Default", chartType: "StackedBar100", xValue: xValue, yValues: yValue)
                  .Write("bmp");

            return null;
        }
        public ActionResult ChartBoxPlot()
        {
            var _context = new TestEntities();

            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from c in _context.tblMVCCharts select c);

            results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
            results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)

            /// SeriesChartType.BoxPlot
            .AddTitle("Chart for Growth [BoxPlot Chart]")
                  .AddSeries("Default", chartType: "BoxPlot", xValue: xValue, yValues: yValue)
                  .Write("bmp");

            return null;
        }
        public ActionResult ChartPyramid()
        {
            var _context = new TestEntities();

            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from c in _context.tblMVCCharts select c);

            results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
            results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)

            /// SeriesChartType.Pyramid
            .AddTitle("Chart for Growth [Pyramid Chart]")
                  .AddLegend("Summary")
                  .AddSeries("Default", chartType: "Pyramid", xValue: xValue, yValues: yValue)
                  .Write("bmp");

            return null;
        }
        public ActionResult ChartPolar()
        {
            var _context = new TestEntities();

            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from c in _context.tblMVCCharts select c);

            results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
            results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)

            /// SeriesChartType.Polar
            .AddTitle("Chart for Growth [Polar Chart]")
                  .AddSeries("Default", chartType: "Polar", xValue: xValue, yValues: yValue)
                  .Write("bmp");

            return null;
        }
        public ActionResult RadarChart()
        {
            var _context = new TestEntities();

            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from c in _context.tblMVCCharts select c);

            results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
            results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)

            /// SeriesChartType.Radar
            .AddTitle("Chart for Growth [Radar Chart]")
                  .AddSeries("Default", chartType: "Radar", xValue: xValue, yValues: yValue)
                  .Write("bmp");

            return null;
        }
        public ActionResult ChartRangeBar()
        {
            var _context = new TestEntities();

            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from c in _context.tblMVCCharts select c);

            results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
            results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
            
            /// SeriesChartType.RangeBar
            .AddTitle("Chart for Growth [RangeBar Chart]")
                  .AddSeries("Default", chartType: "RangeBar", xValue: xValue, yValues: yValue)
                  .Write("bmp");

            return null;
        }
        public ActionResult ChartFunnel()
        {
            var _context = new TestEntities();

            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from c in _context.tblMVCCharts select c);

            results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
            results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)

            /// SeriesChartType.Funnel
            .AddTitle("Chart for Growth [Funnel Chart]")
            .AddLegend("Summary")
                  .AddSeries("Default", chartType: "Funnel", xValue: xValue, yValues: yValue)
                  .Write("bmp");

            return null;
        }
        ///
    }
}
