﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HotelProject.EntityLayer.Concrete
{
    public class AddUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}