using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Task
    {
        private string TaskName;
        private int Priority;


        public Task(string taskName, int priority)
        {
            TaskName = taskName;
            Priority = priority;
        }

        public void DoTask()
        {
            Console.WriteLine($"Task {TaskName} with {Priority} is done");
        }
        public void UndoTask()
        {
            Console.WriteLine($"Undoing Task {TaskName} ....");
        }
    }
}
