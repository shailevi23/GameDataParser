using CoockieCookbook.UI.ConsoleUI;
using GameDataParser.App;

namespace GameDataParser
{
    class Program
    {
        static void Main(string[] args)
        {
            GameDataParserApp gameDataParser = new GameDataParserApp(new ConsoleUI());
            gameDataParser.Run();
        }
    }
}
