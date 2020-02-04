namespace Legend.Onenet.Response
{
    public class OneNetResponse
    {
        public int Errno { get; set; }
        public string Error { get; set; }
    }
    public class ResponseBase<T> : OneNetResponse
    {
        public T Data { get; set; }
    }
}
