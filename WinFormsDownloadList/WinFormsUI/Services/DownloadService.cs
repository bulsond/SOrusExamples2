using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using WinFormsUI.Models;

namespace WinFormsUI.Services
{
    class DownloadService
    {
        /// <summary>
        /// Получение ответов по списку адресов
        /// </summary>
        /// <param name="items">список адресов</param>
        /// <param name="progress">отображение прогресса выполения</param>
        /// <param name="token">токен отмены</param>
        /// <returns></returns>
        public async Task GetItemsResposesAsync(List<Item> items, IProgress<int> progress, CancellationToken token)
        {
            foreach (var item in items)
            {
                //если нужно отменять досрочно
                if (token.IsCancellationRequested)
                    break;

                item.Response = await Task.Run(() => GetResponse(item));
                progress.Report(item.Number);
            }
        }

        private string GetResponse(Item item)
        {
            var result = String.Empty;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(item.Address);
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)httpWebRequest.GetResponse();
            }
            catch (WebException wex)
            {
                result = wex.Message;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            if (response != null)
            {
                result = response.StatusDescription;
            }

            return result;
        }
    }
}
