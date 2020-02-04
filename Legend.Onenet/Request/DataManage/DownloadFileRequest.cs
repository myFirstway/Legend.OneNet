using System.Net.Http;

namespace Legend.Onenet.Request.DataManage
{
    public class DownloadFileRequest : RequestBase
    {
        public DownloadFileRequest() : base(Constants.DownloadFile, HttpMethod.Get)
        {
        }
        public DownloadFileRequest(OnenetOptions onenetOptions) : base(Constants.DownloadFile, onenetOptions, HttpMethod.Get)
        {
        }

        /// <summary>
        /// 文件索引
        /// </summary>
        public string Index { get; set; }

        protected override string BuildUrlPath()
        {
            string url = base.BuildUrlPath();
            return string.Format(url, Index);
        }
    }
}