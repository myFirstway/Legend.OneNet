using System.Collections.Generic;

namespace Legend.Onenet.Response.DataManage
{
    public class SearchDeviceHistoryResponse : ResponseBase<SearchDeviceHistoryResponseInfo>
    {

    }

    public class SearchDeviceHistoryResponseInfo
    {
        public string Cursor { get; set; }
        public int Count { get; set; }
        public List<Datastream> Datastreams { get; set; }
    }

    public class Datastream
    {
        public List<Datapoint> Datapoints { get; set; }
        public string Id { get; set; }
    }

    public class Datapoint
    {
        public string At { get; set; }
        public string Value { get; set; }
    }

}
