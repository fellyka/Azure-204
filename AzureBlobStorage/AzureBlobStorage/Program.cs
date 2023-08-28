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
        private static string _fileName = "SqlBook";
        private static string _fileToUpload = @"D:\Books\Sql\SQL Server 2014 Development Essentials.pdf";
        static void Main(string[] args)
        {
            //Get reference to an existing container and blob
            BlobServiceClient blobServiceClient = new BlobServiceClient(_connectionString);
            BlobContainerClient _containerClient = blobServiceClient.GetBlobContainerClient(_containerName);
            BlobClient blobClient = _containerClient.GetBlobClient(_fileName);

            blobClient.Upload(_fileToUpload);
          

            Console.WriteLine("File succesfully uploaded!");
        }
    }
    
}