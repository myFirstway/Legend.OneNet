using Legend.Onenet.Request.DataManage;
using Legend.Onenet.Response.DataManage;
using System.Threading.Tasks;

namespace Legend.Onenet.Services
{
    public class DataManageServices : IDataManageServices
    {
        private readonly IOnenetClient _onenetClient;
        public DataManageServices(IOnenetClient onenetClient)
        {
            _onenetClient = onenetClient;
        }
        public async Task<BatchSearchDeviceHistoryDataResponse> BatchSearchDeviceHistoryDataAsync(BatchSearchDeviceHistoryDataRequest batchSearchDeviceHistoryDataRequest)
        {
            return await _onenetClient.ExecuteAsync<BatchSearchDeviceHistoryDataResponse>(batchSearchDeviceHistoryDataRequest);
        }

        public async Task<DownloadFileResponse> DownloadFileAsync(DownloadFileRequest downloadFileRequest)
        {
            return await _onenetClient.ExecuteAsync<DownloadFileResponse>(downloadFileRequest);
        }

        public async Task<SearchDeviceHistoryResponse> SearchDeviceHistoryDataAsync(SearchDeviceHistoryDataRequest searchDeviceHistoryDataRequest)
        {
            return await _onenetClient.ExecuteAsync<SearchDeviceHistoryResponse>(searchDeviceHistoryDataRequest);
        }

        public async Task<UploadDataPointResponse> UploadDataPointAsync(UploadDataPointRequest uploadDataPointRequest)
        {
            return await _onenetClient.ExecuteAsync<UploadDataPointResponse>(uploadDataPointRequest);
        }

        public async Task<UploadFileResponse> UploadFileAsync(UploadFileRequest uploadFileRequest)
        {
            return await _onenetClient.ExecuteAsync<UploadFileResponse>(uploadFileRequest);
        }
    }
}
