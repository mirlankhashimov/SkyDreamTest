using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyDreamTest.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
    }
}
