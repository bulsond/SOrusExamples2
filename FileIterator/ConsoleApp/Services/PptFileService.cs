using System;
using System.IO;

namespace ConsoleApp.Services
{
    class PptFileService
    {
        internal string RenameFile(FileInfo file)
        {
            var newName = $"{file.Name}_{file.CreationTime.ToShortDateString()}{file.Extension}";
            var dest = Path.Combine(file.DirectoryName, newName);
            var result = string.Empty;
            try
            {
                //file.MoveTo(dest);
                result = dest;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }
    }
}
