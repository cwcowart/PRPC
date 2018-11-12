using System;
using System.ComponentModel.DataAnnotations;

namespace PRPC_CIDM4390.Models
{

    public class Registration
    {

        [DataType(DataType.Text)]
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "This field is required.")]
         public string username { get; set;}

        [DataType(DataType.Password)]
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "This field is required.")]
        public string password { get; set;}

        [Compare("Password")]
        [DataType(DataType.Password)]
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "This field is required.")]
        public string confirmpassword {get; set;}


        public string firstname {get; set;}

        public string lastname {get; set;}

        
        [DataType(DataType.EmailAddress)]
        [StringLength(60, MinimumLength = 7)]
        [Required(ErrorMessage = "This field is required.")]
        public string email {get; set;}

        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]{8}$")]
        [StringLength(32)]
        [Required(ErrorMessage = "This field is required.")]
        public string phonenumber {get; set;}

        
    }
}
