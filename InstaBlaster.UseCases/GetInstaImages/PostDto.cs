using System.ComponentModel.DataAnnotations;

namespace InstaBlaster.UseCases.GetInstaImages
{
    public class PostDto
    {
        [Required]
        public string PostUrl { get; init; }
    }
}
