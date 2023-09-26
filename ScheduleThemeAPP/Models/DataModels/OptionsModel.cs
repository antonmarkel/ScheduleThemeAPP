using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleThemeAPP.Models.DataModels
{
   
    public class OptionsModel
    {
        private OptionsModel() { }
        private static OptionsModel instance { get; set; } = null;

        public delegate void UpdateOptionsDelegate();
        public event UpdateOptionsDelegate UpdateOptions;

        public static OptionsModel GetInstance()
        {
            if (instance == null) { return instance = new OptionsModel(); }
            else return instance;
        }
        public TimeSpan Interval { get; set; } = TimeSpan.FromMinutes(15);
        public Color Background { get; set; } = Colors.Wheat;
        public Color Stroke { get; set; } = Color.FromRgba("#DAA");

        public TimeSpan TimeStart { get; set; } = new TimeSpan(8, 0, 0);
        public TimeSpan TimeEnd { get; set; } = new TimeSpan(20, 0, 0);

        public int RowWidth { get; set; } = 30  ;

        public int CalculatelinesRequired()
        {
            double totalMinutes = TimeEnd.TotalMinutes - TimeStart.TotalMinutes;
            return (int)(totalMinutes / Interval.TotalMinutes) + 1;
        }
        public int CalculateSpaceRequired()
        {
            return (CalculatelinesRequired() + 2) * RowWidth;
        }
    }
}
