﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBand.Models.Inputs.OneInInputs
{
    public class ModifyUserDetails
    {
        public string username { get; set; }
        public string password { get; set; }
        public string newpassword { get; set; }
        public string mobileNumber { get; set; }
        public string emailID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
    }
}
