using CoockieCookbook.UI;
using GameDataParser.Exceptions;
using GameDataParser.Main_Classes;
using GameDataParser.Repository;
using GameDataParser.Utils;
using System;
using System.Collections.Generic;

namespace GameDataParser.App
{
    class GameDataParserApp
    {
        private readonly IUserInterface _userInterface;
        private readonly IValidateInput _validateInput;
        private readonly IGameDataRepository _gameDataRepository;


        public GameDataParserApp(IGameDataRepository gameDataRepository, IUserInterface userInterface, IValidateInput validateInput)
        {
            _userInterface = userInterface;
            _validateInput = validateInput;
            _gameDataRepository = gameDataRepository;
        }

        public void Run()
        {
            List<Game> gamesData = null;
            var filePath = GetFilePath();

            try
            {
                gamesData = _gameDataRepository.ReadDataAsJson(filePath);
            }
            catch (JsonParseException ex)
            {
                _userInterface.ShowMessageWithColor(ex.Message + ex.JsonBody, ConsoleColor.Red);
                throw;
            }

            ShowGamesData(gamesData);
            _userInterface.CloseApp();
        }

        private void ShowGamesData(List<Game> gamesData)
        {
            if (gamesData.Count == 0)
            {
                _userInterface.ShowMessage("No games are present in the input file.");
            }
            else
            {
                _userInterface.ShowMessage("Loaded games are:");

                foreach (Game game in gamesData)
                {
                    _userInterface.ShowMessage(game.ToString());
                }
            }
        }

        private string GetFilePath()
        {
            bool shallContinue = true;

            while (shallContinue)
            {
                var fileName = GetFileName();
                var filePath = $"../../Resources/{fileName}";
                var isFileExists = _gameDataRepository.IsFileExists(filePath);

                if (isFileExists)
                {
                    shallContinue = false;
                    return filePath;
                }
                else
                {
                    _userInterface.ShowMessage("File not found.");
                }
            }

            throw new InvalidOperationException("Couldn't get file from user.");
        }

        private string GetFileName()
        {
            bool shallContinue = true;
            string fileName = null;

            while (shallContinue)
            {
                _userInterface.ShowMessage("Enter the name of the file you want to read:");
                fileName = _userInterface.UserInput();

                if (_validateInput.IsNull(fileName))
                {
                    _userInterface.ShowMessage("File name cannot be null.");
                }
                else if (_validateInput.IsEmpty(fileName))
                {
                    _userInterface.ShowMessage("File name cannot be empty.");
                }
                else
                {
                    shallContinue = false;
                }
            }

            return fileName;
        }
    }
}
