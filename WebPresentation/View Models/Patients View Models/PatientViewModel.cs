﻿using ApplicationDomain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPresentation.ViewModels
{
    public class PatientViewModel : BaseViewModel , IImageForm
    {


        public String  UserId { get; set; }
        public User User { get; set; }
        [Display(Name = "Your BIO ")]
        public String BIO { get; set; }
        public ICollection<MedicalStateViewModel> MedicalStates { get; set; }


        public IFormFile ImageFile { get; set; }
        public string ImageName { get; set; }


    }
}
