using RestSharp;

namespace Drycodes.NET
{
    internal class Handler
    {
        RestClient client;

        internal Handler()
        {
            client = new RestClient("https://names.drycodes.com/");
        }

        internal async Task<RestResponse> NewRequest(string endpoint) => await client.GetAsync(new RestRequest(endpoint));

        internal string[] Beautify(string[] tb)
        {
            for (var i = 0; i < tb.Count(); i++)
            {
                tb[i] = tb[i].Replace("_", " ");
            }

            return tb;
        }
        
    }
}
