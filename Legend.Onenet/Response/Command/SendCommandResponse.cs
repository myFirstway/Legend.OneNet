namespace Legend.Onenet.Response.Command
{
    public class SendCommandResponse : ResponseBase<SendCommandResponseInfo>
    {

    }

    public class SendCommandResponseInfo
    {
        public string Cmd_uuid { get; set; }
    }
}
