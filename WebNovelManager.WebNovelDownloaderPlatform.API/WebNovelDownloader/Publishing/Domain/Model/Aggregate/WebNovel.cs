using WebNovelManager.WebNovelDownloaderPlatform.API.WebNovelDownloader.Publishing.Domain.Model.ValueObjects;

namespace WebNovelManager.WebNovelDownloaderPlatform.API.WebNovelDownloader.Publishing.Domain.Model.Aggregate;

/// <summary>
///     Web Novel aggregate root entity
/// </summary>
/// <remarks>
///     This class is used to represent a web novel in the application.
/// </remarks>

public partial class WebNovel
{
    public WebNovel(string url, string title, List<string> tags, string summary, string imageUrl) : this()
    {
        Url = url;
        Title = title;
        Tags = tags;
        Summary = summary;
        ImageUrl = imageUrl;
    }

    public int Id { get; }
    public string Url { get; }
    public string Title { get; }
    public List<string> Tags { get; }
    public string Summary { get; }
    public string ImageUrl { get; }

}