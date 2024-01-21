using GameDataParser.Entity_Classes;
using System.Collections.Generic;

namespace GameDataParser.Files
{
    interface ILogFileHandler
    {
        void Write(LogExceptions logExceptions, string filePath);
        List<string> Read(string filePath);
        bool IsRepoExists(string filePath);
        string GetRepoPath();
    }
}
