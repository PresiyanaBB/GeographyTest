using GeographyTest.Models;
using System;
using System.Linq;

namespace GeographyTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new GeographyContext();
            //CreateNewPeak(context);
            //ChangeToEUR(context);
            //IncreasePopulation(context);
        }
        public static void CreateNewPeak(GeographyContext context)
        {
            var peak = new Peak
            {
                PeakName = "Snowdon",
                Elevation = 1085,
                Mountain = new Mountain { MountainRange = "Ben Nevis" }
            };
            context.Peaks.Add(peak);
            context.SaveChanges();

        }

        public static void ChangeToEUR(GeographyContext context)
        {
            var countries = context.Countries
                .Where(x => x.CountryName == "United Kingdom" || x.CountryName == "Romania" || x.CountryName == "Ukraine")
                .ToList();

            foreach (var country in countries)
            {
                country.CurrencyCode = "EUR";
            }

            context.SaveChanges();
        }

        public static void IncreasePopulation(GeographyContext context)
        {
            var countries = context.Countries.ToList();
            foreach(var country in countries)
            {
                country.Population += 100;
            }

            context.SaveChanges();
        }
    }
}
