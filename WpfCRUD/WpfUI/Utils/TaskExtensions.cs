using System;
using System.Threading.Tasks;

namespace WpfUI.Utils
{
    /// <summary>
    /// Расширяющий класс для Task
    /// </summary>
    public static class TaskExtensions
    {
        /// <summary>
        /// Для выполнения асинхронного метода в конструкторе класса
        /// </summary>
        /// <param name="task"></param>
        /// <param name="errorCallBack"></param>
        public async static void Await(this Task task, Action<Exception> errorCallBack)
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                errorCallBack?.Invoke(ex);
            }
        }
    }
}
