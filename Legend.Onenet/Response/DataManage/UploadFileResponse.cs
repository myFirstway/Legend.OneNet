namespace Legend.Onenet.Response.DataManage
{
    public class UploadFileResponse : ResponseBase<UploadFileResponseInfo>
    {

    }

    public class UploadFileResponseInfo
    {
        /// <summary>
        /// 二进制数据索引号，可以作为参数用于获取文件API
        /// </summary>
        public string Index { get; set; }
    }
}
