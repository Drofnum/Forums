using Forums.Data;
using Forums.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forums.Service
{
    public class PostService : IPost
    {
        private readonly ForumsDbContext _context;

        public PostService(ForumsDbContext context)
        {
            _context = context;
        }

        public Task Add(Post post)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task EditPostContent(int Id, string newContent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPost> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            return _context.Posts.Where(post => post.Id == id)
                .Include(post => post.Forum)
                .Include(post => post.User)
                .Include(post => post.Replies)
                .ThenInclude(reply => reply.User)
                .FirstOrDefault();
        }

        public IEnumerable<IPost> GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetPostsByForum(int id)
        {
            return _context.Forums.Where(forum => forum.Id == id).First().Posts;
        }

        IEnumerable<Post> IPost.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Post> IPost.GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
