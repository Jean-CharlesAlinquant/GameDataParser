namespace GameDataParser.Model;

public class VideoGame
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public decimal Rating { get; set; }

    public override string ToString() => $"{Title}, released in {ReleaseYear}, rating: {Rating}";
}
