using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StuDept.Models
{
    public class Auth : IdentityUser<string>
    {
        [Required]
        [StringLength(14, MinimumLength = 12)]
        public int StuNo { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        public string CityName { get; set; }

        public DateTime? BirthDate { get; set; }

    }
}
