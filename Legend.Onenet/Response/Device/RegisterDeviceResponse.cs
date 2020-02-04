using System;
using System.Collections.Generic;
using System.Text;

namespace Legend.Onenet.Response.Device
{
    public class RegisterDeviceResponse : ResponseBase<RegisterDeviceResponseInfo>
    {

    }

    public class RegisterDeviceResponseInfo
    {
        public string Device_id { get; set; }
        public string Key { get; set; }
    }
}
