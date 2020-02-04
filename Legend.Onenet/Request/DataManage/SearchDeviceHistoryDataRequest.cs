using System;
using System.Net.Http;

namespace Legend.Onenet.Request.DataManage
{
    public class SearchDeviceHistoryDataRequest : RequestBase
    {
        public SearchDeviceHistoryDataRequest() : base(Constants.SearchDeviceHistoryData, HttpMethod.Get)
        {
        }
        public SearchDeviceHistoryDataRequest(OnenetOptions onenetOptions) : base(Constants.SearchDeviceHistoryData, onenetOptions, HttpMethod.Get)
        {
        }
        /// <summary>
        /// 设备ID
        /// </summary>
        public string Device_id { get; set; }

        private string datastream_id;
        /// <summary>
        /// 数据流ID，多个id之间用逗号分开，缺省时为查询所有数据流
        /// </summary>
        public string DatastreamId
        {
            get { return datastream_id; }
            set
            {
                PropertiesAdd(nameof(datastream_id), value);
                datastream_id = value;
            }
        }

        private DateTime start;
        /// <summary>
        /// 提取数据点的开始时间，精确到秒
        /// </summary>
        public DateTime StartTime
        {
            get { return start; }
            set
            {
                PropertiesAdd(nameof(start), value.ToString("yyyy-MM-ddThh:mm:ss"));
                start = value;
            }
        }

        private DateTime end;
        /// <summary>
        /// 提取数据点的结束时间，精确到秒
        /// </summary>
        public DateTime EndTime
        {
            get { return end; }
            set
            {
                PropertiesAdd(nameof(end), value.ToString("yyyy-MM-ddThh:mm:ss"));
                end = value;
            }
        }

        private int duration;
        /// <summary>
        /// 查询时间区间，单位为秒
        /// </summary>
        public int Duration
        {
            get { return duration; }
            set
            {
                PropertiesAdd(nameof(duration), value.ToString());
                duration = value;
            }
        }

        private int limit;
        /// <summary>
        /// 限定本次请求最多返回的数据点数，默认100，范围为(0,6000]
        /// </summary>
        public int Limit
        {
            get { return limit; }
            set
            {
                PropertiesAdd(nameof(limit), value.ToString());
                limit = value;
            }
        }

        private string cursor;
        /// <summary>
        /// 指定本次请求继续从cursor位置开始提取数据
        /// </summary>
        public string Cursor
        {
            get { return cursor; }
            set
            {
                PropertiesAdd(nameof(cursor), value);
                cursor = value;
            }
        }


        private string sort;
        /// <summary>
        /// 时间排序方式，DESC：倒序，ASC：升序，默认为ASC
        /// </summary>
        public string Sort
        {
            get { return sort; }
            set
            {
                PropertiesAdd(nameof(sort), value);
                sort = value;
            }
        }


        protected override string BuildUrlPath()
        {
            string url = base.BuildUrlPath();
            return string.Format(url, Device_id);
        }
    }
}