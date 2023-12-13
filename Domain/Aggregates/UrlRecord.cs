using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Aggregates;

public class UrlRecord
{
    public UrlRecord(string longLink, string shortLink, DateTime createdDate)
    {
        LongLink = longLink;
        ShortLink = shortLink;
        CreatedDate = createdDate;
    }

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public string LongLink { get; private set; }
    public string ShortLink { get; private set; }
    public DateTime CreatedDate { get; private set; }
}