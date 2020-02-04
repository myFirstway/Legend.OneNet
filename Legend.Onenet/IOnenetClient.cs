using Legend.Onenet.Request;
using Legend.Onenet.Response;
using System.Threading.Tasks;

namespace Legend.Onenet
{
    public interface IOnenetClient
    {
        Task<T> ExecuteAsync<T>(RequestBase requestBase) where T : OneNetResponse, new();
    }
}