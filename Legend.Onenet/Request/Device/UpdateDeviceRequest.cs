using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace Legend.Onenet.Request.Device
{
    public class UpdateDeviceRequest : RequestBase
    {
        public UpdateDeviceRequest() : base(Constants.UpdateDevice, HttpMethod.Put)
        {
        }
        public UpdateDeviceRequest(OnenetOptions onenetOptions) : base(Constants.UpdateDevice, onenetOptions, HttpMethod.Put)
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

        /// <summary>
        /// 设备名称
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 设备描述
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// 设备私密性，决定应用编辑器分享链接中设备信息的可见度，默认为true
        /// </summary>
        public bool Private { get; set; } = true;
        /// <summary>
        /// 设标签，可为一个或者多个，见示例
        /// </summary>
        public List<string> Tags { get; set; }
        /// <summary>
        /// 设备位置坐标信息，以经纬度键值对表示:{"lon":xx,"lat":xx}
        /// </summary>
        public Location Location { get; set; }
        /// <summary>
        /// 	鉴权信息，建议携带，并设置为设备的产品序列号
        /// </summary>
        public string Auth_info { get; set; }
        /// <summary>
        /// 其他设备自定义信息，以键值对格式表示，见示例
        /// </summary>
        public Dictionary<string, string> Other { get; set; }

        protected override string BuildUrlPath()
        {
            string url = base.BuildUrlPath();
            return string.Format(url, Device_id);
        }
    }
}
