using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Forum.ViewModels
{
    public class PostViewModel
    {
        [Required]
        [StringLength(80)]
        public string Title { get; set; }

        [Required]
        [StringLength(300)]
        public string Content { get; set; }
        public HttpPostedFileBase ProblemImage { get; set; }
    }
}