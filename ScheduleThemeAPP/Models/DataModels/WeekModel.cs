using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleThemeAPP.Models.DataModels
{
    public class WeekModel
    {
        List<DayModel> Days { get; set;}
        DateTime WeekStart { get; set;}
        DateTime WeekEnd { get; set;}

        //bool isUnderLined { get; set; }
    }
}
