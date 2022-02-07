using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSProject.Models.ViewModel
{
    // model class for signing users;
    public class SignIn
    {
        public string Email { get; set; }
        public string Password { get; set; }

        // To Gets or sets whether the authentication session is persisted across multiple requests.
        // used for cookies
        public bool IsPersistent { get; set; }
    }
}
