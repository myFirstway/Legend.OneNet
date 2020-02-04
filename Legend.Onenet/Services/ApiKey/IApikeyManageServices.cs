using Legend.Onenet.Request.ApiKeyManage;
using Legend.Onenet.Response.ApiKeyManage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Legend.Onenet.Services
{
    public interface IApikeyManageServices
    {
        Task<AddApiKeyResponse> AddApiKeyAsync(AddApiKeyRequest addApiKeyRequest);
        Task<DeleteApiKeyResponse> DeleteApiKeyAsync(DeleteApiKeyRequest deleteApiKeyRequest);
        Task<SearchApiKeyResponse> SearchMutiApiKeyAsync(SearchApiKeyRequest searchApiKeyRequest); 
        Task<UpdateApiKeyResponse> RegisterApiKeyAsync(UpdateApiKeyRequest updateApiKeyRequest);
    }
}
