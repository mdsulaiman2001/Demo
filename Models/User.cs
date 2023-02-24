
using System.ComponentModel.DataAnnotations;

namespace SwordLMS.Web.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } 

        [Required(ErrorMessage = "Please Enter Your First Name"), MaxLength(150)]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Last Name"), MaxLength(150)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email"), MaxLength(50)]
        public String Email { get; set; }
        public  DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Mobile Number Is Required")]
        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Your Address"), MaxLength(250)]
        public String Address { get; set; }
        public int City { get; set; }
        public int Pincode { get; set; }
        public int State { get; set; }
        
        [Required(ErrorMessage = "Mobile Number Is Required")]
        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public int Country { get; set; }





    }
}
