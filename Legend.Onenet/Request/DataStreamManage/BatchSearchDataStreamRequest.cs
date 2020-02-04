using System.Net.Http;

namespace Legend.Onenet.Request.DataStreamManage
{
    public class BatchSearchDataStreamRequest : RequestBase
    {
        public BatchSearchDataStreamRequest() : base(Constants.BatchSearchDataStream, HttpMethod.Get)
        {
        }
        public BatchSearchDataStreamRequest(OnenetOptions onenetOptions) : base(Constants.BatchSearchDataStream, onenetOptions, HttpMethod.Get)
        {
        }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceId { get; set; }

        private string datastream_ids;

        public string Datastream_ids
        {
            get { return datastream_ids; }
            set
            {
                PropertiesAdd(nameof(datastream_ids), value);
                datastream_ids = value;
            }
        }


        protected override string BuildUrlPath()
        {
            string url = base.BuildUrlPath();
            return string.Format(url, DeviceId);
        }
    }
}
