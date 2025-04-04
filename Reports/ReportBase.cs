using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using K_Accounting.Data;
using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Series; 
using OxyPlot.Axes;    
using SQLitePCL;

namespace K_Accounting.Reports
{
    public abstract class ReportBase
    {
        protected AppDbContext _context;
        protected DateTime _startDate;
        protected DateTime _endDate;
        protected Dictionary<string, object> _currentFilters = new Dictionary<string, object>();

        //public event EventHandler OnFilterChanged;
        public virtual Dictionary<string, object> GetFilterValues() => _currentFilters;
        public abstract PlotModel CreatePlotModel();
        public abstract Control[] GetFilterControls();
        public virtual void ApplyDefaults() { }

        public ReportBase(AppDbContext context, DateTime startDate, DateTime endDate)
        {
            _context = context;
            _startDate = startDate;
            _endDate = endDate;
        }

        public virtual void ApplyFilters(Dictionary<string, object> filters)
        {
            _currentFilters = filters ?? new Dictionary<string, object>();
        }

        public virtual void UpdatePeriod(DateTime start, DateTime end)
        {
            _startDate = start;
            _endDate = end;
        }

        public event EventHandler FilterChanged;

        protected virtual void OnFilterChanged(EventArgs e)
        {
            FilterChanged?.Invoke(this, e);
        }
    }
}
