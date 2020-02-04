namespace Legend.Onenet.Response.DataStreamManage
{
    public class SearchDataStreamResponse : ResponseBase<SearchDataStreamResponseInfo>
    {

    }
    public class SearchDataStreamResponseInfo
    {
        /// <summary>
        /// 数据流ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 数据流创建时间
        /// </summary>
        public string Create_time { get; set; }
        /// <summary>
        /// 最新数据上传时间
        /// </summary>
        public string Update_at { get; set; }
        /// <summary>
        /// 最新数据点string/int/json...
        /// </summary>
        public dynamic Current_value { get; set; }
    }
}
