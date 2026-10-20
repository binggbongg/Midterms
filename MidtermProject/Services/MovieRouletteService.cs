using MidtermProject.Models;

namespace MidtermProject.Services;

public class MovieRouletteService : IMovieRouletteService
{
    private readonly List<MediaItem> _catalog = new()
    {
        // --- Catalog (All Movies) ---
        new Movie(
            "Resident Evil", 
            "Action/Horror", 
            2026, 
            "Netflix", 
            115, 
            "https://upload.wikimedia.org/wikipedia/en/3/3c/Resident_Evil_2026_film_poster.png?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "A cinematic return to the biological horrors and conspiracy surrounding the Umbrella Corporation."
        ),
        new Movie(
            "Everything Everywhere All At Once", 
            "Sci-Fi", 
            2022, 
            "Netflix", 
            139, 
            "https://upload.wikimedia.org/wikipedia/en/1/1e/Everything_Everywhere_All_at_Once.jpg", 
            "A middle-aged Chinese immigrant gets swept up in an insane adventure across the multiverse to save existence."
        ),
        new Movie(
            "Knives Out", 
            "Mystery", 
            2019, 
            "Netflix", 
            130, 
            "https://upload.wikimedia.org/wikipedia/en/1/1f/Knives_Out_poster.jpeg?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "A master detective investigates the sudden, suspicious death of the patriarch of an eccentric, combative family."
        ),
        new Movie(
            "Past Lives", 
            "Romance", 
            2023, 
            "Prime Video", 
            106, 
            "https://upload.wikimedia.org/wikipedia/en/d/da/Past_Lives_film_poster.png?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "Two deeply connected childhood friends are reunited in New York for one fateful week as they confront destiny and love."
        ),
        new Movie(
            "Forgotten Island", 
            "Mystery/Thriller", 
            2026, 
            "Prime Video", 
            108, 
            "https://upload.wikimedia.org/wikipedia/en/6/65/Forgotten_Island_poster.jpeg?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "Stranded survivors on an unmapped Pacific island discover eerie remnants of a forgotten historical experiment."
        ),
        new Movie(
            "Leviticus", 
            "Drama/Horror", 
            2026, 
            "HBO Max", 
            124, 
            "https://upload.wikimedia.org/wikipedia/en/f/f7/Leviticus_%28film%29_poster.jpg?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "A psychological and religious horror exploring moral descent within a deeply isolated orthodox community."
        ),
        new Movie(
            "Obsession", 
            "Thriller/Drama", 
            2026, 
            "Netflix", 
            112, 
            "https://upload.wikimedia.org/wikipedia/en/0/05/Obsession_theatrical_poster.jpeg?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "An intense erotic psychological thriller tracing a dangerous infatuation that spirals completely out of control."
        ),
        new Movie(
            "Project Hail Mary", 
            "Sci-Fi", 
            2026, 
            "Prime Video", 
            140, 
            "https://upload.wikimedia.org/wikipedia/en/3/3b/Project_Hail_Mary_poster.jpg?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "A lone surviving astronaut must use his scientific ingenuity to solve an extinction-level threat to Earth."
        ),
        new Movie(
            "Chicago", 
            "Musical/Crime", 
            2002, 
            "Prime Video", 
            113, 
            "https://upload.wikimedia.org/wikipedia/en/f/f6/Chicago_%282002_film%29.png?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "Two death-row murderesses develop a fierce rivalry while competing for fame, publicity, and a celebrity lawyer in 1920s Chicago."
        ),
        new Movie(
            "The Grand Budapest Hotel", 
            "Comedy/Drama", 
            2014, 
            "HBO Max", 
            99, 
            "https://upload.wikimedia.org/wikipedia/en/1/1c/The_Grand_Budapest_Hotel.png?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "A legendary concierge at a famous European hotel becomes embroiled in the theft of a priceless Renaissance painting."
        ),
        new Movie(
            "The Holdovers", 
            "Comedy/Drama", 
            2023, 
            "Prime Video", 
            133, 
            "https://upload.wikimedia.org/wikipedia/en/6/62/Holdovers_film_poster.jpg?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "A curmudgeonly prep school teacher is forced to remain on campus over the holidays to babysit a handful of students with nowhere to go."
        ),
        new Movie(
            "Sinners", 
            "Horror/Thriller", 
            2025, 
            "HBO Max", 
            125, 
            "https://upload.wikimedia.org/wikipedia/en/5/5f/Sinners_%282025_film%29_poster.jpg?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "Twin brothers return to their hometown to start over, only to uncover an even greater supernatural evil waiting for them."
        ),
        new Movie(
            "Twilight", 
            "Romance/Fantasy", 
            2008, 
            "Netflix", 
            122, 
            "https://upload.wikimedia.org/wikipedia/en/b/b6/Twilight_%282008_film%29_poster.jpg", 
            "A teenage girl risks everything when she falls in love with a mysterious 104-year-old vampire."
        ),
        new Movie(
            "Interstellar", 
            "Sci-Fi/Drama", 
            2014, 
            "Prime Video", 
            169, 
            "https://upload.wikimedia.org/wikipedia/en/b/bc/Interstellar_film_poster.jpg", 
            "When Earth becomes uninhabitable in the future, a team of explorers travels through a wormhole in space to ensure humanity's survival."
        ),
        new Movie(
            "Sunshine", 
            "Sci-Fi/Thriller", 
            2007, 
            "HBO Max", 
            107, 
            "https://upload.wikimedia.org/wikipedia/en/6/68/Sunshine_poster.jpg?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "A team of international astronauts is sent on a perilous mission to reignite Earth's dying sun with a massive stellar bomb."
        ),
        new Movie(
            "Blue Velvet", 
            "Mystery/Drama", 
            1986, 
            "Prime Video", 
            120, 
            "https://upload.wikimedia.org/wikipedia/en/f/fd/Blue_Velvet_%281986%29.png?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "The discovery of a severed human ear in a suburban field plunges a young man into a dark and twisted criminal underworld."
        ),
        new Movie(
            "The Lighthouse", 
            "Drama/Horror", 
            2019, 
            "HBO Max", 
            109, 
            "https://upload.wikimedia.org/wikipedia/en/2/2c/The_Lighthouse.jpeg?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "Two 1890s lighthouse keepers stationed on a remote, windswept New England island begin to lose their sanity amidst isolation."
        ),
        new Movie(
            "Poor Things", 
            "Sci-Fi/Comedy", 
            2023, 
            "HBO Max", 
            141, 
            "https://upload.wikimedia.org/wikipedia/en/f/f3/Poor_Things_poster.jpg?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "The incredible tale of Bella Baxter, a young Victorian woman brought back to life by an eccentric scientist, who runs off on a whirlwind odyssey of self-discovery."
        ),
        new Movie(
            "Little Miss Sunshine", 
            "Comedy/Drama", 
            2006, 
            "Netflix", 
            101, 
            "https://upload.wikimedia.org/wikipedia/en/1/16/Little_miss_sunshine_poster.jpg?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=original", 
            "A quirky, dysfunctional family piles into an old yellow VW bus to drive 800 miles so their young daughter can compete in a beauty pageant."
        )
    };

    public IReadOnlyList<MediaItem> GetAll() => _catalog.AsReadOnly();

    public MediaItem? SpinRoulette(string? genre, string? platform, int maxRuntime)
    {
        var filtered = _catalog.Where(item =>
            (string.IsNullOrEmpty(genre) || item.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase)) &&
            (string.IsNullOrEmpty(platform) || item.StreamingPlatform.Equals(platform, StringComparison.OrdinalIgnoreCase)) &&
            (maxRuntime <= 0 || item.MatchesRuntime(maxRuntime))
        ).ToList();

        if (!filtered.Any()) return null;

        var random = new Random();
        return filtered[random.Next(filtered.Count)];
    }
}