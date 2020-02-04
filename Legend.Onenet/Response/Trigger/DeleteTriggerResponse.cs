namespace Legend.Onenet.Response.Trigger
{
    public class DeleteTriggerResponse : ResponseBase<DeleteTriggerResponseInfo>
    {

    }

    public class DeleteTriggerResponseInfo
    {
        public string Trigger_id { get; set; }
    }
}
