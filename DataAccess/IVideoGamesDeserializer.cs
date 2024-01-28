using GameDataParser.Model;

namespace GameDataParser.DataAccess;

public interface IVideoGamesDeserializer
{
    List<VideoGame> DeserializeFromFile(string? fileName, string fileContent);
}
