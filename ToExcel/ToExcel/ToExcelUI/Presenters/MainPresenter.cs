using System;
using ToExcelUI.Models;
using ToExcelUI.Views;
using ToExcelUI.Views.EventHandlers;

namespace ToExcelUI.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _mainView;

        //ctor
        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView ?? throw new ArgumentNullException(nameof(mainView));

            //отображаем людей
            ShowPeople();

            //кнопка Добавить
            _mainView.AddPerson = new SimpleButtonEventHandler(OnAdd);
            //кнопка Изменить
            _mainView.UpdatePerson = new SimpleButtonEventHandler(OnUpdate);
            //кнопка Удалить
            _mainView.RemovePerson = new SimpleButtonEventHandler(OnRemove);
        }

        /// <summary>
        /// Чтение всего списка людей
        /// </summary>
        private void ShowPeople()
        {
            try
            {
                _mainView.People = Program.Repository.GetPeople();
            }
            catch (Exception)
            {
                Program.Controller.ShowError("Ошибка чтения данных из файла!");
            }
        }

        /// <summary>
        /// Добавление нового человека
        /// </summary>
        private void OnAdd()
        {
            var person = new Person { FirstName = "<?>", LastName = "<?>",
                                                 Address = "<?>", Phone = "<?>" };
            bool result = Program.Controller.GetChangedPerson(person);

            if (result)
            {
                try
                {
                    var id = Program.Repository.AddPerson(person);
                    ShowPeople();
                }
                catch (Exception)
                {
                    Program.Controller.ShowError("Ошибка добавления данных в файл!");
                }
            }
        }

        /// <summary>
        /// Изменение человека
        /// </summary>
        private void OnUpdate()
        {
            var person = _mainView.SelectedPerson;
            bool result = Program.Controller.GetChangedPerson(person);

            if (result)
            {
                try
                {
                    var id = Program.Repository.UpdatePerson(person);
                }
                catch (Exception)
                {
                    Program.Controller.ShowError("Ошибка изменения данных в файле!");
                }
            }
            ShowPeople();
        }

        /// <summary>
        /// Удаление человека
        /// </summary>
        private void OnRemove()
        {
            bool result = Program.Controller.GetConfirmationRemove(_mainView.SelectedPerson);

            if (result)
            {
                try
                {
                    Program.Repository.RemovePerson(_mainView.SelectedPerson.Id);
                    ShowPeople();
                }
                catch (Exception)
                {
                    Program.Controller.ShowError("Ошибка удаления данных из файла!");
                }
            }
        }


    }
}
