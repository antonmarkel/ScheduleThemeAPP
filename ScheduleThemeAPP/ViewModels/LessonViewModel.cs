using ScheduleThemeAPP.Models;
using ScheduleThemeAPP.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleThemeAPP.ViewModels
{
    public class LessonViewModel
    {
        private LessonModel _model { get; set; }
        public static OptionsModel Options { get; set; }
        public LessonViewModel(LessonModel model)
        {
            Options.UpdateOptions += Options_UpdateOptions;
            _model = model;
            CalculateCoors();
        }

        private void Options_UpdateOptions()
        {
            CalculateCoors();
        }

        public bool HasNotes => _model.hasNotes;

        public string TimeStart => _model.Start.ToString(@"hh\:mm");
        public string TimeFinish => _model.Finish.ToString(@"hh\:mm");
        public string ClassName => _model.ClassName;
        public string Room => _model.Room;
        public string Teacher => _model.Teacher;

        public DateTime Day => _model.Day;

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rect Bounds 
        { get{return new Rect(X, Y, Width, Height);}
            set { }
        }

        private void CalculateCoors()
        {
            

            int perfive =  Options.RowWidth / (int)Options.Interval.TotalMinutes * 5;

            Y = (int)(_model.Start.TotalMinutes - Options.TimeStart.TotalMinutes) / 5 * perfive + Options.RowWidth;
            Height = (int)(_model.Finish.TotalMinutes - _model.Start.TotalMinutes)/5 * perfive;

            X = 100 + (int)Day.DayOfWeek * 400;//320

            Width = 300;


        }


    }
}
