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
    }
}
