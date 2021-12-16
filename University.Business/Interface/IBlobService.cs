//using Azure.Storage.Blobs.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Entities;

namespace University.Business.Interface
{
   public interface IBlobService
    {
         Task<Blobinfo> GetBlobAync(string name);

         Task UploadFileBlobAync(string filepath,string filename);

    }
 
       
}
