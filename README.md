# PrometheusFileServiceDiscoveryApi.Client

This is a .NetStandard Class library that serves as a client for PrometheusFileServiceDiscoveryApi

# Installation 
`Install-Package PrometheusFileServiceDiscoveryApi.Client -Version 2.0.1`

# Usage

```csharp
   public interface ITargetsClient
    {
        IRestResponse<TargetsModel> Get(string group);
        IRestResponse Put(string group, TargetModel model);
        IRestResponse Delete(string group, string targetName);
        IRestResponse Patch(string group, TargetModel model);
    }
```

Pass the baseurl of the client as a constructor parameter:
```csharp
var targetsClient = new TargetsClient("http://localhost:6000");
```

