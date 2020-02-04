using System.Collections.Generic;
using System.Net.Http;

namespace Legend.Onenet.Request.Device
{
    public class AddDeviceRequest : RequestBase
    {
        public AddDeviceRequest() : base(Constants.AddDevice, HttpMethod.Post)
        {
        }
        public AddDeviceRequest(OnenetOptions onenetOptions) : base(Constants.AddDevice, onenetOptions, HttpMethod.Post)
        {
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
    }
}

public class Location
{
    public float Lon { get; set; }
    public float Lat { get; set; }
}

