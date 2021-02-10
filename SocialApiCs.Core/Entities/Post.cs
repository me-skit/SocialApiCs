using System;
using System.Collections.Generic;

#nullable disable

namespace SocialApiCs.Core.Entities
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime PostDate { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
