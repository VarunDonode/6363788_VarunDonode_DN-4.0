using System;

namespace w5__task_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();

            manager.AddTask(1, "Design UI", "Pending");
            manager.AddTask(2, "Fix bugs", "In Progress");
            manager.AddTask(3, "Deploy app", "Pending");

            Console.WriteLine("\nAll Tasks:");
            manager.TraverseTasks();

            Console.WriteLine("\nSearching for Task ID 2:");
            var task = manager.SearchTask(2);
            if (task != null)
                Console.WriteLine($"Found: {task.TaskName}, Status: {task.Status}");
            else
                Console.WriteLine("Task not found.");

            Console.WriteLine("\nDeleting Task ID 1:");
            manager.DeleteTask(1);

            Console.WriteLine("\nTasks after deletion:");
            manager.TraverseTasks();
        }
    }
}
