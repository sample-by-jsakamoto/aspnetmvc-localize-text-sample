using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LocalizeTextSample.Models
{
    public class UserProfile
    {
        [Required]
        public string Name { get; set; }
    }
}