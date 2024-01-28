using GameDataParser.App;
using GameDataParser.DataAccess;
using GameDataParser.Logging;
using GameDataParser.UserInteraction;

var userInteractor = new ConsoleUserInteraction();
var gamesPrinter = new GamesPrinter(userInteractor);
var videoGamesDeserializer = new VideoGamesDeserializer(userInteractor);
var fileReader = new LocalFileReader();
var gameDataParserApp = new GameDataParserApp(userInteractor, gamesPrinter, videoGamesDeserializer, fileReader);
var logger = new Logger("log.txt");

try
{
    gameDataParserApp.Run();
}
catch (Exception ex)
{
    Console.WriteLine("Sorry! The application experienced" +
        " an unexpected error and will have to be closed. " +
        "The error message: ");
    logger.Log(ex);

    Console.WriteLine("Press any key to close.");
    Console.ReadKey();
}
