using Drycodes.NET;

namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrycodesApi api = new();


            var test = api.GenerateGirlNames(100);

            foreach (string t in test)
            {
                Console.WriteLine(t);
            }

        }
    }
}