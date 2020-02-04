using System;
using System.Net.Http;

namespace Legend.Onenet.Request.Command
{
    public class SearchCommandHistoryRequest : RequestBase
    {
        public SearchCommandHistoryRequest() : base(Constants.SearchCommandHistory, HttpMethod.Get)
        {
        }
        public SearchCommandHistoryRequest(OnenetOptions onenetOptions) : base(Constants.SearchCommandHistory, onenetOptions, HttpMethod.Get)
        {
        }
        public string Device_id { get; set; }

        private DateTime start;
        /// <summary>
        /// 查询的开始时间，格式示例：2015-01-10T08:00:35
        /// </summary>
        public DateTime Start
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
        /// 查询的开始时间，格式示例：2015-01-10T08:00:35
        /// </summary>
        public DateTime End
        {
            get { return end; }
            set
            {
                PropertiesAdd(nameof(end), value.ToString("yyyy-MM-ddThh:mm:ss"));
                end = value;
            }
        }

        private int page;
        /// <summary>
        /// 指定页码
        /// </summary>
        public int Page
        {
            get { return page; }
            set
            {
                PropertiesAdd(nameof(page), value.ToString());
                page = value;
            }
        }

        private int per_page;
        /// <summary>
        /// 指定页码
        /// </summary>
        public int Per_page
        {
            get { return per_page; }
            set
            {
                PropertiesAdd(nameof(per_page), value.ToString());
                per_page = value;
            }
        }

        protected override string BuildUrlPath()
        {
            string url = base.BuildUrlPath();
            return string.Format(url, Device_id);
        }
    }
}
