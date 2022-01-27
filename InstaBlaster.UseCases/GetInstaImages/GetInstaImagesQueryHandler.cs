using InstaBlaster.Infrastructure.Abstractions;
using MediatR;

namespace InstaBlaster.UseCases.GetInstaImages
{
    /// <summary>
    /// Handler for <see cref="GetInstaImagesQuery"/>.
    /// </summary>
    internal class GetInstaImagesQueryHandler : IRequestHandler<GetInstaImagesQuery, string[]>
    {
        private readonly IInstagramPageParser parser;
        public GetInstaImagesQueryHandler(IInstagramPageParser parser)
        {
            this.parser = parser;
        }
        /// <inheritdoc/>
        public Task<string[]> Handle(GetInstaImagesQuery request, CancellationToken cancellationToken)
        {
            var imageLinks = parser.GetImages(request.Post.PostUrl);
            return Task.FromResult(imageLinks);
        }
    }
}
