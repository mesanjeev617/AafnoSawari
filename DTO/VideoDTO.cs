﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VideoDTO
    {
        public int ID { get; set; }
        public string VideoPath { get; set; }

        [Required(ErrorMessage="Please Fill the VideoPath Area")]
        public string OriginalVideoPath { get; set; }
        [Required(ErrorMessage = "Please Fill the Title Area")]
        public string Title { get; set; }
        public DateTime AddDate { get; set; }
    }
}
