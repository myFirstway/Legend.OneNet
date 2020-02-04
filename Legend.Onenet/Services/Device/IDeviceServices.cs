using Legend.Onenet.Request.Device;
using Legend.Onenet.Response.Device;
using System.Threading.Tasks;

namespace Legend.Onenet.Services
{
    public interface IDeviceServices
    {
        Task<AddDeviceResponse> AddDeviceAsync(AddDeviceRequest  addDeviceRequest);
        Task<DeleteDeviceResponse> DeleteDeviceAsync(DeleteDeviceRequest deleteDeviceRequest);
        Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest registerDeviceRequest);
        Task<SearchMutiDevicesResponse> SearchMutiDeviceAsync(SearchMutiDevicesRequest  searchMutiDevicesRequest);
        Task<SearchMutiDevicesStatusResponse> SearchMutiDevicesStatusAsync(SearchMutiDevicesStatusRequest searchMutiDevicesStatusRequest);
        Task<SearchSigleDeviceResponse> SearchSigleDeviceAsync(SearchSigleDeviceRequest searchSigleDeviceRequest );
        Task<UpdateDeviceResponse> UpdateDeviceAsync(UpdateDeviceRequest updateDeviceRequest);
    }
}
