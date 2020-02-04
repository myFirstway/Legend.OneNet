using Legend.Onenet.Request.Command;
using Legend.Onenet.Response.Command;
using System.Threading.Tasks;

namespace Legend.Onenet.Services
{
    public class CommandServices : ICommandServices
    {
        private readonly IOnenetClient _onenetClient;
        public CommandServices(IOnenetClient onenetClient)
        {
            _onenetClient = onenetClient;
        }
        public async Task<SearchCommandHistoryResponse> SearchCommandHistory(SearchCommandHistoryRequest searchCommandHistoryRequest)
        {
            return await _onenetClient.ExecuteAsync<SearchCommandHistoryResponse>(searchCommandHistoryRequest);
        }

        public async Task<SearchCommandStatusResponse> SearchCommandStatus(SearchCommandHistoryRequest searchCommandStatusResponse)
        {
            return await _onenetClient.ExecuteAsync<SearchCommandStatusResponse>(searchCommandStatusResponse);
        }

        public async Task<SendCommandResponse> SendCommand(SendCommandRequest sendCommandRequest)
        {
            return await _onenetClient.ExecuteAsync<SendCommandResponse>(sendCommandRequest);
        }
    }
}
