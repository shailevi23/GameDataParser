using System;

namespace GameDataParser.UI
{
    interface IUserInterface
    {
        void ShowMessage(string message);
        void ShowMessageWithColor(string message, ConsoleColor color);
        void CloseApp();
        string UserInput();
    }
}
