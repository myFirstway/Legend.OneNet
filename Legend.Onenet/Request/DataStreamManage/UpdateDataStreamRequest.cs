using System.Collections.Generic;
using System.Net.Http;

namespace Legend.Onenet.Request.DataStreamManage
{
    public class UpdateDataStreamRequest : RequestBase
    {
        public UpdateDataStreamRequest() : base(Constants.UpdateDataStream, HttpMethod.Put)
        {
        }
        public UpdateDataStreamRequest(OnenetOptions onenetOptions) : base(Constants.UpdateDataStream, onenetOptions, HttpMethod.Put)
        {
        }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备数据流ID
        /// </summary>
        public string DatastreamId { get; set; }

        /// <summary>
        /// 数据流标签，可为一个或者多个
        /// </summary>
        public List<string> Tags { get; set; }

        /// <summary>
        /// 数据单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 数据单位符号
        /// </summary>
        public string Unit_symbol { get; set; }

        protected override string BuildUrlPath()
        {
            string url = base.BuildUrlPath();
            return string.Format(url, DeviceId, DatastreamId);
        }
    }
}
