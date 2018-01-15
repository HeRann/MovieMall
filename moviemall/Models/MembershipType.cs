﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace moviemall.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public string DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}