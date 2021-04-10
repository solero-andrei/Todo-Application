using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoClassLibrary
{
    public class TaskProcessor : TaskModel
    {
        public static List<TaskModel> TaskList { get; set; } = new List<TaskModel>();
        AudioAlarm player;
        public TaskProcessor()
        {
            player = new AudioAlarm();
        } 

        /// <summary>
        /// Method that will check all the active tasks
        /// </summary>
        /// <param name="ActiveTask">Returns the Title task that is active</param>
        /// <returns>Task Title</returns>
        public override bool CheckTask(out string ActiveTask)
        {
            bool IsActive = false;
            string activeTask = "";
            DateTime currentTime = Convert.ToDateTime(string.Format("{0:hh:mm tt}", DateTime.Now));
            foreach (var task in TaskList)
            {
                if (Convert.ToDateTime(task.TimeReminder) == currentTime && task.IsReminded == false && task.IsDone == false)
                {
                    if(task.IsGoingToAlarm == true) player.Play(task.AlarmTone);
                    task.IsReminded = true;
                    IsActive = true;
                    activeTask = task.Title;
                }
            }
            ActiveTask = activeTask;
            return IsActive;
        }

    }
}
