using MidtermProject.Models;

namespace MidtermProject.Services;

public interface IMovieRouletteService
{
    IReadOnlyList<MediaItem> GetAll();
    MediaItem? SpinRoulette(string? selectedGenre, string? selectedPlatform, int maxRuntime);
}