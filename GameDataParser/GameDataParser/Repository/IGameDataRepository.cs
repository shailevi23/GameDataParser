using GameDataParser.Main_Classes;
using System.Collections.Generic;

namespace GameDataParser.Repository
{
    public interface IGameDataRepository
    {
        bool IsFileExists(string filePath);
        List<Game> ReadDataAsJson(string filePath);
    }
}