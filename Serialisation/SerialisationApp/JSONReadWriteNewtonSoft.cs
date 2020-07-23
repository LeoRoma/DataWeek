//using System;
//using System.IO;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;

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
//            string jsonString = JsonConvert.SerializeObject(forecast);
//            File.WriteAllText("TodayForecast.json", jsonString);

//            string oldForecastJsonString = File.ReadAllText("OldForecast.json");
//            Console.WriteLine(oldForecastJsonString);
//            var oldForecast = JsonConvert.DeserializeObject<WeatherForecast>(oldForecastJsonString);

//            // Using LINQ for JSON

//            JObject jsonOldForecast = JObject.Parse(oldForecastJsonString);
//            var date = jsonOldForecast["Date"];
//            var temp = jsonOldForecast["TemperatureCelsius"];
//            var summary = jsonOldForecast["Summary"];
//        }
//    }
//}
