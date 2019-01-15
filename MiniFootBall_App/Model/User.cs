using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootBall_App.Model
{
   public class User:Entity
    {
        [Required]
       
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string File { get; set; }
        [Required]
        public Status Status { get; set; }

        public int? TeamId { get; set; }
        public Team Team { get; set; }
    }
}
