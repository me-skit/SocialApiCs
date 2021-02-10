using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialApiCs.Core.Entities;
using SocialApiCs.Core.Interfaces;
using SocialApiCs.Infrastructure.Data;

namespace SocialApiCs.Infrastructure.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly DataContext _context;

        public PostRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            return await _context.Posts.ToListAsync();
        }
    }
}