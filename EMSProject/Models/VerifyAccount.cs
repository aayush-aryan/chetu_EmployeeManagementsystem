using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMSProject.Models
{
    // model class for verifing Users.
    public class VerifyAccount
    {
        [Key]
        public int Id { get; set; }
        public string  UserEmail { get; set; }
        public string OTP { get; set; }

        // variable declearing for storing  Otp date and time when otp was enterd.
        public DateTime SendTime { get; set; }
       
    }
}
