using PrometheusFileServiceDiscovery.Contracts.Models;
using RestSharp;

namespace PrometheusFileServiceDiscoveryApi.Client
{
    public interface ITargetsClient
    {
        IRestResponse<TargetsModel> Get(string group);
        IRestResponse Put(string group, TargetModel model);
        IRestResponse Delete(string group, string targetName);
        IRestResponse Patch(string group, TargetModel model);
    }
}