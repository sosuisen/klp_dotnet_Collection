namespace Collection
{
    class Program
    {
        static void Main()
        {
            // List<string> toDoList = new();
            // toDoList.Add("Write Monthly Report");
            // toDoList.Add("Schedule Team Meeting");
            // toDoList.Add("Update Project Plan");

            List<string> toDoList = ["Write Monthly Report", "Schedule Team Meeting", "Update Project Plan"];

            foreach (string item in toDoList)
            {
                Console.WriteLine(item);
            }
        }
    }
}