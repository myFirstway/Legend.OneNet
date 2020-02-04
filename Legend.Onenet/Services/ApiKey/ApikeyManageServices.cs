using Legend.Onenet.Request.ApiKeyManage;
using Legend.Onenet.Response.ApiKeyManage;
using System;
using System.Threading.Tasks;

namespace Legend.Onenet.Services
{
    public class ApikeyManageServices : IApikeyManageServices
    {
        private readonly IOnenetClient _onenetClient;
        public ApikeyManageServices(IOnenetClient onenetClient)
        {
            _onenetClient = onenetClient;
        }
        public async Task<AddApiKeyResponse> AddApiKeyAsync(AddApiKeyRequest addApiKeyRequest)
        {
            return await _onenetClient.ExecuteAsync<AddApiKeyResponse>(addApiKeyRequest);
        }

        public async Task<DeleteApiKeyResponse> DeleteApiKeyAsync(DeleteApiKeyRequest deleteApiKeyRequest)
        {
            return await _onenetClient.ExecuteAsync<DeleteApiKeyResponse>(deleteApiKeyRequest);
        }

        public async Task<UpdateApiKeyResponse> RegisterApiKeyAsync(UpdateApiKeyRequest updateApiKeyRequest)
        {
            return await _onenetClient.ExecuteAsync<UpdateApiKeyResponse>(updateApiKeyRequest);
        }

        public async Task<SearchApiKeyResponse> SearchMutiApiKeyAsync(SearchApiKeyRequest searchApiKeyRequest)
        {
            return await _onenetClient.ExecuteAsync<SearchApiKeyResponse>(searchApiKeyRequest);
        }
    }
}
