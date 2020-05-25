using System;
using System.Windows.Forms;
using ToExcelUI.Models;
using ToExcelUI.Presenters;

namespace ToExcelUI.Views
{
    public class ViewsController : IViewsController
    {
        private MainView _mainView;

        /// <summary>
        /// Первоначальное отображение гл.окна
        /// </summary>
        /// <returns>экз. гл.окна</returns>
        public Form GetMainForm()
        {
            _mainView = new MainView();
            var presenter = new MainPresenter(_mainView);
            return _mainView;
        }

        /// <summary>
        /// Отображение вьюхи редактирования
        /// </summary>
        /// <param name="person">экз.редактируемого</param>
        /// <returns>true если пользователь нажал OK</returns>
        public bool GetChangedPerson(Person person)
        {
            if (person == null) throw new ArgumentNullException(nameof(person));

            var editView = new EditView();
            if (person.FirstName.Equals("<?>"))
            {
                editView.Text = "Создание новой записи...";
            }
            else
            {
                editView.Text = $"Редактирование: {person.FirstName} {person.LastName}";
            }
            
            editView.Owner = _mainView;
            editView.StartPosition = FormStartPosition.CenterParent;

            var editPresenter = new EditPresenter(editView, person);

            return editView.ShowDialog() == DialogResult.OK;
        }

        /// <summary>
        /// Отображение сообщения об ошибке
        /// </summary>
        /// <param name="message"></param>
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Получение подтверждения на удаление
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public bool GetConfirmationRemove(Person person)
        {
            var message = $"Вы согласны удалить: {person.LastName} {person.FirstName}?";
            return MessageBox.Show(message, "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes;
        }
    }
}
