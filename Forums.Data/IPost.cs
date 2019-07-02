using Forums.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Forums.Data
{
    public interface IPost
    {
        Post GetById(int Id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        IEnumerable<Post> GetPostsByForum(int id);
        IEnumerable<Post> GetLatestPosts(int n);

        Task Add(Post post);
        Task Delete(int Id);
        Task EditPostContent(int Id, string newContent);
        
    }
}
