namespace WebNovelManager.WebNovelDownloaderPlatform.API.WebNovelDownloader.Publishing.Domain.Model.Aggregate;

public partial class Chapter
{
   /// <summary>
   ///     Default constructor for the chapter entity
   /// </summary>
   /// <param name="title">
   ///     The title of the chapter 
   /// </param>
   /// <param name="url">
   ///     The url of the chapter
   /// </param>
   /// <param name="content">
   ///     The content of the chapter
   /// </param>
   ///<param name="webNovelId">
   ///   The Id of the Webnovel the chapter belongs to
   /// </param>
   
   public Chapter(string title, string url, string content, int webNovelId)
   {
      Title = title;
      Url = url;
      Content = content;
      WebNovelId = webNovelId;
   } 
   
   public int Id { get; }
   public string Title { get; private set; }
   public string Url { get; private set; }
   public string Content { get; private set; }
   public int WebNovelId { get; private set; }
   public WebNovel WebNovel { get; internal set; }
}