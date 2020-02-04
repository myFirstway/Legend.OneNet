using Legend.Onenet.Request.Topic;
using Legend.Onenet.Response.Topic;
using System.Threading.Tasks;

namespace Legend.Onenet.Services
{
    public class TopicServices : ITopicServices
    {
        private readonly IOnenetClient _onenetClient;
        public TopicServices(IOnenetClient onenetClient)
        {
            _onenetClient = onenetClient;
        }
        public async Task<PublishTopicResponse> PublishTopicAsync(PublishTopicRequet publishTopicRequet)
        {
            return await _onenetClient.ExecuteAsync<PublishTopicResponse>(publishTopicRequet);
        }

        public async Task<SearchDeviceSubscribeTopicResponse> SearchDeviceSubscribeTopicAsync(SearchDeviceSubscribeTopicRequest searchDeviceSubscribeTopicRequest)
        {
            return await _onenetClient.ExecuteAsync<SearchDeviceSubscribeTopicResponse>(searchDeviceSubscribeTopicRequest);
        }

        public async Task<SearchProductTopicResponse> SearchProductTopicAsync(SearchProductTopicRequest searchProductTopicRequest)
        {
            return await _onenetClient.ExecuteAsync<SearchProductTopicResponse>(searchProductTopicRequest);
        }

        public async Task<SearchSubscribeTopicDeviceResponse> SearchSubscribeTopicDeviceAsync(SearchSubscribeTopicDeviceRequest searchSubscribeTopicDeviceRequest)
        {
            return await _onenetClient.ExecuteAsync<SearchSubscribeTopicDeviceResponse>(searchSubscribeTopicDeviceRequest);
        }
    }
}
