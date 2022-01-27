using MediatR;

namespace InstaBlaster.UseCases.GetInstaImages
{
    public class GetInstaImagesQuery : IRequest<string[]>
    {
        public PostDto Post { get; init; }
    }
}
