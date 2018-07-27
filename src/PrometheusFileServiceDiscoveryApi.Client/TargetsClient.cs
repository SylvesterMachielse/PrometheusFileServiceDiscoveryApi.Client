using PrometheusFileServiceDiscovery.Contracts.Models;
using RestSharp;

namespace PrometheusFileServiceDiscoveryApi.Client
{
    public class TargetsClient : ITargetsClient
    {
        private readonly IRestClient _restClient;
        public TargetsClient(string baseUrl)
        {
            _restClient = new RestClient(baseUrl);
        }

        public IRestResponse<TargetsModel> Get()
        {
            var result = _restClient.Get<TargetsModel>(new RestRequest("api/v1/targets"));

            return result;
        }

        public IRestResponse Put(TargetModel model)
        {
            var restRequest = new RestRequest("api/v1/targets");
            restRequest.AddJsonBody(model);

            var result = _restClient.Put<TargetsModel>(restRequest);

            return result;
        }

        public IRestResponse Delete(string targetName)
        {
            var restRequest = new RestRequest($"api/v1/targets/{targetName}");
            var result = _restClient.Delete(restRequest);

            return result;
        }

        public IRestResponse Patch(TargetModel model)
        {
            var restRequest = new RestRequest($"api/v1/targets/{model.Targets[0]}");
            restRequest.AddJsonBody(model);

            var result = _restClient.Patch(restRequest);

            return result;
        }
    }
}
