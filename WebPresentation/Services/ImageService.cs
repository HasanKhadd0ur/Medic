using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebPresentation.Services
{
    public interface IImageService
    {
        Task<string> SaveImageAsync(IFormFile file, String folderName);
    }

    public class ImageService : IImageService
    {
        private readonly string _uploadsFolderPath;
        private readonly String _rootPath;
        public ImageService(IWebHostEnvironment env)
        {
            _uploadsFolderPath = Path.Combine(env.WebRootPath, "img");
            _rootPath = env.WebRootPath;
        }

        public async Task<string> SaveImageAsync(IFormFile file,String folderName)
        {
            if (file is null)
                return "";
            var uploadsFolderPath = Path.Combine(_uploadsFolderPath, folderName);
           

            var uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            
            var filePath = Path.Combine(uploadsFolderPath, uniqueFileName);

            if (file.Length > 0)
            {
                Directory.CreateDirectory(uploadsFolderPath);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }

            return folderName +"/"+uniqueFileName; // Return relative path
        }
    }
}
