using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Legend.Onenet.Request.DataManage
{
    public class UploadDataPointRequest : RequestBase
    {
        public UploadDataPointRequest() : base(Constants.UploadDataPoint, HttpMethod.Post)
        {
        }
        public UploadDataPointRequest(OnenetOptions onenetOptions) : base(Constants.UploadDataPoint, onenetOptions, HttpMethod.Post)
        {
        }
        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonIgnore]
        public string Device_id { get; set; }

        private string type;
        /// <summary>
        /// 数据格式，默认为完整JSON型（见示例） 查onenet文档
        /// </summary>
        [JsonIgnore]
        public string Type
        {
            get { return type; }
            set
            {
                PropertiesAdd(nameof(type), value);
                type = value;
            }
        }

        public List<Datastream> Datastreams { get; set; }

    }
}

public class Datastream
{
    public string Id { get; set; }
    public List<Datapoint> Datapoints { get; set; }
}

public class Datapoint
{
    public DateTime At { get; set; }
    public object Value { get; set; }
}
