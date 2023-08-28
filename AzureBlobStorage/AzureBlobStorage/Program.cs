using System;
using Azure.Storage.Blobs;

namespace AzureBlobStorage
{
    public class Program
    {
        
        private static string _connectionString = "DefaultEndpointsProtocol=https;" +
            "AccountName=stsollerspowershell;" +
            "AccountKey=bIddy5e7J0keJrTcGkCiHYKfokkxz7RaelBhFiaLxUQ5R7r7LQnZ3z4/Qh67mPICL8bTeK3S2xnh+AStNdU/QQ==;" +
            "EndpointSuffix=core.windows.net";
        private static string _containerName = "fellyka";
        static void Main(string[] args)
        {
            //Create a containner
            BlobServiceClient blobServiceClient = new BlobServiceClient(_connectionString);
            blobServiceClient.CreateBlobContainer(_containerName);
            Console.WriteLine("Container succesfully created!");
        }
    }
    
}