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

            foreach (var item in toDoList)
            {
                Console.WriteLine(item);
            }                
        }
    }
}