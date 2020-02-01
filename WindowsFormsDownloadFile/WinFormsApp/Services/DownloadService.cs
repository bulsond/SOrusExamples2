using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace WinFormsApp.Services
{
    public class DownloadService
    {
        //адрес скачиваемого
        private readonly Uri _uri;
        //путь сохранения
        private readonly string _path;
        private readonly HttpClient _httpClient;
        //размер скачиваемого файла
        private long _fileSize;

        public DownloadService(Uri uri, string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException(nameof(path));

            _uri = uri ?? throw new ArgumentNullException(nameof(uri));
            _path = path;

            _httpClient = new HttpClient();
            _httpClient.Timeout = new TimeSpan(0, 0, 30);
        }

        /// <summary>
        /// Скачивание файла
        /// </summary>
        /// <param name="token">токен отмены</param>
        /// <param name="progress">колбек прогресса</param>
        /// <returns></returns>
        public async Task DownloadFileAsync(CancellationToken token, IProgress<int> progress = null)
        {
            if (token == null)
                throw new ArgumentNullException(nameof(token));

            //проверка, что размер файла известен
            if (_fileSize == 0)
                await GetFileSize(token);

            //запрашиваем адрес
            var response = await _httpClient.GetAsync(_uri,
                HttpCompletionOption.ResponseHeadersRead, token);
            if (!response.IsSuccessStatusCode)
                return;

            //скачиваем и пишем в файл
            using (Stream contentStream = await response.Content.ReadAsStreamAsync())
            using (var fileStream = new FileStream(_path, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
            {
                //счетчик скачаного
                var totalReaded = 0L;
                var buffer = new byte[16 * 1024];
                //флаг остановки
                var isMoreToRead = true;

                do
                {
                    //читаем порцию
                    var readed = await contentStream.ReadAsync(buffer, 0, buffer.Length);
                    if (readed == 0 || token.IsCancellationRequested)
                    {
                        isMoreToRead = false;
                    }
                    else
                    {
                        //пишем в файл порцию
                        await fileStream.WriteAsync(buffer, 0, readed);
                        //сообщаем
                        totalReaded += readed;
                        //процент скачанного
                        var percent = (double)totalReaded / _fileSize * 100;
                        progress?.Report((int)percent);
                    }
                }
                while (isMoreToRead);
            }
        }

        /// <summary>
        /// Получение размера скачиваемого файла
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<long> GetFileSize(CancellationToken token)
        {
            //запрашиваем адрес
            var response = await _httpClient.GetAsync(_uri,
                HttpCompletionOption.ResponseHeadersRead, token);
            if (response.IsSuccessStatusCode)
            {
                var size = response.Content.Headers
                    .First(h => h.Key.Equals("Content-Length"))
                    .Value.First();
                _fileSize = long.Parse(size);
            }
            
            return _fileSize;
        }
    }
}
