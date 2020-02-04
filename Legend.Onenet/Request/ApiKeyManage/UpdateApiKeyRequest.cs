using System.Collections.Generic;
using System.Net.Http;

namespace Legend.Onenet.Request.ApiKeyManage
{
    public class UpdateApiKeyRequest : RequestBase
    {
        public UpdateApiKeyRequest() : base(Constants.UpdateApiKey, HttpMethod.Put)
        {
        }
        public UpdateApiKeyRequest(OnenetOptions onenetOptions) : base(Constants.UpdateApiKey, onenetOptions, HttpMethod.Put)
        {
        }

        public string Key { get; set; }
        public string Title { get; set; }
        public List<Permission> Permissions { get; set; }
        protected override string BuildUrlPath()
        {
            string url = base.BuildUrlPath();
            return string.Format(url, Key);
        }
    }
}
