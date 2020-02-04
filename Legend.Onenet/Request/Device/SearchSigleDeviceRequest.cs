using Newtonsoft.Json;
using System.Net.Http;

namespace Legend.Onenet.Request.Device
{
    public class SearchSigleDeviceRequest : RequestBase
    {
        public SearchSigleDeviceRequest() : base(Constants.SearchSigleDevice, HttpMethod.Get)
        {
        }

        public SearchSigleDeviceRequest(OnenetOptions onenetOptions) : base(Constants.SearchSigleDevice, onenetOptions, HttpMethod.Get)
        {
        }
        /// <summary>
        /// 设备id
        /// </summary>
        private string device_id;
        [JsonIgnore]
        public string Device_id
        {
            get { return device_id; }
            set
            {
                device_id = value;
                BuildUrlPath();
            }
        }
        protected override string BuildUrlPath()
        {
            string url = base.BuildUrlPath();
            return string.Format(url, Device_id);
        }
    }
}
