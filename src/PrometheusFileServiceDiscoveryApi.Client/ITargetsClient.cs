using PrometheusFileServiceDiscovery.Contracts.Models;
using RestSharp;

namespace PrometheusFileServiceDiscoveryApi.Client
{
    public interface ITargetsClient
    {
        IRestResponse<TargetsModel> Get();
        IRestResponse Put(TargetModel model);
        IRestResponse Delete(string targetName);
        IRestResponse Patch(TargetModel model);
    }
}