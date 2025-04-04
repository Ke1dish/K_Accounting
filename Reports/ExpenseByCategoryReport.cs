using K_Accounting.Data;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using System.Windows.Forms;

namespace K_Accounting.Reports
{
    public class ExpenseByCategoryReport : ReportBase
    {
        public ExpenseByCategoryReport(AppDbContext context, DateTime startDate, DateTime endDate)
            : base(context, startDate, endDate) { }

        public override PlotModel CreatePlotModel()
        {
            var model = new PlotModel
            {
                Title = "Конверсия доходов в сбережения",
                Subtitle = "ПОКА НЕ РЕАЛИЗОВАННО",
                TitleFontSize = 14,
                DefaultFont = "Arial"
            };

            // Добавляем текстовую аннотацию
            model.Annotations.Add(new TextAnnotation
            {
                Text = "Функционал в разработке",
                TextPosition = new OxyPlot.DataPoint(0.5, 0.5),
                FontSize = 20,
                TextColor = OxyColors.Red,
                TextHorizontalAlignment = OxyPlot.HorizontalAlignment.Center,
                TextVerticalAlignment = OxyPlot.VerticalAlignment.Middle
            });

            // Добавляем пустые оси для корректного отображения
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0, Maximum = 1 });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = 0, Maximum = 1 });

            return model;
        }

        public override Control[] GetFilterControls() => new Control[0];

        public override void ApplyFilters(Dictionary<string, object> filters) { }

        public override Dictionary<string, object> GetFilterValues() => new Dictionary<string, object>();
    }
}