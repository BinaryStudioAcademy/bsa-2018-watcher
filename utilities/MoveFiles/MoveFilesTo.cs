using System.IO;

namespace MoveFiles
{
    public class MoveFilesTo
    {
        public static void CopyFiles()
        {
            var path = Directory.GetCurrentDirectory() + "\\backend\\Watcher.Common\\MoveToFrontend";
            path = path.Replace("\\utilities\\MoveFiles\\bin\\Debug\\netcoreapp2.1", "");
            var pathNew = path.Replace("backend\\Watcher.Common\\MoveToFrontend", "frontend\\src\\app\\shared\\models\\");
            foreach (var temp in Directory.GetFiles(path))
            {
                var partPath = temp.Substring(temp.LastIndexOf("MoveToFrontend\\")).Replace("MoveToFrontend\\", "");
                if (File.Exists(pathNew + partPath))
                    File.Delete(pathNew + partPath);
                if (Path.GetExtension(temp).Substring(1) == "ts")
                    File.Move(temp, pathNew + partPath);
            }
        }
    }
}
