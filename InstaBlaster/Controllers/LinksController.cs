using InstaBlaster.UseCases.GetInstaImages;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InstaBlaster.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinksController : ControllerBase
    {
        private readonly IMediator mediator;

        public LinksController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("images")]
        public async Task<string[]> GetImages(PostDto dto)
        {
            return await mediator.Send(new GetInstaImagesQuery { Post = dto });
        }
    }
}