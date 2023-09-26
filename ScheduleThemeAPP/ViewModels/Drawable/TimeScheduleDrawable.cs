using ScheduleThemeAPP.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleThemeAPP.ViewModels.Drawable
{
    public class TimeScheduleDrawable : IDrawable
    {
        private OptionsModel options { get; set; }
        private int Lines { get; set; }

        public TimeScheduleDrawable(OptionsModel options)
        {
            this.options = options;
            Lines = options.CalculatelinesRequired();
        }



        void IDrawable.Draw(ICanvas canvas, RectF dirtyRect)
        {
            //canvas.FillColor = options.Background;
    
            TimeSpan time = options.TimeStart;
            for (int i = 1; i <= Lines; i++)
            {
                canvas.FontSize = 20;
                canvas.FontColor = Colors.Black;

                canvas.DrawString(time.ToString(@"hh\:mm"), 5, i * options.RowWidth + 5, HorizontalAlignment.Left);

                time = time.Add(options.Interval);
            }

        }
    }
}
