﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{
    public class Post : IRequestable
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
