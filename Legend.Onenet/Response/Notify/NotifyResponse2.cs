using System.Collections.Generic;

namespace Legend.Onenet.Response.Notify
{
    public class NotifyResponse2
    {
        public IList<Msg> Msg { get; set; }
        /// <summary>
        /// 消息摘要
        /// </summary>
        public string Msg_signature { get; set; }
        /// <summary>
        /// 用于计算消息摘要的随机串
        /// </summary>
        public string Nonce { get; set; }
        /// <summary>
        /// 加密密文消息体,对明文JSON串（msg字段）的加密
        /// </summary>
        public string Enc_msg { get; set; }
    }
}
