﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FinalVidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name{ get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MemberShipType MemberShipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}