using Legend.Onenet.Request.Trigger;
using Legend.Onenet.Response.Trigger;
using System.Threading.Tasks;

namespace Legend.Onenet.Services
{
    public class TriggerServices : ITriggerServices
    {
        private readonly IOnenetClient _onenetClient;
        public TriggerServices(IOnenetClient onenetClient)
        {
            _onenetClient = onenetClient;
        }
        public async Task<DeleteTriggerResponse> DeleteTriggerAsync(DeleteTriggerRequest deleteTriggerRequest)
        {
            return await _onenetClient.ExecuteAsync<DeleteTriggerResponse>(deleteTriggerRequest);
        }

        public async Task<AddTriggerResponse> PublishTopicAsync(AddTriggerRequest addTriggerRequest)
        {
            return await _onenetClient.ExecuteAsync<AddTriggerResponse>(addTriggerRequest);
        }

        public async Task<SearchTriggerResponse> SearchTriggerAsync(SearchTriggerRequest searchTriggerRequest)
        {
            return await _onenetClient.ExecuteAsync<SearchTriggerResponse>(searchTriggerRequest);
        }

        public async Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest updateTriggerRequest)
        {
            return await _onenetClient.ExecuteAsync<UpdateTriggerResponse>(updateTriggerRequest);
        }
    }
}
