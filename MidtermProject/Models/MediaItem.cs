namespace MidtermProject.Models;

public abstract class MediaItem
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public int ReleaseYear { get; set; }
    public string StreamingPlatform { get; set; } = string.Empty;
    public string PosterUrl { get; set; } = string.Empty;
    public string Synopsis { get; set; } = string.Empty;

    protected MediaItem(string title, string genre, int releaseYear, string platform, string posterUrl, string synopsis)
    {
        Title = title;
        Genre = genre;
        ReleaseYear = releaseYear;
        StreamingPlatform = platform;
        PosterUrl = posterUrl;
        Synopsis = synopsis;
    }

    public abstract string GetDurationDisplay();
    public abstract bool MatchesRuntime(int maxMinutes);
}

public class Movie : MediaItem
{
    public int RuntimeMinutes { get; set; }

    public Movie(string title, string genre, int releaseYear, string platform, int runtimeMinutes, string posterUrl, string synopsis)
        : base(title, genre, releaseYear, platform, posterUrl, synopsis)
    {
        RuntimeMinutes = runtimeMinutes;
    }

    public override string GetDurationDisplay() => $"{RuntimeMinutes} mins";
    public override bool MatchesRuntime(int maxMinutes) => RuntimeMinutes <= maxMinutes;
}