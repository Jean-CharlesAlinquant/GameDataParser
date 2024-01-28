namespace GameDataParser.UserInteraction;

public class ConsoleUserInteraction : IUserInteraction
{
    public void PrintError(string message)
    {
        var originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = originalColor;
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public string? ReadValidFilePath()
    {
        bool isFilePathValid = false;
        var fileName = default(string);
        do
        {
            Console.WriteLine("Enter the name of the file you want to read:");
            fileName = Console.ReadLine();

            if (fileName is null)
            {
                Console.WriteLine("File name cannot be null.");
            }
            else if (fileName == string.Empty)
            {
                Console.WriteLine("File name cannot be empty.");
            }
            else if (!File.Exists(fileName))
            {
                Console.WriteLine("No games are present in the input file.");
            }
            else
            {
                isFilePathValid = true;
            }
        } while (!isFilePathValid);
        return fileName;
    }
}
