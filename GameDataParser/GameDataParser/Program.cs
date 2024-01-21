using GameDataParser.App;
using GameDataParser.Entity_Classes;
using GameDataParser.Files;
using GameDataParser.Repository;
using GameDataParser.UI.ConsoleUI;
using GameDataParser.Utils;
using System;

namespace GameDataParser
{
    class Program
    {
        static void Main(string[] args)
        {
 
            LogExceptions logExceptions = new LogExceptions();
            var textFileHandler = new TextFileHandler();
            var ui = new ConsoleUI();
            GameDataParserApp gameDataParser = new GameDataParserApp(
                textFileHandler,
                new GameDataRepository(),
                ui,
                new ValidateInput());

            try
            {
                gameDataParser.Run();
            }
            catch (Exception ex)
            {
                logExceptions.Log(DateTime.Now, ex.Message, ex.StackTrace);
                textFileHandler.Write(logExceptions, textFileHandler.GetRepoPath());
                ui.ShowMessage("Sorry! The application has experienced an unexpected error and will have to be closed.");
                ui.CloseApp();
            }
        }
    }
}
