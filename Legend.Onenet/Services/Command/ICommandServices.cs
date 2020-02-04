using Legend.Onenet.Request.Command;
using Legend.Onenet.Response.Command;
using System.Threading.Tasks;

namespace Legend.Onenet.Services
{
    public interface ICommandServices
    {
        Task<SearchCommandHistoryResponse> SearchCommandHistory(SearchCommandHistoryRequest searchCommandHistoryRequest);
        Task<SearchCommandStatusResponse> SearchCommandStatus(SearchCommandHistoryRequest searchCommandStatusResponse);
        Task<SendCommandResponse> SendCommand(SendCommandRequest sendCommandRequest);
    }
}
