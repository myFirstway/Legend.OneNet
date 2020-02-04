using System.Collections.Generic;
using System.Net.Http;

namespace Legend.Onenet.Request.Trigger
{
    public class SearchTriggerRequest : RequestBase
    {
        public SearchTriggerRequest() : base(Constants.SearchTrigger, HttpMethod.Get)
        {
        }
        public SearchTriggerRequest(OnenetOptions onenetOptions) : base(Constants.SearchTrigger, onenetOptions, HttpMethod.Get)
        {
        }

        /// <summary>
        /// 触发器ID
        /// </summary>
        public string Trigger_id { get; set; }

        protected override string BuildUrlPath()
        {
            string url = base.BuildUrlPath();
            return string.Format(url, Trigger_id);
        }
    }
}
