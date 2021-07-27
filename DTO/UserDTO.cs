using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace DTO
{
    public class UserDTO
    {
        public int    ID        { get; set; }
        [Required(ErrorMessage ="Please Fill the Username Area")]

        public string Username  { get; set; }
        [Required(ErrorMessage = "Please Fill the Password Area")]
        public string Password  { get; set; }
        [Required(ErrorMessage = "Please Fill the Email Area")]
        public string Email     { get; set; }
        public string ImagePath { get; set; }
        [Required(ErrorMessage = "Please Fill the FirstName")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Fill the LastName")]
        public string LastName  { get; set; }
        public bool isAdmin { get; set; }
        [Display(Name ="User Image")]
        public HttpPostedFileBase UserImage { get; set; }
    }
}
