using System.Net.Http;

namespace Legend.Onenet.Request.DataStreamManage
{
    public class DeleteDataStreamRequest : RequestBase
    {
        public DeleteDataStreamRequest() : base(Constants.DeleteDataStream, HttpMethod.Delete)
        {
        }
        public DeleteDataStreamRequest(OnenetOptions onenetOptions) : base(Constants.DeleteDataStream, onenetOptions, HttpMethod.Delete)
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
