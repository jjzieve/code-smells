// composition >> inheritance
// multiple levels of inheritance, good or bad?
// Cross-cutting concerns! An OO problem in general!
// FileWriter example (atomic write, directory structure)

using System.IO;

namespace CodeSmells
{
    public abstract class BaseFileWriter
    {
        public void AtomicWrite(string filePath)
        {
            var tmpFilePath = Path.Combine(Path.GetDirectoryName(filePath), Path.GetRandomFileName());
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            File.Move(tmpFilePath, filePath);
        }

        public string GetFileNameByMimicingInput(string outputFolder, string inputDirectory)
        {
            // var outputFolder = Path.Combine(outputFolder, relativePath);
            // if (!Directory.Exists(outputFolder))
            //     Directory.CreateDirectory(outputFolder);
            return "blah";
        }
    }

    // public class WriteFile
}
