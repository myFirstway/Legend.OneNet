namespace Legend.Onenet.Response.Command
{
    public class SearchCommandHistoryResponse : ResponseBase<SearchCommandHistoryResponseInfo>
    {

    }

    public class SearchCommandHistoryResponseInfo
    {
        public int Page { get; set; }
        public int Per_page { get; set; }
        public int Total_count { get; set; }
        public Item[] Items { get; set; }
    }

    public class Item
    {
        public string Cmd_uuid { get; set; }
        public int Device_id { get; set; }
        public string Expire_time { get; set; }
        public string Send_time { get; set; }
        public string Confirm_time { get; set; }
        public string Confirm_body { get; set; }
        public string Body { get; set; }
    }

}
