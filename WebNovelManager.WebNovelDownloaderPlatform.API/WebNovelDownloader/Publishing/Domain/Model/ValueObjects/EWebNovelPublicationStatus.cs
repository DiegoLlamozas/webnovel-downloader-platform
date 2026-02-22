namespace WebNovelManager.WebNovelDownloaderPlatform.API.WebNovelDownloader.Publishing.Domain.Model.ValueObjects;

/// <summary>
///     Represents the fetching status of a content item in the ACME Learning Center Platform.
/// </summary>

public enum EWebNovelPublicationStatus
{
   Ongoing,
   Stub,
   Completed,
   Inactive,
   Dropped,
   Other
}