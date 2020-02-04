using System.Collections.Generic;

namespace Legend.Onenet.Response.DataManage
{
    public class BatchSearchDeviceHistoryDataResponse : ResponseBase<BatchSearchDeviceHistoryDataResponseInfo>
    {

    }

    public class BatchSearchDeviceHistoryDataResponseInfo
    {
        public List<Device> Devices { get; set; }
    }


    public class Device
    {
        public string Title { get; set; }
        public string Id { get; set; }
        public List<DataStream> Datastreams { get; set; }
    }

    public class DataStream
    {
        public string At { get; set; }
        public string Id { get; set; }
        public dynamic Value { get; set; }
    }
}
