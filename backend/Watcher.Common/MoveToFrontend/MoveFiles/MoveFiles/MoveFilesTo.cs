using System;
using System.IO;

namespace MoveFiles
{
    public class MoveFilesTo
    {
        public static void Run()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Directory.GetCurrentDirectory();
            watcher.Path = watcher.Path.Replace("\\MoveFiles\\MoveFiles\\bin\\Debug\\netcoreapp2.1", "");
            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            // Begin watching.
            watcher.EnableRaisingEvents = true;

            // Wait for the user to quit the program.
            //Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;
        }

        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            CopyFiles();
        }

        public static void CopyFiles()
        {
            var path = Directory.GetCurrentDirectory();
            path = path.Replace("\\MoveFiles\\MoveFiles\\bin\\Debug\\netcoreapp2.1", "");
            var pathNew = path.Replace("backend\\Watcher.Common\\MoveToFrontend", "frontend\\src\\app\\shared\\models\\");
            foreach (var temp in Directory.GetFiles(path))
            {
                var partPath = temp.Substring(temp.LastIndexOf("Frontend\\")).Replace("Frontend\\", "");
                if (File.Exists(pathNew + partPath))
                    File.Delete(pathNew + partPath);
                if (Path.GetExtension(temp).Substring(1) == "ts")
                    File.Move(temp, pathNew + partPath);
            }
        }
    }
}
