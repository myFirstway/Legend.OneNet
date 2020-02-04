using System.Collections.Generic;

namespace Legend.Onenet.Response.ApiKeyManage
{
    public class SearchApiKeyResponse : ResponseBase<SearchApiKeyResponseInfo>
    {

    }

    public class SearchApiKeyResponseInfo
    {
        public int Per_page { get; set; }
        public int Total_count { get; set; }
        public List<ApiKey> Keys { get; set; }
        public int Page { get; set; }
    }
}

public class ApiKey
{
    public string Title { get; set; }
    public string Create_time { get; set; }
    public string Key { get; set; }
    public List<Permission> Permissions { get; set; }
}

