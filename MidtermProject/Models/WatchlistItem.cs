namespace MidtermProject.Models;

public class WatchlistItem
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public MediaItem Media { get; private set; }
    public DateTime DateAdded { get; private set; }
    public bool IsWatched { get; private set; }

    public WatchlistItem(MediaItem media)
    {
        ArgumentNullException.ThrowIfNull(media);
        Media = media;
        DateAdded = DateTime.UtcNow;
        IsWatched = false;
    }

    public void MarkAsWatched() => IsWatched = true;
    public void MarkAsUnwatched() => IsWatched = false;
}