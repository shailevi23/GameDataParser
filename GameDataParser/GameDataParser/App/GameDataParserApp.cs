using CoockieCookbook.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.App
{
    class GameDataParserApp
    {
        private readonly IUserInterface _userInterface;

        public GameDataParserApp(IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        public void Run()
        {
            _userInterface.ShowMessage("Enter the name of the file you want to read:");
            var fileName = _userInterface.UserInput();
        }
    }
}
