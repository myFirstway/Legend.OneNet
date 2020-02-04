using System.Collections.Generic;

namespace Legend.Onenet.Response.Trigger
{
    public class SearchTriggerResponse : ResponseBase<SearchTriggerResponseInfo>
    {

    }

    public class SearchTriggerResponseInfo
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Ds_id { get; set; }
        public string Url { get; set; }
        public string Create_time { get; set; }
        public List<string> Dev_ids { get; set; }
        public dynamic Threshold { get; set; }
    }
}
