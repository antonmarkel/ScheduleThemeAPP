using ScheduleThemeAPP.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleThemeAPP.ViewModels.Drawable
{
    public class TimeLinesDrawable : IDrawable
    {
        private OptionsModel options { get; set; }
        private int Lines { get; set; }

        public TimeLinesDrawable(OptionsModel options)
        {
            this.options = options;
            Lines = options.CalculatelinesRequired();
        }



        void IDrawable.Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.FillColor = options.Background;
            canvas.FillRectangle(dirtyRect);
            canvas.StrokeColor = options.Stroke;
            canvas.StrokeSize = 1;
            TimeSpan time = options.TimeStart;
            for (int i = 1; i <= Lines; i++)
            {
                canvas.DrawLine(0, i * options.RowWidth, dirtyRect.Width, i * options.RowWidth);

                time = time.Add(options.Interval);
            }
            canvas.StrokeColor = Color.FromArgb("#222");
            for (int i = 0; i < 7; i++)
            {
                for(int y = 0; y < dirtyRect.Height - 10;y += 12)
                    canvas.DrawLine(450 + i*400, y, 450 + i * 400, y+10);
            }

        }
    }
}
