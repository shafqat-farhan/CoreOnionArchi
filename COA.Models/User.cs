using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COA.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Post> Post { get; set; }
    }
}
