using GameDataParser.Entity_Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace GameDataParser.Files
{
    class TextFileHandler : ILogFileHandler
    {
        public void Write(LogExceptions logeExceptions, string filePath)
        {
            WriteToFile(logeExceptions.ToString(), filePath);
        }

        public List<string> Read(string filePath)
        {
            return ReadFileAsListOfStrings(filePath);
        }

        public bool IsRepoExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                return true;
            }

            return false;
        }

        public string GetRepoPath()
        {
            return $"./log.txt";
        }


        void WriteToFile(string text, string filePath)
        {
            if (!File.Exists(filePath))
            {
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.WriteLine(text);
                }
            }
            else
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(text);
                }
            }
        }

        List<string> ReadFileAsListOfStrings(string filePath)
        {
            List<string> lines = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

            return lines;
        }
    }
}
