namespace Legend.Onenet
{
    public class OnenetOptions
    {
        public AuthenticationType AuthenticationType { get; set; } = AuthenticationType.Ordinary;
        public string Apikey { get; set; }
        public string Version { get; set; } = "2018-10-31";
        public string Res { get; set; }
        public long Et { get; set; }
        public SignatureMethod Method { get; set; }
    }

    public enum AuthenticationType
    {
        Ordinary,
        Security
    }
    public enum SignatureMethod
    {
        Hmacmd5,
        Hmacsha1,
        Hmacsha256
    }
}
