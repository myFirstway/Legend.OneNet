using System.Collections.Generic;
using System.Net.Http;

namespace Legend.Onenet.Request.Trigger
{
    public class DeleteTriggerRequest : RequestBase
    {
        public DeleteTriggerRequest() : base(Constants.DeleteTrigger, HttpMethod.Delete)
        {
        }
        public DeleteTriggerRequest(OnenetOptions onenetOptions) : base(Constants.DeleteTrigger, onenetOptions, HttpMethod.Delete)
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
