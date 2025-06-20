using System;

namespace w5__task_management
{
    public class TaskManager
    {
        private TaskNode head;

        public void AddTask(int id, string name, string status)
        {
            TaskNode newNode = new TaskNode
            {
                TaskId = id,
                TaskName = name,
                Status = status,
                Next = null
            };

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                TaskNode current = head;
                while (current.Next != null)
                    current = current.Next;

                current.Next = newNode;
            }

            Console.WriteLine("Task added successfully.");
        }

        public void TraverseTasks()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            TaskNode current = head;
            while (current != null)
            {
                Console.WriteLine($"ID: {current.TaskId}, Name: {current.TaskName}, Status: {current.Status}");
                current = current.Next;
            }
        }

        public TaskNode SearchTask(int id)
        {
            TaskNode current = head;
            while (current != null)
            {
                if (current.TaskId == id)
                    return current;

                current = current.Next;
            }

            return null;
        }

        public void DeleteTask(int id)
        {
            if (head == null)
            {
                Console.WriteLine("Task list is empty.");
                return;
            }

            if (head.TaskId == id)
            {
                head = head.Next;
                Console.WriteLine("Task deleted successfully.");
                return;
            }

            TaskNode current = head;
            TaskNode prev = null;

            while (current != null && current.TaskId != id)
            {
                prev = current;
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine("Task not found.");
                return;
            }

            prev.Next = current.Next;
            Console.WriteLine("Task deleted successfully.");
        }
    }
}
