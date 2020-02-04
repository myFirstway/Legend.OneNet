using System.Net.Http;

namespace Legend.Onenet.Request.Device
{
    public class SearchMutiDevicesStatusRequest : RequestBase
    {
        public SearchMutiDevicesStatusRequest() : base(Constants.SearchMutiDevicesStatus, HttpMethod.Get)
        {
        }
        public SearchMutiDevicesStatusRequest(OnenetOptions onenetOptions) : base(Constants.SearchMutiDevicesStatus, onenetOptions, HttpMethod.Get)
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
