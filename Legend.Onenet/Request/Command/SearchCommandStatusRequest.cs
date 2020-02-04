using System.Net.Http;

namespace Legend.Onenet.Request.Command
{
    public class SearchCommandStatusRequest : RequestBase
    {
        public SearchCommandStatusRequest() : base(Constants.SearchCommandStatus, HttpMethod.Get)
        {
        }

        public SearchCommandStatusRequest(OnenetOptions onenetOptions) : base(Constants.SearchCommandStatus, onenetOptions, HttpMethod.Get)
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
