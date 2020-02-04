using System.Collections.Generic;

namespace Legend.Onenet.Response.Device
{
    public class SearchMutiDevicesResponse : ResponseBase<SearchMutiDevicesResponseInfo>
    {

    }

    public class SearchMutiDevicesResponseInfo
    {
        public int Per_page { get; set; }
        public IList<Device> Devices { get; set; }
        public int Total_count { get; set; }
        public int Page { get; set; }
    }

    public class Device
    {
        public string Protocol { get; set; }
        public Other Other { get; set; }
        public string Create_time { get; set; }
        public bool Online { get; set; }
        public Location Location { get; set; }
        public string Id { get; set; }
        public string Auth_info { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public IList<string> Tags { get; set; }
    }
}
