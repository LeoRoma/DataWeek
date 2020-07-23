//using System;
//using System.IO;
//using System.Text.Json;

//namespace SerialisationApp
//{
//    public class WeatherForecast
//    {
//        public DateTimeOffset Date { get; set; }
//        public int TemperatureCelsius { get; set; }
//        public string Summary { get; set; }
//    }

//    public class Program
//    {
//        public static void Main()
//        {
//            var forecast = new WeatherForecast()
//            {
//                Date = DateTime.Now,
//                TemperatureCelsius = 15,
//                Summary = "Dull and Rainy"
//            };
//            string jsonString = JsonSerializer.Serialize(forecast);
//            File.WriteAllText("TodayForecast.json", jsonString);

//            string oldForecastJson = File.ReadAllText("OldForecast.json");
//            Console.WriteLine(oldForecastJson);
//            var oldForecast = JsonSerializer.Deserialize<WeatherForecast>(oldForecastJson);

//        }
//    }
//}
