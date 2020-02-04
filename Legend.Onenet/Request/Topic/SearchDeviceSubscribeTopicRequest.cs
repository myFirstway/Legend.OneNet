using System.Net.Http;

namespace Legend.Onenet.Request.Topic
{
    public class SearchDeviceSubscribeTopicRequest : RequestBase
    {
        public SearchDeviceSubscribeTopicRequest() : base(Constants.SearchDeviceSubscribeTopic, HttpMethod.Get)
        {
        }
        public SearchDeviceSubscribeTopicRequest(OnenetOptions onenetOptions) : base(Constants.SearchDeviceSubscribeTopic, onenetOptions, HttpMethod.Get)
        {
        }
        public string Device_id { get; set; }

        protected override string BuildUrlPath()
        {
            string url = base.BuildUrlPath();
            return string.Format(url, Device_id);
        }
    }
}
