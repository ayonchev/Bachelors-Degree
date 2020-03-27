using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.ViewModels
{
    public class CommentViewModel
    {
        public string Content { get; set; }
        public int PostId { get; set; }
    }
}