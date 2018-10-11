using System.Collections.Generic;

namespace CodeFirstExample.Models
{
    public class Blog
    {
        public Blog()
        {
            Posts = new List<Post>();
        }

        public int Id { get; set; }

        public string Url { get; set; }

        public string Title { get; set; }

        public List<Post> Posts { get; set; }
    }
}
