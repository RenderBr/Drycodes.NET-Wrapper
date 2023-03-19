using Drycodes.NET;

namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrycodesApi api = new();

            List<string> test = new List<string>()
            {
                api.GenerateBoyName(),
                api.GenerateGirlName(),
                api.GenerateMovie(),
                api.GenerateObject(),
                api.GeneratePlanet(),
                api.GeneratePresident(),
                api.GenerateRandomName(),
                api.GenerateState(),
                api.GenerateFunnyWord(),
                api.GenerateGame(),
                api.GenerateCityName(),
                api.GenerateContinentName(),
                api.GenerateCountryName(),
                api.RandomPortNumber().ToString(),
                api.RandomPrivilegedPortNumber().ToString()
                
            };
            foreach(string t in test)
            {
                Console.WriteLine(t);
            }
            
        }
    }
}