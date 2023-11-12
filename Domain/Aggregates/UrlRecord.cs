namespace Domain.Aggregates;

public class UrlRecord
{
    private UrlRecord(string longLink, string shortLink, DateTime createdDate)
    {
        LongLink = longLink;
        ShortLink = shortLink;
        CreatedDate = createdDate;
    }
    
    public string LongLink { get; private set; }
    public string ShortLink { get; private set; }
    public DateTime CreatedDate { get; private set; }
}