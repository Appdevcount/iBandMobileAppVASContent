﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBand.Models.Outputs.Subscription
{
   public class contentdata
    {
        public string contentdataid { get; set; }
        public string contentname { get; set; }
        public string contentdesc { get; set; }
        public string contenttype { get; set; }
        public string contentData { get; set; }
        public List<Translations> translations { get; set; }

    }
}
