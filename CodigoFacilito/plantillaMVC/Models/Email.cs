﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace plantillaMVC.Models
{
    public class Email
    {
        public int EmailId { get; set; }
        public string Direccion { get; set; }
        public bool Principal { get; set; }

    }
}