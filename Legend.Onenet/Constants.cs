namespace Legend.Onenet
{
    public class Constants
    {
        public static string BaseUrl { get; } = "http://api.heclouds.com/";

        #region 设备（device）

        /// <summary>
        /// 添加设备
        /// </summary>
        public static string AddDevice = $"{BaseUrl}devices";

        /// <summary>
        /// 注册设备
        /// </summary>
        public static string RegisterDevice = $"{BaseUrl}register_de";

        /// <summary>
        /// 更新设备
        /// </summary>
        public static string UpdateDevice = $"{BaseUrl}devices/{{0}}";

        /// <summary>
        /// 查询设备详情
        /// </summary>
        public static string SearchSigleDevice = $"{BaseUrl}devices/{{0}}";

        /// <summary>
        /// 批量查询设备详情
        /// </summary>
        public static string SearchMutiDevices = $"{BaseUrl}devices";

        /// <summary>
        /// 批量查询设备状态
        /// </summary>
        public static string SearchMutiDevicesStatus = $"{BaseUrl}devices/status";

        /// <summary>
        /// 删除设备
        /// </summary>
        public static string DeleteDevice = $"{BaseUrl}devices/{{0}}";

        #endregion

        #region 命令

        /// <summary>
        /// 发送命令
        /// </summary>
        public static string SendCommand = $"{BaseUrl}cmds";

        /// <summary>
        /// 查询命令状态
        /// </summary>
        public static string SearchCommandStatus = $"{BaseUrl}cmds/{{0}}";

        /// <summary>
        /// 查询命令响应
        /// </summary>
        public static string SearchCommandResp = $"{BaseUrl}cmds/{{0}}/resp";

        /// <summary>
        /// 查询历史命令
        /// </summary>
        public static string SearchCommandHistory = $"{BaseUrl}cmds/history/{{0}}";

        #endregion

        #region 数据流

        /// <summary>
        /// 添加数据流
        /// </summary>
        public static string AddDataStream = $"{BaseUrl}/devices/{{0}}/datastreams";

        /// <summary>
        /// 更新数据流
        /// </summary>
        public static string UpdateDataStream = $"{BaseUrl}/devices/{{0}}/datastreams/{{1}}";

        /// <summary>
        /// 查询数据流
        /// </summary>
        public static string SearchDataStream = $"{BaseUrl}/devices/{{0}}/datastreams/{{1}}";

        /// <summary>
        /// 批量查询数据流
        /// </summary>
        public static string BatchSearchDataStream = $"{BaseUrl}/devices/{{0}}/datastreams";

        /// <summary>
        /// 删除数据流
        /// </summary>
        public static string DeleteDataStream = $"{BaseUrl}/devices/{{0}}/datastreams/{{1}}";

        #endregion

        #region 数据管理

        /// <summary>
        /// 查询设备历史数据
        /// </summary>
        public static string SearchDeviceHistoryData = $"{BaseUrl}/devices/{{0}}/datapoints";

        /// <summary>
        /// 批量查询历史数据
        /// </summary>
        public static string BatchSearchDeviceHistoryData = $"{BaseUrl}/devices/datapoints";

        /// <summary>
        /// 上传数据点
        /// </summary>
        public static string UploadDataPoint = $"{BaseUrl}/devices/{{0}}/datapoints";

        /// <summary>
        /// 上传文件
        /// </summary>
        public static string UploadFile = $"{BaseUrl}/bindata";

        /// <summary>
        /// 获取文件
        /// </summary>
        public static string DownloadFile = $"{BaseUrl}/bindata/{{0}}";

        #endregion

        #region 触发器

        /// <summary>
        /// 添加触发器
        /// </summary>
        public static string AddTrigger = $"{BaseUrl}/triggers";

        /// <summary>
        /// 更新触发器
        /// </summary>
        public static string UpdateTrigger = $"{BaseUrl}/triggers/{{0}}";

        /// <summary>
        /// 查询触发器
        /// </summary>
        public static string SearchTrigger = $"{BaseUrl}/triggers/{{0}}";

        /// <summary>
        /// 删除触发器
        /// </summary>
        public static string DeleteTrigger = $"{BaseUrl}/triggers/{{0}}";

        #endregion

        #region apikey

        /// <summary>
        /// 新增apikey
        /// </summary>
        public static string AddApiKey = $"{BaseUrl}/keys";

        /// <summary>
        /// 更新apikey
        /// </summary>
        public static string UpdateApiKey = $"{BaseUrl}/keys/{{0}}";

        /// <summary>
        /// 查询apikey
        /// </summary>
        public static string SearchApiKey = $"{BaseUrl}/keys";

        /// <summary>
        /// 删除apikey
        /// </summary>
        public static string DeleteApiKey = $"{BaseUrl}/keys/{{0}}";

        #endregion

        #region Topic

        /// <summary>
        /// 发布消息
        /// </summary>
        public static string PublishTopic = $"{BaseUrl}/mqtt";

        /// <summary>
        /// 查询订阅topic的设备
        /// </summary>
        public static string SearchSubscribeTopicDevice = $"{BaseUrl}/mqtt/topic_device";

        /// <summary>
        /// 查询设备订阅的topic
        /// </summary>
        public static string SearchDeviceSubscribeTopic = $"{BaseUrl}/mqtt/device_topic/{{0}}";

        /// <summary>
        /// 查询产品的topic
        /// </summary>
        public static string SearchProductTopic = $"{BaseUrl}/mqtt/topic";

        #endregion
    }
}
