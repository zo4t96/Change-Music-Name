using System;
using System.IO;

namespace Change_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "F:\\Selected work music";
            string[] allFilePaths = Directory.GetFiles(path);

            Random random = new Random();

            foreach (string filePath in allFilePaths)
            {
                FileInfo file = new FileInfo(filePath);

                string randomNumber = (random.Next(0, 9)).ToString() + (random.Next(0, 9)).ToString() + (random.Next(0, 9)).ToString();
                string connectionString = "__ ";
                string newFileName = randomNumber + connectionString + file.Name;
                if (file.Name.Contains(connectionString))
                {
                    string originFileName = file.Name.Split(connectionString)[1];
                    newFileName = randomNumber + connectionString + originFileName;
                    //newFileName = originFileName;
                }

                string newFilePath = Path.Combine(file.DirectoryName, newFileName);
                Console.WriteLine(file.Name);
                Console.WriteLine(newFileName);
                Console.WriteLine();
                File.Move(filePath, newFilePath);
            }
        }
    }
}
