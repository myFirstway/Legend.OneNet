using Newtonsoft.Json;
using System.Net.Http;

namespace Legend.Onenet.Request.Device
{
    public class DeleteDeviceRequest : RequestBase
    {
        public DeleteDeviceRequest() : base(Constants.DeleteDevice, HttpMethod.Delete)
        {
        }
        public DeleteDeviceRequest(OnenetOptions onenetOptions) : base(Constants.DeleteDevice, onenetOptions, HttpMethod.Delete)
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
