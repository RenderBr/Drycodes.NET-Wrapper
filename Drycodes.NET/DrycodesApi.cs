using Newtonsoft.Json;

namespace Drycodes.NET
{
    public class DrycodesApi
    {
        private Handler handler;
        public DrycodesApi()
        {
            handler = new Handler();
        }
        #region Multiples
        /// <summary>
        /// Generates random names, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of names to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random names</returns>
        public string[] GenerateRandomNames(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?combine=1&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random boy names, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of boy names to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random boy names</returns>
        public string[] GenerateBoyNames(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=boy_names&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random girl names, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of girl names to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random girl names</returns>
        public string[] GenerateGirlNames(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=girl_names&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random objects, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of objects to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random objects</returns>
        public string[] GenerateObjects(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=objects&combine=1&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random city names, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of city names to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random city names</returns>
        public string[] GenerateCityNames(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=cities&combine=1&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random continent names, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of continent names to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random continent names</returns>
        public string[] GenerateContinentNames(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=continents&combine=1&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random country names, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of country names to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random country names</returns>
        public string[] GenerateCountryNames(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=countries&combine=1&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random movie names, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of movie names to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random movie names</returns>
        public string[] GenerateMovies(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=films&combine=1&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random funny words, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of funny words to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random funny words</returns>
        public string[] GenerateFunnyWords(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=funnyWords&combine=1&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random planet names, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of planet names to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random planet names</returns>
        public string[] GeneratePlanets(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=planets&combine=1&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random game names, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of game names to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random game names</returns>
        public string[] GenerateGames(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=games&combine=1&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random president names, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of president names to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random president names</returns>
        public string[] GeneratePresidents(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=presidents&combine=1&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random starwars characters, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of starwars characters to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random starwars characters</returns>
        public string[] StarwarsCharacters(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=starwarsCharacters&combine=1&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random starwars first names, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of starwars first names to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random starwars first names</returns>
        public string[] StarwarsFirstNames(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=starwarsFirstNames&combine=1&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random starwars last names, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of starwars last names to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random starwars last names</returns>
        public string[] StarwarsLastNames(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=starwarsLastNames&combine=1&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random starwars titles, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of starwars titles to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random starwars titles</returns>
        public string[] StarwarsTitles(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=starwarsTitles&combine=1&separator={separator}").Result.Content);
        /// <summary>
        /// Generates random starwars planets, default quantity is 10
        /// </summary>
        /// <param name="qty">Quantity of starwars planets to generate</param>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string array of random starwars planets</returns>
        public string[] GenerateStates(int qty = 10, string separator = "space") => JsonConvert.DeserializeObject<string[]>(handler.NewRequest(qty.ToString() + $"?nameOptions=states&combine=1&separator={separator}").Result.Content);
        /// <summary>
        /// Generates a singular random name
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random name</returns>
        #endregion
        #region Singles
        public string GenerateRandomName(string separator = "space") => GenerateRandomNames(1, separator).First();
        /// <summary>
        /// Generates a singular random boy name
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random boy name</returns>
        public string GenerateBoyName(string separator = "space") => GenerateBoyNames(1, separator).First();
        /// <summary>
        /// Generates a singular random girl name
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random girl name</returns>
        public string GenerateGirlName(string separator = "space") => GenerateGirlNames(1, separator).First();
        /// <summary>
        /// Generates a singular random object
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random object</returns>
        public string GenerateObject(string separator = "space") => GenerateObjects(1, separator).First();
        /// <summary>
        /// Generates a singular random city name
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random city name</returns>
        public string GenerateCityName(string separator = "space") => GenerateCityNames(1, separator).First();
        /// <summary>
        /// Generates a singular random continent name
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random continent name</returns>
        public string GenerateContinentName(string separator = "space") => GenerateContinentNames(1, separator).First();
        /// <summary>
        /// Generates a singular random country name
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random country name</returns>
        public string GenerateCountryName(string separator = "space") => GenerateCountryNames(1, separator).First();
        /// <summary>
        /// Generates a singular random movie name
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random movie name</returns>
        public string GenerateMovie(string separator = "space") => GenerateMovies(1, separator).First();
        /// <summary>
        /// Generates a singular random funny word
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random funny word</returns>
        public string GenerateFunnyWord(string separator = "space") => GenerateFunnyWords(1, separator).First();
        /// <summary>
        /// Generates a singular random planet name
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random planet name</returns>
        public string GeneratePlanet(string separator = "space") => GeneratePlanets(1, separator).First();
        /// <summary>
        /// Generates a singular random game name
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random game name</returns>
        public string GenerateGame(string separator = "space") => GenerateGames(1, separator).First();
        /// <summary>
        /// Generates a singular random president name
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random president name</returns>
        public string GeneratePresident(string separator = "space") => GeneratePresidents(1, separator).First();
        /// <summary>
        /// Generates a singular random starwars character
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random starwars character</returns>
        public string StarwarsCharacter(string separator = "space") => StarwarsCharacters(1, separator).First();
        /// <summary>
        /// Generates a singular random starwars first name
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random starwars first name</returns>
        public string StarwarsFirstName(string separator = "space") => StarwarsFirstNames(1, separator).First();
        /// <summary>
        /// Generates a singular random starwars last name
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random starwars last name</returns>
        public string StarwarsLastName(string separator = "space") => StarwarsLastNames(1, separator).First();
        /// <summary>
        /// Generates a singular random starwars title
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random starwars title</returns>
        public string StarwarsTitle(string separator = "space") => StarwarsTitles(1, separator).First();
        /// <summary>
        /// Generates a singular random US state
        /// </summary>
        /// <param name="separator">separator where spaces would be, default: " "</param>
        /// <returns>A string of a random US state</returns>
        public string GenerateState(string separator = "space") => GenerateStates(1, separator).First();
        /// <summary>
        /// Generates a random port number
        /// </summary>
        /// <returns>An int of a random port number</returns>
        public int RandomPortNumber() => JsonConvert.DeserializeObject<int>(handler.NewRequest("port").Result.Content);
        /// <summary>
        /// Generates a random privileged port number
        /// </summary>
        /// <returns>An int of a random privileged port number</returns>
        public int RandomPrivilegedPortNumber() => JsonConvert.DeserializeObject<int>(handler.NewRequest("port?privileged=true").Result.Content);
        #endregion
    }
}