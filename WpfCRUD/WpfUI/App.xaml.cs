using System.Windows;
using WpfUI.Data;
using WpfUI.ViewModels;
using WpfUI.Views;

namespace WpfUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //работа с данными в памяти
            var viewModel = new MainViewModel(new TestRepository());

            //или работа с данными из БД
            //var viewModel = new MainViewModel(new SqlRepository());

            //создаем въюшку
            var view = new MainView();
            //подключаем въюмодель в качестве источн.данных
            view.DataContext = viewModel;

            //окно программы
            var window = new MainWindow();
            //отображем въюшку
            window.Output.Content = view;
            //показываем окно
            window.Show();
        }
    }
}
