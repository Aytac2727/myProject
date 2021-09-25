using Kitabchi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Kitabchi.Controllers
{
    public class SharedController : Controller
    {
        private readonly KitabchiContext _context;
        private IWebHostEnvironment Environment;
        public SharedController(KitabchiContext context, IWebHostEnvironment environment)
        {
            Environment = environment;
            _context = context;
        }
        [HttpPost]
        
        public async Task<JsonResult> UploadPicture()
        {
            JsonResult result;
            List<object> picturesJson = new List<object>();
            var pictures = Request.Form.Files;
            for (int i = 0; i < pictures.Count; i++)
            {
                var picture = pictures[i];
                var fileName = Guid.NewGuid() + Path.GetExtension(picture.FileName);
                string uploadsFolder = Path.Combine(Environment.WebRootPath, "uploads");
                string filePath = Path.Combine(uploadsFolder, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                   await picture.CopyToAsync(fileStream);
                }
                Image dbPicture = new Image
                {
                    ImgUrl = fileName
                };
                _context.Add(dbPicture);
                await _context.SaveChangesAsync();
                picturesJson.Add(new { dbPicture.ID, pictureURL = dbPicture.ImgUrl });
            }
            result = new JsonResult(new { Data = picturesJson });
            return result;
        }
    }
}
