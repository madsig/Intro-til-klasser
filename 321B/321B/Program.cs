namespace _321B
{
    class CountryData
    {
        public string Country { get; set; }
        public int Deaths1800 { get; set; }
        public int Deaths1900 { get; set; }
        public int Deaths2000 { get; set; }
        public double HealthcareBudget { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CountryData[] europeanCountries = new CountryData[]
            {
                new CountryData
                {
                    Country = "Germany", Deaths1800 = 5000, Deaths1900 = 20000, Deaths2000 = 10000,
                    HealthcareBudget = 5.7e11
                },
                new CountryData
                {
                    Country = "France", Deaths1800 = 8000, Deaths1900 = 25000, Deaths2000 = 15000,
                    HealthcareBudget = 4.3e11
                },
                new CountryData
                {
                    Country = "United Kingdom", Deaths1800 = 12000, Deaths1900 = 30000, Deaths2000 = 20000,
                    HealthcareBudget = 2.8e11
                },
                // ChatGpt ga meg bare 3 :(

            };
            WriteData(europeanCountries);
        }

        public static void WriteData(CountryData[] countries)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("| Country          | Deaths 1800  | Deaths 1900  | Deaths 2000  | Healthcare Budget   |");
            Console.WriteLine("----------------------------------------------------------------------------------------");

            foreach (var country in countries)
            {
                Console.WriteLine(
                    $"| {country.Country,-16} | {country.Deaths1800,-12} | {country.Deaths1900,-12} | {country.Deaths2000,-12} | {country.HealthcareBudget,-18:C} |");
            }

            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
    }
}