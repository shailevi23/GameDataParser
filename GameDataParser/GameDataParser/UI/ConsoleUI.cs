using System;

namespace CoockieCookbook.UI.ConsoleUI
{
    class ConsoleUI : IUserInterface
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void CloseApp()
        {
            Console.WriteLine("Press any key to close.");
            Console.ReadLine();
        }

        public string UserInput()
        {
            return Console.ReadLine();
        }

        public void ShowMessageWithColor(string message, ConsoleColor changeColor)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = changeColor;
            Console.WriteLine(message);
            Console.ForegroundColor = originalColor;
        }
    }
}
