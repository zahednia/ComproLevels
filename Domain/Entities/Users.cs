﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string? UserName { get; set; }
    }
}
