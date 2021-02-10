using System.Collections.Generic;
using System.Threading.Tasks;
using SocialApiCs.Core.Entities;

namespace SocialApiCs.Core.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetAllPosts();
    }
}