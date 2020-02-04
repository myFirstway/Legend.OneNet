using System.Net.Http;

namespace Legend.Onenet.Request.DataManage
{
    public class UploadFileRequest : RequestBase
    {
        public UploadFileRequest() : base(Constants.UploadFile, HttpMethod.Post)
        {
        }
        public UploadFileRequest(OnenetOptions onenetOptions) : base(Constants.UploadFile, onenetOptions, HttpMethod.Post)
        {
        }

        private string device_id;
        /// <summary>
        /// 数据所属设备
        /// </summary>
        public string Device_id
        {
            get { return device_id; }
            set
            {
                PropertiesAdd(nameof(device_id), value);
                device_id = value;
            }
        }

        private string datastream_id;
        /// <summary>
        /// 该数据所属已经存在的数据流或者数据流模板名称
        /// </summary>
        public string Datastream_id
        {
            get { return datastream_id; }
            set
            {
                PropertiesAdd(datastream_id, value);
                datastream_id = value;
            }
        }


        private string desc;
        /// <summary>
        /// 文件描述
        /// </summary>
        public string Desc
        {
            get { return desc; }
            set
            {
                PropertiesAdd(nameof(desc), value);
                desc = value;
            }
        }

        public void BuildHttpContent(HttpContent httpContent)
        {
            _httpRequestMessage.Content = httpContent;
        }
    }
}
