using System.Collections.Generic;
using System.Threading.Tasks;

namespace Legend.Onenet.Services
{
    public class ApiKeyTokenService : ITokenService
    {
        public async Task<KeyValuePair<string, string>> AssembleToken(object sender)
        {
            OnenetOptions onenetOptions = null;
            if (sender is OnenetOptions)
            {
                onenetOptions = sender as OnenetOptions;
            }
            if(onenetOptions.AuthenticationType == AuthenticationType.Ordinary)
            {
                return await Task.FromResult(new KeyValuePair<string, string>("api-key", onenetOptions.Apikey));
            }
            throw new System.Exception("鉴权方式错误");
        }
    }
}
