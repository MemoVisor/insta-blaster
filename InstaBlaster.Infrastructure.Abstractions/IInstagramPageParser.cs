namespace InstaBlaster.Infrastructure.Abstractions
{
    public interface IInstagramPageParser
    {
        string[] GetImages(string postUrl);
    }
}
