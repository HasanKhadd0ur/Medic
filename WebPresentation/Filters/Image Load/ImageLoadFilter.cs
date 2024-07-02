using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPresentation.Services;
using WebPresentation.ViewModels;

namespace WebPresentation.Filters.ImageLoad
{
    public class ImageLoadFilter :ActionFilterAttribute
    {

        public override  void OnActionExecuting(ActionExecutingContext context)
        {

            var imageUploaded = context.ActionArguments.Values.Where(p => p is IImageForm).FirstOrDefault();
          
            var imageService = context.HttpContext.RequestServices.GetService(typeof(IImageService));
            if(imageUploaded is not null ){
                var imagePath = ((IImageService)imageService).SaveImageAsync(((IImageForm)imageUploaded).ImageFile,context.Controller.GetType().Name).Result;
                if(imagePath != "")
                ((IImageForm)imageUploaded).ImageName = imagePath; // You can pass other information as needed

            }

        }
    }
}
