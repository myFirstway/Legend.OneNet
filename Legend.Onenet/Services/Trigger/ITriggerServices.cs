using Legend.Onenet.Request.Trigger;
using Legend.Onenet.Response.Trigger;
using System.Threading.Tasks;

namespace Legend.Onenet.Services
{
    public interface ITriggerServices
    {
        Task<AddTriggerResponse> PublishTopicAsync(AddTriggerRequest addTriggerRequest);
        Task<DeleteTriggerResponse> DeleteTriggerAsync(DeleteTriggerRequest deleteTriggerRequest);
        Task<SearchTriggerResponse> SearchTriggerAsync(SearchTriggerRequest searchTriggerRequest);
        Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest updateTriggerRequest);
    }
}
