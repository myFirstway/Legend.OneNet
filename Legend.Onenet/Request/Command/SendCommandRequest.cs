using Newtonsoft.Json;
using System.Net.Http;

namespace Legend.Onenet.Request.Command
{
    public class SendCommandRequest : RequestBase
    {
        public SendCommandRequest() : base(Constants.SendCommand, HttpMethod.Post, false)
        {
        }

        public SendCommandRequest(OnenetOptions onenetOptions) : base(Constants.SendCommand, onenetOptions, HttpMethod.Post, false)
        {
        }
        private string device_id;
        /// <summary>
        /// 接收该数据的设备ID
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

        private int qos;
        /// <summary>
        /// 是否需要设备应答，默认为0。
        /// 0：最多发送一次，不关心设备是否响应
        /// 1：至少发送一次，如果设备收到命令后没有应答，则会在下一次设备登录时若命令在有效期内（有效期定义参见timeout参数）则会重发该命令
        /// </summary>
        [JsonIgnore]
        public int Qos
        {
            get { return qos; }
            set
            {
                PropertiesAdd(nameof(qos), qos.ToString());
                qos = value;
            }
        }


        private int timeout;
        /// <summary>
        /// 命令有效时间，默认0。
        /// 0：在线命令，若设备在线,下发给设备，若设备离线，直接丢弃
        /// >0： 离线命令，若设备在线，下发给设备，若设备离线，在当前时间加timeout时间内为有效期，有效期内，若设备上线，则下发给设备
        /// 单位：秒
        /// </summary>
        [JsonIgnore]
        public int Timeout
        {
            get { return timeout; }
            set
            {
                PropertiesAdd(nameof(timeout), value.ToString());
                timeout = value;
            }
        }

        public void BuildHttpContent(HttpContent httpContent)
        {
            _httpRequestMessage.Content = httpContent;
        }
    }
}
