using System;
using System.Net.Http;

namespace Legend.Onenet.Request.Device
{
    /// <summary>
    /// 批量查询设备信息
    /// </summary>
    public class SearchMutiDevicesRequest : RequestBase
    {
        public SearchMutiDevicesRequest() : base(Constants.SearchMutiDevices, HttpMethod.Get)
        {
        }
        public SearchMutiDevicesRequest(OnenetOptions onenetOptions) : base(Constants.SearchMutiDevices, onenetOptions, HttpMethod.Get)
        {
        }
        private string key_words;
        /// <summary>
        /// 匹配关键字，从id和title字段中左匹配
        /// </summary>
        public string Key_words
        {
            get { return key_words; }
            set
            {
                PropertiesAdd(nameof(key_words), value);
                key_words = value;
            }
        }

        private string auth_info;
        /// <summary>
        /// 鉴权信息
        /// </summary>
        public string Auth_info
        {
            get { return auth_info; }
            set
            {
                PropertiesAdd(nameof(auth_info), value);
                auth_info = value;
            }
        }


        private string tag;
        /// <summary>
        /// 设备标签
        /// </summary>
        public string Tag
        {
            get { return tag; }
            set
            {
                PropertiesAdd(nameof(tag), value);
                tag = value;
            }
        }


        private bool online;
        /// <summary>
        /// 设备在线状态
        /// </summary>
        public bool Online
        {
            get { return online; }
            set
            {
                PropertiesAdd(nameof(online), value ? "true" : "false");
                online = value;
            }
        }

        private bool @private;
        /// <summary>
        /// 设备私密性
        /// </summary>
        public bool Private
        {
            get { return @private; }
            set
            {
                PropertiesAdd("private", value ? "true" : "false");
                @private = value;
            }
        }

        private int page;
        /// <summary>
        /// 指定页码，最大页数为10000
        /// </summary>
        public int Page
        {
            get { return page; }
            set
            {
                if (value > 10000)
                {
                    value = 10000;
                }
                PropertiesAdd(nameof(page), value.ToString());
                page = value;
            }
        }

        private int per_page;
        /// <summary>
        /// 指定每页输出设备个数，默认30，最多100
        /// </summary>
        public int Per_page
        {
            get { return per_page; }
            set
            {
                if (value > 100)
                {
                    value = 100;
                }
                PropertiesAdd(nameof(per_page), value.ToString());
                per_page = value;
            }
        }

        private string device_id;
        /// <summary>
        /// 指定设备ID，多个用逗号分隔，最多100个
        /// </summary>
        public string Device_id
        {
            get { return device_id; }
            set
            {
                PropertiesAdd(nameof(device_id), value.ToString());
                device_id = value;
            }
        }

        private DateTime begin;
        /// <summary>
        /// 	起始时间，北京时间，示例：2016-06-20
        /// </summary>
        public DateTime Begin
        {
            get { return begin; }
            set
            {
                PropertiesAdd(nameof(begin), value.ToString("yyyy-MM-dd"));
                begin = value;
            }
        }

        private DateTime end;
        /// <summary>
        /// 结束时间，北京时间，示例：2016-06-20
        /// </summary>
        public DateTime End
        {
            get { return end; }
            set
            {
                PropertiesAdd(nameof(end), value.ToString("yyyy-MM-dd"));
                end = value;
            }
        }

    }
}
