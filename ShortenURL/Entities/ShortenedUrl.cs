namespace ShortenURL.Entities
{
    public class ShortenUrl
    {
        public Guid Id { get; set; }

        public string LongUrl { get; set; } = string.Empty;

        public string ShortUrl { get; set; } = string.Empty;

        public DateTime CreatedOnUtc { get; set; }

        public int MyProperty { get; set; }
    }
}
