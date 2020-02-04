using Newtonsoft.Json;
using System.Net.Http;

namespace Legend.Onenet.Request.ApiKeyManage
{
    public class SearchApiKeyRequest : RequestBase
    {
        public SearchApiKeyRequest() : base(Constants.SearchApiKey, HttpMethod.Get)
        {
        }
        public SearchApiKeyRequest(OnenetOptions onenetOptions) : base(Constants.SearchApiKey, onenetOptions, HttpMethod.Get)
        {
        }


        private string key;
        /// <summary>
        /// 用于查询单独apikey详情
        /// </summary>
        [JsonIgnore]
        public string Key
        {
            get { return key; }
            set
            {
                PropertiesAdd(nameof(key), value);
                key = value;
            }
        }

        private string page;
        /// <summary>
        /// 指定页码
        /// </summary>
        [JsonIgnore]
        public string Page
        {
            get { return page; }
            set
            {
                PropertiesAdd(nameof(page), value);
                page = value;
            }
        }

        private string per_page;
        /// <summary>
        /// 每页输出个数，默认10，最多为100
        /// </summary>
        [JsonIgnore]
        public string PerPage
        {
            get { return per_page; }
            set
            {
                PropertiesAdd(nameof(per_page), value);
                per_page = value;
            }
        }


        private string device_id;
        /// <summary>
        /// 设备id
        /// </summary>
        [JsonIgnore]
        public string Device_id
        {
            get { return device_id; }
            set
            {
                PropertiesAdd(nameof(device_id), value);
                device_id = value;
            }
        }
    }
}
