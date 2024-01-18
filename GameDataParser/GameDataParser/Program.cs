using CoockieCookbook.UI.ConsoleUI;
using GameDataParser.App;
using GameDataParser.Repository;
using GameDataParser.Utils;
using System;

namespace GameDataParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new ConsoleUI();

            GameDataParserApp gameDataParser = new GameDataParserApp(
                new GameDataRepository(),
                ui,
                new ValidateInput());

            try
            {
                gameDataParser.Run();
            }
            catch (Exception ex)
            {
                ui.ShowMessage("Sorry! The application has experienced an unexpected error and will have to be closed.");
                ui.CloseApp();
            }
        }
    }
}
