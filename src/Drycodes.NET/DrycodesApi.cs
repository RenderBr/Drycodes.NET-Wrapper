namespace Drycodes.NET
{
    /// <summary>
    ///     Represents the root class to interact with the drycodes API available at: <see href="https://names.drycodes.com/"/>.
    /// </summary>
    public class DrycodesApi
    {
        private readonly RequestHandler _handler;

        /// <summary>
        ///     Craetes a new <see cref="DrycodesApi"/> accessor.
        /// </summary>
        /// <param name="reuseClient">To reuse the inner <see cref="HttpClient"/> across multiple API clients.</param>
        public DrycodesApi(bool reuseClient = true)
        {
            _handler = new RequestHandler(reuseClient);
        }

        /// <summary>
        ///     Generates a range of values from the provided <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type of term or name to generate.</param>
        /// <param name="quantity">The amount of entries to generate.</param>
        /// <param name="separator">The separator used to split the terms of a returned value, the default is <c>" "</c>.</param>
        /// <returns>The returned values.</returns>
        public string[] GenerateMany(RequestType type, int quantity = 10, string separator = "space")
            => GenerateManyAsync(type, quantity, separator)
                .GetAwaiter()
                .GetResult();

        /// <summary>
        ///     Generates a range of values from the provided <paramref name="type"/> asynchronously.
        /// </summary>
        /// <param name="type">The type of term or name to generate.</param>
        /// <param name="quantity">The amount of entries to generate.</param>
        /// <param name="separator">The separator used to split the terms of a returned value, the default is <c>" "</c>.</param>
        /// <param name="cancellationToken">The cancellation token that can be used to signal cancellation of the inner HTTP request.</param>
        /// <returns>An asynchronous <see cref="Task"/> holding the returned values inside.</returns>
        public Task<string[]> GenerateManyAsync(RequestType type, int quantity = 10, string separator = "space", CancellationToken cancellationToken = default)
        {
            if (type is null)
                throw new ArgumentNullException(nameof(type), "The request type cannot be null.");

            var qb = new QueryBuilder();

            if (type.IsQueryable)
                qb.Append("nameOptions", type);

            qb.Append("combine", "1");
            qb.Append("separator", separator);

            var query = $"{quantity}{qb}";

            return _handler.RequestAsync<string[]>(query, cancellationToken);
        }

        /// <summary>
        ///     Generates a single value from the provided <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type of term or name to generate.</param>
        /// <param name="separator">The separator used to split the terms of a returned value, the default is <c>" "</c>.</param>
        /// <returns>The returned value.</returns>
        public string GenerateSingle(RequestType type, string separator = "space")
            => GenerateSingleAsync(type, separator)
                .GetAwaiter()
                .GetResult();

        /// <summary>
        ///     Generates a single value from the provided <paramref name="type"/> asynchronously.
        /// </summary>
        /// <param name="type">The type of term or name to generate.</param>
        /// <param name="separator">The separator used to split the terms of a returned value, the default is <c>" "</c>.</param>
        /// <param name="cancellationToken">The cancellation token that can be used to signal cancellation of the inner HTTP request.</param>
        /// <returns>An asynchronous <see cref="Task"/> holding a requested value inside.</returns>
        public async Task<string> GenerateSingleAsync(RequestType type, string separator = "space", CancellationToken cancellationToken = default)
        {
            var values = await GenerateManyAsync(type, 1, separator, cancellationToken);

            return values[0];
        }

        /// <summary>
        ///     Generates a random port number.
        /// </summary>
        /// <param name="privileged">If the port number should be privileged or not.</param>
        /// <returns>The returned port number.</returns>
        public int RandomPortNumber(bool privileged)
            => RandomPortNumberAsync(privileged)
                .GetAwaiter()
                .GetResult();

        /// <summary>
        ///     Generates a random port number asynchronously.
        /// </summary>
        /// <param name="privileged">If the port number should be privileged or not.</param>
        /// <param name="cancellationToken">The cancellation token that can be used to signal cancellation of the inner HTTP request.</param>
        /// <returns>An asynchronous <see cref="Task"/> holding a port number as its value.</returns>
        public Task<int> RandomPortNumberAsync(bool privileged, CancellationToken cancellationToken = default)
        {
            var qb = new QueryBuilder();

            qb.Append("privileged", privileged ? "true" : "false");

            var query = $"port{qb}";

            return _handler.RequestAsync<int>(query, cancellationToken);
        }
    }
}