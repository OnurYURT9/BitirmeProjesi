﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KmuDolmus.Models
{
    public class Hatlar
    {
        [Key]
        public int hat_id { get; set; }
        public int hat_Numara { get; set; }
        public string hat_saat { get; set; }
        public int GunId { get; set; }
        public string yon { get; set; }
        public Gun Gun { get; set; }
    }
}