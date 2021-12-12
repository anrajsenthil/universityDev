using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.Business.Interface;
using University.Domain.Entities;
using University.Services.Model;


namespace University.Services.Controllers
{
   
    public class BlobExplorerController : Controller
    {
        
        private readonly IBlobService _blobService;
   

        public  BlobExplorerController(IBlobService blobService)
        {
            _blobService = blobService;
        }


        [Route("blobs")]
        [HttpGet(template: "blobname")]
        public async Task<IActionResult> GetBlob(string blobname) 
        {
            Blobinfo b = new Blobinfo();
            var data = await _blobService.GetBlobAync(blobname);
            b.Content = data.Content;
            b.ContentType = data.ContentType;
            return File(b.Content, b.ContentType);
        }

        [HttpPost(template:"uploadcontent")]
        public async Task<IActionResult> UplodateFile([FromBody] UplodeFileRequest request)
        {
            await _blobService.UploadFileBlobAync(request.FilePath, request.FileName);
            return Ok();
        }
    }
}