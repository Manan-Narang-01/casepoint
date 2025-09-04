 using System;
    using System.IO;

    public class TryCatchDemo
    {
        public static void Main()
        {
            
            string baseDir = @"C:\Users\asus\OneDrive\Documents\casepoint\test";
            string subDir = Path.Combine(baseDir, "SubFolder");
            string filePath = Path.Combine(subDir, "1.txt");
            string copiedFilePath = Path.Combine(subDir, "example.txt");
            string movedFilePath = Path.Combine(baseDir, "moved.txt");

            try
            {
                Console.WriteLine("Creating directories...");
                Directory.CreateDirectory(subDir);
                Console.WriteLine("Directories created: " + subDir);

                Console.WriteLine("\nChecking existence...");
                Console.WriteLine($"Base directory exists? {Directory.Exists(baseDir)}");
                Console.WriteLine($"Sub directory exists? {Directory.Exists(subDir)}");
                Console.WriteLine($"File exists? {File.Exists(filePath)}");

                Console.WriteLine("\nCreating and writing to file...");
                File.WriteAllText(filePath, "This is the first line.\n");
                Console.WriteLine("Text written to file.");

                Console.WriteLine("\nAppending text to file...");
                File.AppendAllText(filePath, "This is an appended line.\n");
                Console.WriteLine("Text appended to file.");

                Console.WriteLine("\nReading file content...");
                string content = File.ReadAllText(filePath);
                Console.WriteLine("File content:\n" + content);

                
                Console.WriteLine("\n--- Listing Directories ---");
                string[] dirs = Directory.GetDirectories(baseDir);
                foreach (string dir in dirs)
                {
                    Console.WriteLine("Subdirectory: " + dir);
                }

                Console.WriteLine("\n--- Listing Files ---");
                string[] files = Directory.GetFiles(subDir);
                foreach (string file in files)
                {
                    Console.WriteLine("File: " + file);
                }

                Console.WriteLine("\nCopying file...");
                File.Copy(filePath, copiedFilePath, true);
                Console.WriteLine("File copied to: " + copiedFilePath);

                Console.WriteLine("\nMoving file...");
                File.Move(copiedFilePath, movedFilePath);
                Console.WriteLine("File moved to: " + movedFilePath);

                Console.WriteLine("\nRenaming file...");
                string renamedPath = Path.Combine(baseDir, "renamed.txt");
                File.Move(movedFilePath, renamedPath);
                Console.WriteLine("File renamed to: " + renamedPath);

                Console.WriteLine("\nDeleting file...");
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Console.WriteLine("Original file deleted.");
                }

                Console.WriteLine("\nDeleting directory...");
                if (Directory.Exists(baseDir))
                {
                    Directory.Delete(baseDir, true);
                    Console.WriteLine("Base directory deleted.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAn error occurred: " + ex.Message);
            }

            
        }
    }
