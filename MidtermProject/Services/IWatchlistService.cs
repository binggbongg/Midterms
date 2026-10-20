using MidtermProject.Models;

namespace MidtermProject.Services;

public interface IWatchlistService
{
    event Action? OnChange;
    IReadOnlyList<WatchlistItem> GetItems();
    bool Add(MediaItem item);
    bool Remove(Guid mediaId);
    bool Contains(Guid mediaId);
    void ToggleWatched(Guid mediaId);
    int Count { get; }
}