using System.Net.Http;

namespace Legend.Onenet.Request.Topic
{
    public class SearchSubscribeTopicDeviceRequest : RequestBase
    {
        public SearchSubscribeTopicDeviceRequest() : base(Constants.SearchSubscribeTopicDevice, HttpMethod.Get)
        {
        }
        public SearchSubscribeTopicDeviceRequest(OnenetOptions onenetOptions) : base(Constants.SearchSubscribeTopicDevice, onenetOptions, HttpMethod.Get)
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

        private int page;
        /// <summary>
        /// 指定页码
        /// </summary>
        public int Page
        {
            get { return page; }
            set
            {
                PropertiesAdd(nameof(page), value.ToString());
                page = value;
            }
        }

        private int per_page;
        /// <summary>
        /// 指定每页输出设备个数，默认30，最多1000
        /// </summary>
        public int Per_page
        {
            get { return per_page; }
            set
            {
                PropertiesAdd(nameof(per_page), value.ToString());
                per_page = value;
            }
        }


    }
}