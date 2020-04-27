using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkSQLBackupWindowsApp
{
    class SparkTaskScheduler
    {
        public void AddTask(DateTime startDateTime, short daysInterval)
        {
            using (TaskService ts = new TaskService())
            {
                // Create a new task definition and assign properties
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "SQLBackup Task";

                // Create a trigger that will fire the task at this time every other day
                td.Triggers.Add(new DailyTrigger { DaysInterval = daysInterval, StartBoundary = startDateTime});

                // Create an action that will launch Notepad whenever the trigger fires
                td.Actions.Add(new ExecAction(System.IO.Directory.GetCurrentDirectory() + "\\SparkSQLbackup.exe"));

                // Register the task in the root folder
                ts.RootFolder.RegisterTaskDefinition(@"SQLBackupTest", td);

                // Remove the task we just created
               // ts.RootFolder.DeleteTask("Test");
            }
        }
        public void AddTaskOnce(DateTime startDateTime)
        {
            using (TaskService ts = new TaskService())
            {
                // Create a new task definition and assign properties
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "SQLBackup Task";

                // Create a trigger that will fire the task at this time every other day
                td.Triggers.Add(new DailyTrigger {StartBoundary = startDateTime });

                // Create an action that will launch Notepad whenever the trigger fires
                td.Actions.Add(new ExecAction(System.IO.Directory.GetCurrentDirectory() + "\\SparkSQLbackup.exe"));

                // Register the task in the root folder
                ts.RootFolder.RegisterTaskDefinition(@"SQLBackupTest", td);

                // Remove the task we just created
                // ts.RootFolder.DeleteTask("Test");
            }
        }
    }
    
}
