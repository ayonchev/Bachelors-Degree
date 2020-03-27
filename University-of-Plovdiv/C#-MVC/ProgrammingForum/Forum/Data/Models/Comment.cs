using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Forum.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Content { get; set; }
        public System.DateTime DateCreated { get; set; }

        public string AuthorId { get; set; }
        public virtual ApplicationUser Author { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}