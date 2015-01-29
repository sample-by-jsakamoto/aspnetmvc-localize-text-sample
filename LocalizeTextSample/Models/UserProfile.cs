using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LocalizeTextSample.Models
{
    public class UserProfile
    {
        [Required(ErrorMessageResourceType = typeof(Localize), ErrorMessageResourceName = "ValidationError_Required")]
        [Display(ResourceType = typeof(Localize), Name = "Name")]
        public string Name { get; set; }
    }
}