using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Fanhub.Models
{
    public class Signup
    {
        [Key]
        public string Username { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Required.")]

        public DateTime DateAdded { get; set; }
    }
}
