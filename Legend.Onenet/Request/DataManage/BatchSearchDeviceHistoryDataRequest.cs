using System.Net.Http;

namespace Legend.Onenet.Request.DataManage
{
    public class BatchSearchDeviceHistoryDataRequest : RequestBase
    {
        public BatchSearchDeviceHistoryDataRequest() : base(Constants.BatchSearchDeviceHistoryData, HttpMethod.Get)
        {
        }
        public BatchSearchDeviceHistoryDataRequest(OnenetOptions onenetOptions) : base(Constants.BatchSearchDeviceHistoryData, onenetOptions, HttpMethod.Get)
        {
        }
        private string devIds;
        /// <summary>
        /// 指定设备ID，多个用逗号分隔，最多1000个
        /// </summary>
        public string DevIds
        {
            get { return devIds; }
            set
            {
                PropertiesAdd(nameof(devIds), value);
                devIds = value;
            }
        }

    }
}