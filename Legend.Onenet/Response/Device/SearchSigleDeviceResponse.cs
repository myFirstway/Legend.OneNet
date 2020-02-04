using System.Collections.Generic;

namespace Legend.Onenet.Response.Device
{
    public class SearchSigleDeviceResponse : ResponseBase<SearchSigleDeviceResponseInfo>
    {

    }

    public class SearchSigleDeviceResponseInfo
    {
        public string Protocol { get; set; }
        public Other Other { get; set; }
        public string Create_time { get; set; }
        public bool Online { get; set; }
        public Location Location { get; set; }
        public string Id { get; set; }
        public string Auth_info { get; set; }
        public IList<Datastream> Datastreams { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public IList<string> Tags { get; set; }
    }

    public class Other
    {
        public string Version { get; set; }
        public string Manufacturer { get; set; }
    }

    public class Location
    {
        public float Lat { get; set; }
        public float Lon { get; set; }
    }

    public class Datastream
    {
        public string Unit { get; set; }
        public string Id { get; set; }
        public string Unit_symbol { get; set; }
        public string Create_time { get; set; }
    }

}
