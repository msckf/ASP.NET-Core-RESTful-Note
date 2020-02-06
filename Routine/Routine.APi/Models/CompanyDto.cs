﻿using System;

namespace Routine.APi.Models
{
    //输出使用的Dto
    public class CompanyDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Industry { get; set; }
        public string Product { get; set; }
        public string Introduction { get; set; }
    }
}
