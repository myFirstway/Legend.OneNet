using System.Collections.Generic;

namespace Legend.Onenet.Response.DataStreamManage
{
    public class BatchSearchDataStreamResponse : ResponseBase<BatchSearchDataStreamResponseInfo>
    {

    }
    public class BatchSearchDataStreamResponseInfo
    {
        public List<SearchDataStreamResponseInfo> SearchDataStreamResponseInfo { get; set; }
    }
}
