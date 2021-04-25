using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class WeatherForecastService
    {
        private static readonly Random rng = new();

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var results = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55)
            }).ToArray();

            // relational pattern matching <, >, <=, >=
            // logical pattern matching and, or, not
            foreach (var result in results)
            {
                result.Summary = result.TemperatureF switch
                {
                    < 0 => "well below freezing",
                    >= 0 and < 32 => "freezing",
                    32 or 212 => "exactly freezing or boiling",
                    > 32 and < 65 => "cool",
                    >= 65 and < 85 => "warm",
                    >= 85 => "hot"
                };
            }

            return Task.FromResult(results);
        }
    }
}
