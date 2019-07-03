using Forums.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forums.Models.Forum
{
    public class ForumTopicModel
    {
        public string SearchQuery { get; set; }

        public ForumListingModel Forum { get; set; }
        public IEnumerable<PostListingModel> Posts { get; set; }
    }
}
