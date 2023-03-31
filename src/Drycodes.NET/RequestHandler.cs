using System.Text.Json;

namespace Drycodes.NET
{
    /// <summary>
    ///     Represents the handler that handles incoming API requests after defining the expected inputs.
    /// </summary>
    public class RequestHandler
    {
        /// <summary>
        ///     The default API address used to query.
        /// </summary>
        public const string API_ADDRESS = "https://names.drycodes.com/";

        private static readonly Lazy<HttpClient> _shared = new(() => new()
        {
            BaseAddress = new Uri(API_ADDRESS)
        });

        private readonly HttpClient _client;

        internal RequestHandler(bool fromLazy)
        {
            if (fromLazy)
                _client = _shared.Value;
            else
                _client = new HttpClient()
                {
                    BaseAddress = new Uri(API_ADDRESS)
                };
        }

        internal async Task<T> RequestAsync<T>(string query, CancellationToken cancellationToken)
        {
            var value = await _client.GetAsync(query, cancellationToken);

            if (value.Content is null)
                throw new ArgumentNullException(nameof(query), "The endpoint did not return any values.");

            if (!value.IsSuccessStatusCode)
                throw new HttpRequestException($"The request returned an unhandled HTTP status code: {value.StatusCode}.");

            using (var reader = await value.Content.ReadAsStreamAsync(cancellationToken))
            {
                var result = await JsonSerializer.DeserializeAsync<T>(reader, cancellationToken: cancellationToken);

                if (result is null)
                    throw new InvalidOperationException("The endpoint did not return JSON matching the expected type.");

                return result;
            }
        }
    }
}
