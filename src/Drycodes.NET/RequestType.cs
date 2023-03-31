namespace Drycodes.NET
{
    /// <summary>
    ///     Represents the different kinds of requests you can make to the API.
    /// </summary>
    public class RequestType
    {
        /// <summary>
        ///     If the input is queryable or not.
        /// </summary>
        public bool IsQueryable { get; }

        /// <summary>
        ///     The input for the query.
        /// </summary>
        public string QueryInput { get; }

        /// <summary>
        ///     Creates a new custom <see cref="RequestType"/> from the provided values.
        /// </summary>
        /// <param name="queryInput">Represents the input for the query, for example <c>"boy_names"</c></param>
        /// <param name="isQueryable">Represents if the query should be used or not. Normally this remains true.</param>
        public RequestType(string queryInput, bool isQueryable = true)
        {
            QueryInput = queryInput;
            IsQueryable = isQueryable;
        }

        /// <summary>
        ///     Represents the default fetch type, for all types of names.
        /// </summary>
        public static RequestType None { get; } = new("", false);

        /// <summary>
        ///     Fetches boy names.
        /// </summary>
        public static RequestType Boys { get; } = new("boy_names");

        /// <summary>
        ///     Fetches girl names.
        /// </summary>
        public static RequestType Girls { get; } = new("girl_names");

        /// <summary>
        ///     Fetches object names.
        /// </summary>
        public static RequestType Objects { get; } = new("objects");

        /// <summary>
        ///     Fetches city names.
        /// </summary>
        public static RequestType Cities { get; } = new("cities");

        /// <summary>
        ///     Fetches state names.
        /// </summary>
        public static RequestType States { get; } = new("states");

        /// <summary>
        ///     Fetches country names.
        /// </summary>
        public static RequestType Countries { get; } = new("countries");

        /// <summary>
        ///     Fetches continent names.
        /// </summary>
        public static RequestType Continents { get; } = new("continents");

        /// <summary>
        ///     Fetches movie names.
        /// </summary>
        public static RequestType Movies { get; } = new("films");

        /// <summary>
        ///     Fetches funny words.
        /// </summary>
        public static RequestType FunnyWords { get; } = new("funnyWords");

        /// <summary>
        ///     Fetches planet names.
        /// </summary>
        public static RequestType Planets { get; } = new("planets");

        /// <summary>
        ///     Fetches game names.
        /// </summary>
        public static RequestType Games { get; } = new("games");

        /// <summary>
        ///     Fetches president names.
        /// </summary>
        public static RequestType Presidents { get; } = new("presidents");

        /// <summary>
        ///     Fetches Star Wars character names.
        /// </summary>
        public static RequestType StarwarsCharacters { get; } = new("starwarsCharacters");

        /// <summary>
        ///     Fetches Star Wars last names.
        /// </summary>
        public static RequestType StarwarsLastNames { get; } = new("starwarsLastNames");

        /// <summary>
        ///     Fetches Star Wars first names.
        /// </summary>
        public static RequestType StarwarsFirstNames { get; } = new("starwarsFirstNames");

        /// <summary>
        ///     Fetches Star Wars titles.
        /// </summary>
        public static RequestType StarwarsTitles { get; } = new("starwarsTitles");

        /// <inheritdoc/>
        public override string ToString()
            => QueryInput;

        public static implicit operator RequestType(string queryInput)
            => new(queryInput);

        public static implicit operator string(RequestType requestType)
            => new(requestType.ToString());
    }
}
