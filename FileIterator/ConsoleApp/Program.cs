using ConsoleApp.Services;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new UIService();

            var path = string.Empty;
            if (!ui.UserEnteredPath(out path))
            {
                ui.ShowBye();
                return;
            }

            var files = new PptFilesIterator(path);
            if (!ui.UserWantRenameFiles(files))
            {
                ui.ShowBye();
                return;
            }

            var pptService = new PptFileService();
            var count = files.Count();
            int index = 0;
            foreach (var file in files)
            {
                ui.ShowFileInfo(file.FullName, ++index, count);
                var newFile = pptService.RenameFile(file);
                ui.ShowNewFileInfo(newFile);
            }

            ui.ShowDone();
        }
    }
}
