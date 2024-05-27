﻿using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ViewModel
{
    public class PatientMedicinesViewModel
    {
        public Patient Patient { get; set; }

        public IEnumerable<Medicine> Medicines { get; set; }

    }
}