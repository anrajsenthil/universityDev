using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
//using Azure;
//using Azure.Storage.Blobs;
//using Azure.Storage.Blobs.Models;
using University.Business.Interface;
using University.Domain.Entities;

namespace University.Business
{
    
    public class BlobService : IBlobService
    {
        //private readonly BlobServiceClient _blobServiceClient;

        //public BlobService(BlobServiceClient blobServiceClient)
        //{
        //    _blobServiceClient = blobServiceClient;
        //}
        public async Task<Blobinfo> GetBlobAync(string name)
        {
            //var containerclient = _blobServiceClient.GetBlobContainerClient("userdocs");
            //var blobclient = containerclient.GetBlobClient(name);
            //Response<BlobDownloadInfo> download = await blobclient.DownloadAsync();
            Blobinfo binfo = new Blobinfo();
            //binfo.Content = download.Value.Content;
            //binfo.ContentType = download.Value.ContentType;
            return  binfo;
        }

        public Task UploadFileBlobAync(string filepath, string filename)
        {
            throw new NotImplementedException();
        }
    }
}
