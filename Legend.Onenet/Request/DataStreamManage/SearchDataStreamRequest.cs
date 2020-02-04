using System.Net.Http;

namespace Legend.Onenet.Request.DataStreamManage
{
    public class SearchDataStreamRequest : RequestBase
    {
        public SearchDataStreamRequest() : base(Constants.SearchDataStream, HttpMethod.Get)
        {
        }
        public SearchDataStreamRequest(OnenetOptions onenetOptions) : base(Constants.SearchDataStream, onenetOptions, HttpMethod.Get)
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

        protected override string BuildUrlPath()
        {
            string url = base.BuildUrlPath();
            return string.Format(url, DeviceId, DatastreamId);
        }
    }
}
