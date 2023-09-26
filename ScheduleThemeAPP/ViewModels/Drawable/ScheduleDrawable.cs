using Microsoft.Maui.Graphics;
using ScheduleThemeAPP.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ScheduleThemeAPP.Models.Drawable
{
    public class ScheduleDrawable : IDrawable
    {
        private OptionsModel options { get; set; } 
        private int Lines { get; set; }

        public ScheduleDrawable(OptionsModel options) {
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
            for (int i = 1;i <= Lines;i++)
            {
                canvas.FontSize = 20;
                canvas.FontColor = Colors.Black;

                canvas.DrawString(time.ToString(@"hh\:mm"),5,i*options.RowWidth + 5,HorizontalAlignment.Left);
                canvas.DrawLine(60, i * options.RowWidth, dirtyRect.Width, i * options.RowWidth);

                time = time.Add(options.Interval);  
            }
            
        }
    }
}
