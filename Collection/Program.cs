namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var weatherData = new Dictionary<string, string>();

            // Add key and value
            weatherData.Add("Paris", "Sunny, 20��C");
            // or
            weatherData["New York"] = "Cloudy, 15��C";

            // Get value
            Console.WriteLine($"Weather in NY: {weatherData["New York"]}");

            // Modify value
            weatherData["New York"] = "Cloudy, 18��C";

            // Get value again
            Console.WriteLine($"Weather in NY: {weatherData["New York"]}");

            // Remove key and value
            weatherData.Remove("New York");

            // Throw an exception
            // Console.WriteLine($"Weather in Paris: {weatherData["New York"]}");
            */

            var weatherData = new Dictionary<string, string>
            {
                {"Paris", "Sunny, 20��C"},
                {"New York", "Cloudy, 18��C"},
                {"London", "Rainy, 15��C"}
            };

            Console.Write("Enter a city name: ");
            var city = Console.ReadLine() ?? "";

            if (weatherData.TryGetValue(city, out var value))
            {
                Console.WriteLine($"Weather in {city}: {value}");
            }
            else
            {
                Console.WriteLine("Weather data not available for this city.");
            }
        }
    }
}