using System;
using System.Collections.Generic;
using Amazon;
using Amazon.CodeCommit;
using Amazon.CodeCommit.Model;
using Newtonsoft.Json;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                System.Console.WriteLine("Parameters: <CodeCommit Repository Name> <AWS Region>");
                Environment.Exit(1);
            }
            var repositoryName = args[0];
            var awsRegion = RegionEndpoint.GetBySystemName(args[1]);
            try 
            {
                using (var ccClient = new AmazonCodeCommitClient(awsRegion))
                {
                    var triggerRequest = new PutRepositoryTriggersRequest(){
                        RepositoryName = repositoryName,
                        Triggers = new List<RepositoryTrigger>()
                    };
                    var response = ccClient.PutRepositoryTriggersAsync(triggerRequest).GetAwaiter().GetResult();
                    System.Console.WriteLine(JsonConvert.SerializeObject(response));
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }
    }
}
