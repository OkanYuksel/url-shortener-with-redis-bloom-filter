namespace url_shortener_with_redis_bloom_filter.Dtos.Requests;

public class CreateShortLinkRequest
{
    public string LongLink { get; set; }
}