using MidtermProject.Models;

namespace MidtermProject.Services;

public class WatchlistService : IWatchlistService
{
    // Encapsulation: internal list is strictly private
    private readonly List<WatchlistItem> _items = new();

    public event Action? OnChange;

    public int Count => _items.Count;

    public IReadOnlyList<WatchlistItem> GetItems() => _items.AsReadOnly();

    public bool Contains(Guid mediaId) => _items.Any(w => w.Media.Id == mediaId);

    public bool Add(MediaItem item)
    {
        if (Contains(item.Id))
        {
            return false; // Prevent duplicates
        }

        _items.Add(new WatchlistItem(item));
        NotifyStateChanged();
        return true;
    }

    public bool Remove(Guid mediaId)
    {
        var itemToRemove = _items.FirstOrDefault(w => w.Media.Id == mediaId);
        if (itemToRemove is null)
        {
            return false;
        }

        _items.Remove(itemToRemove);
        NotifyStateChanged();
        return true;
    }

    public void ToggleWatched(Guid mediaId)
    {
        var target = _items.FirstOrDefault(w => w.Media.Id == mediaId);
        if (target is null) return;

        if (target.IsWatched)
            target.MarkAsUnwatched();
        else
            target.MarkAsWatched();

        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}