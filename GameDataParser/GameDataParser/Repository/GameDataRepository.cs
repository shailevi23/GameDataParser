using GameDataParser.Exceptions;
using GameDataParser.Main_Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GameDataParser.Repository
{
    class GameDataRepository : IGameDataRepository
    {
        public bool IsFileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public List<Game> ReadDataAsJson(string filePath)
        {
            string text = "";

            try
            {
                text = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Game>>(text);
            }
            catch (JsonException ex)
            {
                throw new JsonParseException($"JSON in the {filePath} was not in a valid format. JSON body:", text, ex);
            }
        }
    }
}
