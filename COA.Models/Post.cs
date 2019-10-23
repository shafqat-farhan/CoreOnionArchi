using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace COA.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Content { get; set; }
        public virtual User User { get; set; }
    }
}
