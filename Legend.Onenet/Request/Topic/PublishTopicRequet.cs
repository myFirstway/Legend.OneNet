using System.Net.Http;

namespace Legend.Onenet.Request.Topic
{
    public class PublishTopicRequet : RequestBase
    {
        public PublishTopicRequet() : base(Constants.PublishTopic, HttpMethod.Post)
        {
        }
        public PublishTopicRequet(OnenetOptions onenetOptions) : base(Constants.PublishTopic, onenetOptions, HttpMethod.Post)
        {
        }

        private string topic;
        /// <summary>
        /// 发布消息到指定的topic，只支持发布qos=0的消息
        /// </summary>
        public string Topic
        {
            get { return topic; }
            set
            {
                PropertiesAdd(nameof(topic), value);
                topic = value;
            }
        }

        public void BuildHttpContent(HttpContent httpContent)
        {
            _httpRequestMessage.Content = httpContent;
        }
    }
}