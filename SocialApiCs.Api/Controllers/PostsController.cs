using Microsoft.AspNetCore.Mvc;
using SocialApiCs.Core.Interfaces;

namespace SocialApiCs.Api.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepository _repository;

        public PostsController(IPostRepository repo)
        {
            _repository = repo;
        }

        //GET api/posts
        [HttpGet]
        public IActionResult GetAllPosts()
        {
            var posts = _repository.GetAllPosts();
            return Ok(posts.Result);
        }
    }
}