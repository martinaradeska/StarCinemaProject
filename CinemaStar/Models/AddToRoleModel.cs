using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CinemaStar.Models
{
    public class AddToRoleModel
    {
        
            [Required]
            [Key]
            public string Email { get; set; }
            public List<string> roles { get; set; }
            public string selectedRole { get; set; }
       
    }
}