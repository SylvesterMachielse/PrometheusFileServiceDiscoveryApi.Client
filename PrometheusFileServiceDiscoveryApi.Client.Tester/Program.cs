using System;
using System.Collections.Generic;
using PrometheusFileServiceDiscovery.Contracts.Models;

namespace PrometheusFileServiceDiscoveryApi.Client.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var client = new TargetsClient("http://localhost:9099");

            var target1 = CreateTargetModel("target1");
            var target2 = CreateTargetModel("target2");
            var target3 = CreateTargetModel("target3");

            client.Put(target1);
            client.Put(target2);
            client.Put(target3);
            client.Delete(target2.Targets[0]);

            target2.Labels = new Dictionary<string, string>() {
            {
                "target2label","target2value"
            }};

            client.Patch(target2);

            var targets = client.Get();

            Console.WriteLine(targets);

            Console.ReadKey();
        }

        private static TargetModel CreateTargetModel(string targetName)
        {
            var target1 = new TargetModel()
            {
                Targets = new List<string>()
                {
                    targetName
                }
            };
            return target1;
        }
    }
}
