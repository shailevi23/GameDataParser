using System.Collections.Generic;

namespace CoockieCookbook.UI
{
    interface IUserInterface
    {
        void ShowMessage(string message);
        void CloseApp();
        string UserInput();
    }
}
