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

            var client = new TargetsClient("http://localhost:6000");

            var target1 = CreateTargetModel("target1");
            var target2 = CreateTargetModel("target2");
            var target3 = CreateTargetModel("target3");

            client.Put("test",target1);
            client.Put("test",target2);
            client.Put("test",target3);
            client.Delete("test", target2.Targets[0]);

            target2.Labels = new Dictionary<string, string>() {
            {
                "target2label","target2value"
            }};

            client.Patch("test", target2);

            var targets = client.Get("test");

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
