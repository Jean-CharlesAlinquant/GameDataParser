namespace GameDataParser.UserInteraction;

public interface IUserInteraction
{
    string? ReadValidFilePath();
    void PrintMessage(string message);
    void PrintError(string message);
}
