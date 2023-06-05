﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class WriteUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImgUrl { get; set; }
    }
}
