# PrometheusFileServiceDiscoveryApi.Client

This is an .NetStandard Class library that serves as a client for PrometheusFileServiceDiscoveryApi

```csharp
public interface ITargetsClient
{
  IRestResponse<TargetsModel> Get();
  IRestResponse Put(TargetModel model);
  IRestResponse Delete(string targetName);
  IRestResponse Patch(TargetModel model);
}
```

Pass the baseurl of the client as a constructor parameter:
```csharp
var targetsClient = new TargetsClient("http://localhost:9099");
```

