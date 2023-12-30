namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var weatherData = new Dictionary<string, string>();

            // Add key and value
            weatherData.Add("Paris", "Sunny, 20ÅãC");
            // or
            weatherData["New York"] = "Cloudy, 15ÅãC";

            // Get value
            Console.WriteLine($"Weather in NY: {weatherData["New York"]}");

            // Modify value
            weatherData["New York"] = "Cloudy, 18ÅãC";

            // Get value again
            Console.WriteLine($"Weather in NY: {weatherData["New York"]}");

            // Remove key and value
            weatherData.Remove("New York");

            // Throw an exception
            // Console.WriteLine($"Weather in Paris: {weatherData["New York"]}");
            */

            var weatherData = new Dictionary<string, string>
            {
                {"Paris", "Sunny, 20ÅãC"},
                {"New York", "Cloudy, 18ÅãC"},
                {"London", "Rainy, 15ÅãC"}
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