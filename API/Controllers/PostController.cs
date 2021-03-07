using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Posts;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PostController : BaseApiController
    {
        [HttpGet]
        public async Task<List<Post>> GetPosts()
        {
            return await Mediator.Send(new List.Query());
        }
    }
}