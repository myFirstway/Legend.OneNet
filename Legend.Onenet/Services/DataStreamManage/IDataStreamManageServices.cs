using Legend.Onenet.Request.DataStreamManage;
using Legend.Onenet.Response.DataStreamManage;
using System.Threading.Tasks;

namespace Legend.Onenet.Services
{
    public interface IDataStreamManageServices
    {
        Task<AddDataStreamResponse> AddDataStreamAsync(AddDataStreamRequest addDataStreamRequest);
        Task<BatchSearchDataStreamResponse> BatchSearchDataStreamAsync(BatchSearchDataStreamRequest batchSearchDataStreamRequest);
        Task<DeleteDataStreamResponse> DeleteDataStreamAsync(DeleteDataStreamRequest deleteDataStreamRequest);
        Task<SearchDataStreamResponse> SearchDataStreamAsync(SearchDataStreamRequest searchDataStreamRequest);
        Task<UpdateDataStreamResponse> UpdateDataStreamAsync(UpdateDataStreamRequest updateDataStreamRequest);
    }
}
