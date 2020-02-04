namespace Legend.Onenet.Response.ApiKeyManage
{
    public class DeleteApiKeyResponse : ResponseBase<DeleteApiKeyResponseInfo>
    {

    }

    public class DeleteApiKeyResponseInfo
    {
        public string Trigger_id { get; set; }
    }
}
