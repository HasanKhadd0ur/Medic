using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPresentation.ViewModels
{
    public interface IImageForm
    {
        public IFormFile ImageFile  {get ;set; }
        public String ImageName { get; set; }

    }
}
