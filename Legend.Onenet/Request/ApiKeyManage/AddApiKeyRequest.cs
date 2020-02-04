using System.Collections.Generic;
using System.Net.Http;

namespace Legend.Onenet.Request.ApiKeyManage
{
    public class AddApiKeyRequest : RequestBase
    {
        public AddApiKeyRequest() : base(Constants.AddApiKey, HttpMethod.Post)
        {
        }
        public AddApiKeyRequest(OnenetOptions onenetOptions) : base(Constants.AddApiKey, onenetOptions, HttpMethod.Post)
        {
        }
        public string Title { get; set; }
        public List<Permission> Permissions { get; set; }
    }
}

public class Permission
{
    public List<string> Access_methods { get; set; }
    public List<Resource> Resources { get; set; }
}

public class Resource
{
    public string Dev_id { get; set; }
    public string Ds_id { get; set; }
}
