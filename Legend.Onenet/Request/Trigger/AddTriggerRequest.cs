using System.Collections.Generic;
using System.Net.Http;

namespace Legend.Onenet.Request.Trigger
{
    public class AddTriggerRequest : RequestBase
    {
        public AddTriggerRequest() : base(Constants.AddTrigger, HttpMethod.Post)
        {
        }
        public AddTriggerRequest(OnenetOptions onenetOptions) : base(Constants.AddTrigger, onenetOptions, HttpMethod.Post)
        {
        }
        /// <summary>
        /// 触发器名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 数据流名称
        /// </summary>
        public string Ds_id { get; set; }

        /// <summary>
        /// 设备ID，缺省时默认为全部设备
        /// </summary>
        public List<string> Dev_ids { get; set; }

        /// <summary>
        /// 告警通知地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 触发条件，见type说明列表
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 注：
        /// 1)type为大小等于等比较类型时，threshold必须为数值
        /// 2)type为inout时，threshold设置为{“lolmt”:40, “uplmt”:52}，表示数据流的值首次进入或离开闭区间[40,52]时触发；
        /// 3)type为exp时,threshold设置为字符串类型的条件表达式，$val[0]表示第一个数据流的当前值，$val[1]为第二个…。
        /// 4)type为change时，threshold 参数不用传递；当上传的值有改变时触发告警。
        /// 5)type为frozen时，threshold 为数值，指定多少秒内未上报数据触发告警，同时被监控对象进入frozen状态。
        /// 6)type为live时，threshold不用传递；被监控对象在frozen状态下收到上报的数据点时，触发告警。
        /// </summary>
        public object Threshold { get; set; }
    }
}
