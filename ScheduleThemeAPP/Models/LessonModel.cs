using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleThemeAPP.Models
{
    public class LessonModel
    {
        public Guid Id { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan Finish { get; set; }

        public DateTime Day { get; set; } 

        public string ClassName { get; set; }
        public string Teacher { get; set; }
        public string Room { get;set; }

        #region UserData
        public bool hasNotes { get; set; } = false;
        //public NoteModel Note { get; set; } = null;
        public Color Background { get; set; } // = default color;
        #endregion
    }
}
