namespace Legend.Onenet.Response.ApiKeyManage
{
    public class UpdateApiKeyResponse : ResponseBase<UpdateApiKeyResponseInfo>
    {

    }

    public class UpdateApiKeyResponseInfo
    {
        public string Trigger_id { get; set; }
    }
}
