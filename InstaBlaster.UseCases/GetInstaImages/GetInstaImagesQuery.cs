using MediatR;

namespace InstaBlaster.UseCases.GetInstaImages
{
    public class GetInstaImagesQuery : IRequest<string[]>
    {
        public string PostUrl { get; init; }
    }
}
