namespace Collection
{
    class Program
    {
        static void Main()
        {
            /*
            var toDoList = new List<string>();
            toDoList.Add("Write Monthly Report");
            toDoList.Add("Schedule Team Meeting");
            toDoList.Add("Update Project Plan");
            */

            List<string> toDoList = ["Write Monthly Report", "Schedule Team Meeting", "Update Project Plan"];

            toDoList.Add("Review Budget");
            toDoList.Remove("Update Project Plan");
            toDoList.Insert(1, "Prepare Presentation");
            // Update
            toDoList[0] = "Write Weekly Report";

            foreach (string item in toDoList)
            {
                Console.WriteLine(item);
            }

            // Get
            Console.WriteLine($"The first task is {toDoList[0]}");
        }
    }
}