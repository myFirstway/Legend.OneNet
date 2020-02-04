using System.Collections.Generic;

namespace Legend.Onenet.Response.Device
{
    public class SearchMutiDevicesStatusResponse : ResponseBase<SearchMutiDevicesStatusResponseInfo>
    {

    }
    public class SearchMutiDevicesStatusResponseInfo
    {
        public IList<DeviceStatus> Devices { get; set; }
        public int Total_count { get; set; }
    }

    public class DeviceStatus
    {
        public string Title { get; set; }
        public bool Online { get; set; }
        public string Id { get; set; }
    }

}
