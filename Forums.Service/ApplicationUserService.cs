using Forums.Data;
using Forums.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forums.Service
{
    class ApplicationUserService : IApplicationUser
    {
        private readonly ForumsDbContext context;

        public ApplicationUserService(ForumsDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return context.ApplicationUsers;
        }

        public ApplicationUser GetById(string id)
        {
            return GetAll().FirstOrDefault(user => user.Id == id);
        }

        public Task IncrementRating(string id, Type type)
        {
            throw new NotImplementedException();
        }

        public async Task SetProfileImageAsync(string id, Uri uri)
        {
            var user = GetById(id);
            user.ProfileImageUrl = uri.AbsoluteUri;
            context.Update(user);
            await context.SaveChangesAsync();
        }
    }
}
