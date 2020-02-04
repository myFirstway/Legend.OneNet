using System.Collections.Generic;
using System.Threading.Tasks;

namespace Legend.Onenet.Services
{
    public interface ITokenService
    {
        Task<KeyValuePair<string,string>> AssembleToken(object sender);
    }
}
