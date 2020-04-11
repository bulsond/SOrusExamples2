using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp.Services
{
    class PptFilesIterator : IEnumerable<FileInfo>
    {
        private readonly string _startingPath;
        private IEnumerable<string> _files;

        public PptFilesIterator(string startingPath,
            SearchOption searchOption = SearchOption.AllDirectories)
        {
            if (string.IsNullOrEmpty(startingPath))
                throw new ArgumentException(nameof(startingPath));

            _startingPath = startingPath;
            _files = Directory.EnumerateFiles(_startingPath,
                "*.ppt?", searchOption);
        }

        public IEnumerator<FileInfo> GetEnumerator()
        {
            foreach (var file in _files)
            {
                yield return new FileInfo(file);
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
