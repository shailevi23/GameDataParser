using GameDataParser.Entity_Classes;
using System.Collections.Generic;

namespace GameDataParser.Repository
{
    public interface IGameDataRepository
    {
        bool IsFileExists(string filePath);
        List<Game> ReadData(string filePath);
    }
}