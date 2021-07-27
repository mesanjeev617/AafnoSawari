using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DTO
{
    public class AdsDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage="Please Fill the Name Area")]

        public string Name { get; set; }

        public string ImagePath { get; set; }
        [Required(ErrorMessage = "Please Fill the Link Area")]

        public string Link { get; set; }

        [Required(ErrorMessage = "Please Fill the imagesize Area")]
        public string ImageSize { get; set; }

        [Display(Name="Advertisement Images")]
        public HttpPostedFileBase AdsImage { get; set; }

    }
}
