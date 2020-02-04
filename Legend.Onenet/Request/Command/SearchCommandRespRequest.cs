using System.Net.Http;

namespace Legend.Onenet.Request.Command
{
    /// <summary>
    /// 查询命令响应
    /// </summary>
    public class SearchCommandRespRequest : RequestBase
    {
        public SearchCommandRespRequest() : base(Constants.SearchCommandResp, HttpMethod.Get)
        {
        }

        public SearchCommandRespRequest(OnenetOptions onenetOptions) : base(Constants.SearchCommandResp, onenetOptions, HttpMethod.Get)
        {
        }
        public string Cmd_uuid { get; set; }

        protected override string BuildUrlPath()
        {
            string url = base.BuildUrlPath();
            return string.Format(url, Cmd_uuid);
        }
    }
}
