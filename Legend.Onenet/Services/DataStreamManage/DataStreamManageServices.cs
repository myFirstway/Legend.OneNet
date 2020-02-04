using Legend.Onenet.Request.DataStreamManage;
using Legend.Onenet.Response.DataStreamManage;
using System.Threading.Tasks;

namespace Legend.Onenet.Services.DataStreamManage
{
    public class DataStreamManageServices : IDataStreamManageServices
    {
        private readonly IOnenetClient _onenetClient;
        public DataStreamManageServices(IOnenetClient onenetClient)
        {
            _onenetClient = onenetClient;
        }
        public async Task<AddDataStreamResponse> AddDataStreamAsync(AddDataStreamRequest addDataStreamRequest)
        {
            return await _onenetClient.ExecuteAsync<AddDataStreamResponse>(addDataStreamRequest);
        }

        public async Task<BatchSearchDataStreamResponse> BatchSearchDataStreamAsync(BatchSearchDataStreamRequest batchSearchDataStreamRequest)
        {
            return await _onenetClient.ExecuteAsync<BatchSearchDataStreamResponse>(batchSearchDataStreamRequest);
        }

        public async Task<DeleteDataStreamResponse> DeleteDataStreamAsync(DeleteDataStreamRequest deleteDataStreamRequest)
        {
            return await _onenetClient.ExecuteAsync<DeleteDataStreamResponse>(deleteDataStreamRequest);
        }

        public async Task<SearchDataStreamResponse> SearchDataStreamAsync(SearchDataStreamRequest searchDataStreamRequest)
        {
            return await _onenetClient.ExecuteAsync<SearchDataStreamResponse>(searchDataStreamRequest);
        }

        public async Task<UpdateDataStreamResponse> UpdateDataStreamAsync(UpdateDataStreamRequest updateDataStreamRequest)
        {
            return await _onenetClient.ExecuteAsync<UpdateDataStreamResponse>(updateDataStreamRequest);
        }
    }
}
