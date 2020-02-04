using Newtonsoft.Json;
using System.Net.Http;

namespace Legend.Onenet.Request.Device
{
    public class RegisterDeviceRequest : RequestBase
    {
        public RegisterDeviceRequest() : base(Constants.RegisterDevice, HttpMethod.Post)
        {
        }
        public RegisterDeviceRequest(OnenetOptions onenetOptions) : base(Constants.RegisterDevice, onenetOptions, HttpMethod.Post)
        {
        }
        private string register_code;
        /// <summary>
        /// 注册码，产品下唯一
        /// </summary>
        [JsonIgnore]
        public string Register_code
        {
            get { return register_code; }
            set
            {
                PropertiesAdd(nameof(register_code), value);
                register_code = value;
            }
        }

        public string Sn { get; set; }
        public string Mac { get; set; }
        public string Title { get; set; }
    }
}
