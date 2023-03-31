using System.Text;

namespace Drycodes.NET
{
    /// <summary>
    ///     Represents a builder that can construct queries from their respective parameters.
    /// </summary>
    public class QueryBuilder
    {
        private readonly List<string> _query;

        /// <summary>
        ///     Creates a new <see cref="QueryBuilder"/>.
        /// </summary>
        public QueryBuilder()
        {
            _query = new();
        }

        /// <summary>
        ///     Adds a parameter with its value to the query.
        /// </summary>
        /// <param name="queryParameter">The parameter to add.</param>
        /// <param name="queryValue">The value to add.</param>
        /// <returns>The same builder for chaining calls.</returns>
        public QueryBuilder Append(string queryParameter, string? queryValue = null)
        {
            if (string.IsNullOrEmpty(queryParameter))
                return this;

            var sb = new StringBuilder();

            sb.Append(queryParameter);

            if (!string.IsNullOrEmpty(queryParameter))
                sb.Append('=');
            sb.Append(queryValue);

            _query.Add(sb.ToString());
            return this;
        }

        /// <summary>
        ///     Formats the builder into a valid query.
        /// </summary>
        /// <returns>The formatted query resulting from this builder.</returns>
        public string ToQuery()
        {
            var joinedArgs = string.Join("&", _query);

            return '?' + joinedArgs;
        }
    }
}
