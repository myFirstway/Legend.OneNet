using System.Collections.Generic;
using System.Net.Http;

namespace Legend.Onenet.Request.Topic
{
    public class SearchProductTopicRequest : RequestBase
    {
        public SearchProductTopicRequest() : base(Constants.SearchProductTopic, HttpMethod.Post)
        {
        }
        public SearchProductTopicRequest(OnenetOptions onenetOptions) : base(Constants.SearchProductTopic, onenetOptions, HttpMethod.Post)
        {
        }
        public string Title { get; set; }
        public List<Permission> Permissions { get; set; }
    }
}
