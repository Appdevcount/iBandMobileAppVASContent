﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBand.Models.Inputs.OneInInputs
{
    public class SaveAddress
    {
        public string userid { get; set; }
        public string mobile { get; set; }
        public Address address { get; set; }
    }
}
