using Legend.Onenet.Request.DataManage;
using Legend.Onenet.Response.DataManage;
using System.Threading.Tasks;

namespace Legend.Onenet.Services
{
    public interface IDataManageServices
    {
        Task<BatchSearchDeviceHistoryDataResponse> BatchSearchDeviceHistoryDataAsync(BatchSearchDeviceHistoryDataRequest batchSearchDeviceHistoryDataRequest);
        Task<DownloadFileResponse> DownloadFileAsync(DownloadFileRequest downloadFileRequest);
        Task<SearchDeviceHistoryResponse> SearchDeviceHistoryDataAsync(SearchDeviceHistoryDataRequest searchDeviceHistoryDataRequest);
        Task<UploadDataPointResponse> UploadDataPointAsync(UploadDataPointRequest uploadDataPointRequest);
        Task<UploadFileResponse> UploadFileAsync(UploadFileRequest uploadFileRequest);
    }
}
