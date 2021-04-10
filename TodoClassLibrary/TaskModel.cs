using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoClassLibrary
{
    public abstract class TaskModel
    {        
        public string AlarmTone { get; set; }
        public bool IsDone { get; set; }
        public bool IsGoingToAlarm { get; set; }
        public string TimeReminder { get; set; }
        public string Title { get; set; }
        public bool IsReminded { get; set; }

        public string TaskDisplay
        {
            get
            {
                string display = "";
                if (IsReminded == true) display = $"{Title} At {TimeReminder} - (REMINDED)";
                else if (IsDone == true) display = $"{Title} At {TimeReminder} - (DONE)";
                else { display = $"{Title} At {TimeReminder}"; }
                return display;
            }
        }
        
        public abstract bool CheckTask(out string ActiveTask);

    }
}
