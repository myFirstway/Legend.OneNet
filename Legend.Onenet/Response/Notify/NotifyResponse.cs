namespace Legend.Onenet.Response.Notify
{
    public class NotifyResponse
    {
        public Msg Msg { get; set; }
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
    public class Msg
    {
        /// <summary>
        /// 标识消息类型1：设备上传数据点消息2：设备上下线消息7：缓存命令下发后结果上报（仅支持NB设备）
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 设备ID
        /// </summary>
        public string Dev_id { get; set; }
        /// <summary>
        /// 数据流名称
        /// </summary>
        public string Ds_id { get; set; }
        /// <summary>
        /// 	平台时间戳,单位ms
        /// </summary>
        public long At { get; set; }
        /// <summary>
        /// 具体数据部分，为设备上传至平台或触发的相关数据
        /// </summary>
        public dynamic Value { get; set; }
        /// <summary>
        /// 设备上下线标识0：设备下线1：设备上线
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 设备登录协议类型1-EDP, 6-MODBUS, 7-MQTT, 10-NB-IoT
        /// </summary>
        public string Login_type { get; set; }
        /// <summary>
        /// 命令响应的类型1：设备收到cmd的ACK响应信息2：设备收到cmd的Confirm响应信息
        /// </summary>
        public int Cmd_type { get; set; }
        /// <summary>
        /// 命令ID
        /// </summary>
        public string Cmd_id { get; set; }
    }
}
