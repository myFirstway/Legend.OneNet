using Legend.Onenet.Request.Device;
using Legend.Onenet.Response.Device;
using System.Threading.Tasks;

namespace Legend.Onenet.Services
{
    public class DeviceServices : IDeviceServices
    {
        private readonly IOnenetClient _onenetClient;
        public DeviceServices(IOnenetClient onenetClient)
        {
            _onenetClient = onenetClient;
        }
        public async Task<AddDeviceResponse> AddDeviceAsync(AddDeviceRequest addDeviceRequest)
        {
            return await _onenetClient.ExecuteAsync<AddDeviceResponse>(addDeviceRequest);
        }

        public async Task<DeleteDeviceResponse> DeleteDeviceAsync(DeleteDeviceRequest deleteDeviceRequest)
        {
            return await _onenetClient.ExecuteAsync<DeleteDeviceResponse>(deleteDeviceRequest);
        }

        public async Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest registerDeviceRequest)
        {
            return await _onenetClient.ExecuteAsync<RegisterDeviceResponse>(registerDeviceRequest);
        }

        public async Task<SearchMutiDevicesResponse> SearchMutiDeviceAsync(SearchMutiDevicesRequest searchMutiDevicesRequest)
        {
            return await _onenetClient.ExecuteAsync<SearchMutiDevicesResponse>(searchMutiDevicesRequest);
        }

        public async Task<SearchMutiDevicesStatusResponse> SearchMutiDevicesStatusAsync(SearchMutiDevicesStatusRequest searchMutiDevicesStatusRequest)
        {
            return await _onenetClient.ExecuteAsync<SearchMutiDevicesStatusResponse>(searchMutiDevicesStatusRequest);
        }

        public async Task<SearchSigleDeviceResponse> SearchSigleDeviceAsync(SearchSigleDeviceRequest searchSigleDeviceRequest)
        {
            return await _onenetClient.ExecuteAsync<SearchSigleDeviceResponse>(searchSigleDeviceRequest);
        }

        public async Task<UpdateDeviceResponse> UpdateDeviceAsync(UpdateDeviceRequest updateDeviceRequest)
        {
            return await _onenetClient.ExecuteAsync<UpdateDeviceResponse>(updateDeviceRequest);
        }
    }
}
