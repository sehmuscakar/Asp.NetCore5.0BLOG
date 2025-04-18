﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EntityLayer.conrete
{
   public class Testimonial
    {
        [Key] // key Attibutelerin
        public int TestimonialID { get; set; }

        public string ClientName { get; set; }

        public string Comment { get; set; }

        public string Company { get; set; }

        public string ImageUrl { get; set; }

        public string Title { get; set; }
    }
}
