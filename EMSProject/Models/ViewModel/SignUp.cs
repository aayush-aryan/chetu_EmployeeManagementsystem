using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMSProject.Models.ViewModel
{
    // models for sinup the users.
    public class SignUp
    {

        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }

       // When we set DataType as password, we will see the password field in non readable format.
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password",ErrorMessage ="Password not matched !")]
        public string ConfirmPassword { get; set; }

        public bool IsVerified { get; set; }
    }
}
