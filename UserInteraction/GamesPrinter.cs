using GameDataParser.Model;

namespace GameDataParser.UserInteraction;

public class GamesPrinter : IGamesPrinter
{
    private readonly IUserInteraction _userInteraction;

    public GamesPrinter(IUserInteraction userInteraction)
    {
        _userInteraction = userInteraction;
    }

    public void Print(List<VideoGame> videoGames)
    {
        if (videoGames.Count > 0)
        {
            _userInteraction.PrintMessage($"{Environment.NewLine}Loaded games are:");
            foreach (var videoGame in videoGames)
            {
                _userInteraction.PrintMessage(videoGame.ToString());
            }
        }
        else
        {
            _userInteraction.PrintMessage("No games are present in the input file.");
        }
    }
}
