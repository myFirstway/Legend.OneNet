using Legend.Onenet.Request.Topic;
using Legend.Onenet.Response.Topic;
using System.Threading.Tasks;

namespace Legend.Onenet.Services
{
    public interface ITopicServices
    {
        Task<PublishTopicResponse> PublishTopicAsync(PublishTopicRequet publishTopicRequet);
        Task<SearchDeviceSubscribeTopicResponse> SearchDeviceSubscribeTopicAsync(SearchDeviceSubscribeTopicRequest searchDeviceSubscribeTopicRequest);
        Task<SearchProductTopicResponse> SearchProductTopicAsync(SearchProductTopicRequest searchProductTopicRequest);
        Task<SearchSubscribeTopicDeviceResponse> SearchSubscribeTopicDeviceAsync(SearchSubscribeTopicDeviceRequest searchSubscribeTopicDeviceRequest);
    }
}
