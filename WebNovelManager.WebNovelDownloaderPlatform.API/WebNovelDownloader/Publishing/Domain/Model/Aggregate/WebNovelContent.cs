using WebNovelManager.WebNovelDownloaderPlatform.API.WebNovelDownloader.Publishing.Domain.Model.ValueObjects;

namespace WebNovelManager.WebNovelDownloaderPlatform.API.WebNovelDownloader.Publishing.Domain.Model.Aggregate;

public partial class WebNovel
{
    /// <summary>
    ///     Default constructor for the tutorial entity
    /// </summary>
    public WebNovel()
    {
        Title = string.Empty;
        Url = string.Empty;
        Tags = new List<string>();
        Summary = string.Empty;
        ImageUrl = string.Empty;
        PublicationStatus = EWebNovelPublicationStatus.Other;
        FetchStatus = EWebNovelFetchStatus.NoUpToDate;
        ChaptersList = new List<Chapter>();
    }

    public EWebNovelPublicationStatus PublicationStatus { get; protected set; }
    public EWebNovelFetchStatus FetchStatus { get; protected set; }
    public List<Chapter> ChaptersList { get; protected set; }


    public void SetWebNovelUpToDate()
    {
        if (FetchStatus == EWebNovelFetchStatus.NoUpToDate)
        {
            FetchStatus = EWebNovelFetchStatus.UpToDate;
        }
    }

    public void RemoveWebNovelUpToDateStatus()
    {
        if (FetchStatus == EWebNovelFetchStatus.UpToDate)
        {
            FetchStatus = EWebNovelFetchStatus.NoUpToDate;
        }
    }

    public void ChangeWebNovelPublicationStatus(EWebNovelPublicationStatus newStatus)
    {
        PublicationStatus = newStatus;
    }

}