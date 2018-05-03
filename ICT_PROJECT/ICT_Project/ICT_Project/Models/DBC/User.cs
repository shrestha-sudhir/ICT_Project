using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICT_Project.Models.DBC
{
    public class User
    {
        public int UserID { get; set; }
        [Required]
        public string UserName { get; set; }

       [ DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [Required]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public bool RememberMe { get; set; }
        public string Inactive { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int ? PhoneNum { get; set; }
        public int PositionLevel { get; set; }
        public virtual Positions Positions { set; get; }
        

    }
}