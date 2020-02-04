using Legend.Onenet.Request;
using Legend.Onenet.Response;
using Legend.Onenet.Serialization;
using Legend.Onenet.Services;
using System.Net.Http;
using System.Threading.Tasks;

namespace Legend.Onenet
{
    public class DefaultOneNetClient : IOnenetClient
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private readonly ITokenService _tokenService;
        public DefaultOneNetClient()
        {
            _tokenService = new ApiKeyTokenService();
        }
        public async Task<T> ExecuteAsync<T>(RequestBase requestBase) where T : OneNetResponse, new()
        {
            var request = requestBase.BuildHttpRequestMessage();
            var header = await _tokenService.AssembleToken(requestBase.OnenetOptions);
            request.Headers.Add(header.Key, header.Value);
            var httpResponse = await _httpClient.SendAsync(request);
            if (httpResponse.IsSuccessStatusCode)
            {
                if (typeof(T).IsSubclassOf(typeof(ByteArrayResponse)))
                {
                    ByteArrayResponse byteArrayResponse = new ByteArrayResponse
                    {
                        Errno = 0,
                        Error = "byte数据",
                        Data = await httpResponse.Content.ReadAsByteArrayAsync()
                    };
                    return (T)(object)byteArrayResponse;
                }
                string content = await httpResponse.Content.ReadAsStringAsync();
                T result = SerializationHelper.DeserializeObject<T>(content);
                return result;
            }
            else
            {
                return new T { Errno = 1, Error = $"StatusCode:{httpResponse.StatusCode} ReasonPhrase: {httpResponse.ReasonPhrase}" };
            }
        }
    }
}
