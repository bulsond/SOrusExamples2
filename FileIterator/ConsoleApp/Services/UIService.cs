using System;
using System.IO;
using System.Linq;

namespace ConsoleApp.Services
{
    class UIService
    {
        internal bool UserEnteredPath(out string path)
        {
            var result = false;
            path = String.Empty;

            do
            {
                Console.WriteLine("Введите путь к папке или Q для выхода:");
                var input = Console.ReadLine().Trim();
                if (input.ToUpper().StartsWith("Q"))
                    break;
                if (!Directory.Exists(input))
                {
                    Console.WriteLine();
                    Console.WriteLine("Ошибочный путь к папке, попробуйте еще раз...");
                    continue;
                }

                path = input;
                result = true;

            } while (!result);

            return result;
        }

        internal bool UserWantRenameFiles(PptFilesIterator files)
        {
            foreach (var file in files)
            {
                Console.WriteLine(file.FullName);
            }
            Console.WriteLine($"Всего файлов: {files.Count()}");
            Console.WriteLine();

            var result = false;
            do
            {
                Console.WriteLine("Переименовать файлы Y, выход Q:");
                var input = Console.ReadLine().Trim().ToUpper();
                if (input.StartsWith("Q"))
                    break;
                if (input.StartsWith("Y"))
                {
                    result = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Ошибочная команда, попробуйте еще раз...");
                }

            } while (!result);

            return result;
        }

        internal void ShowFileInfo(string fileName, int index, int count)
        {
            Console.Write($"[{index}/{count}] {fileName}");
        }

        internal void ShowNewFileInfo(string newFile)
        {
            Console.Write($" --> {newFile}");
            Console.WriteLine();
        }

        internal void ShowBye()
        {
            Console.WriteLine("Выходим... Нажмите любую клавишу.");
            Console.ReadKey(true);
        }

        internal void ShowDone()
        {
            Console.WriteLine("Все файлы переименованы.");
            Console.WriteLine();
            ShowBye();
        }
    }
}
