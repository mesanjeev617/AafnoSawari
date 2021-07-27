using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class AddressDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage="Please Fill the Address Area")]
        public string AddressContent { get; set; }
        [Required(ErrorMessage = "Please Fill the Email Area")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Fill the Phone Area")]
        public string Phone { get; set; }
        public string Fax { get; set; }
        [Required(ErrorMessage = "Please Fill the Map Area")]
        public string LargeMapPath { get; set; }
        [Required(ErrorMessage = "Please Fill the Map Area")]
        public string SmallMapPath { get; set; }
    }
}
