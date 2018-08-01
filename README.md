# PrometheusFileServiceDiscoveryApi.Client

This is a .NetStandard Class library that serves as a client for PrometheusFileServiceDiscoveryApi

# Installation 
`Install-Package PrometheusFileServiceDiscoveryApi.Client -Version 1.0.0`

# Usage

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

