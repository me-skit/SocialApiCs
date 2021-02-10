using System;
using System.Collections.Generic;

#nullable disable

namespace SocialApiCs.Core.Entities
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; set; }
        public bool Active { get; set; }

        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
