namespace Legend.Onenet.Response.Command
{
    public class SearchCommandStatusResponse : ResponseBase<SendCommandResponseInfo>
    {

    }

    public class SearchCommandStatusResponseInfo
    {
        public int Status { get; set; }
        public string Desc { get; set; }
    }
}
