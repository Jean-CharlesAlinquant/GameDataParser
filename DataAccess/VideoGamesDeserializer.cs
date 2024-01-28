namespace GameDataParser.DataAccess;

using System.Text.Json;
using GameDataParser.Model;
using GameDataParser.UserInteraction;

public class VideoGamesDeserializer : IVideoGamesDeserializer
{
    private readonly IUserInteraction _userInteraction;

    public VideoGamesDeserializer(IUserInteraction userInteraction)
    {
        _userInteraction = userInteraction;
    }

    public List<VideoGame> DeserializeFromFile(string? fileName, string fileContent)
    {
        try
        {
            return JsonSerializer.Deserialize<List<VideoGame>>(fileContent);
        }
        catch (JsonException ex)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            _userInteraction.PrintError($"JSON is file name {fileName} was not in a valid format. JSON body:");
            _userInteraction.PrintError(fileContent);
            Console.ForegroundColor = originalColor;

            throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
        }
    }
}
