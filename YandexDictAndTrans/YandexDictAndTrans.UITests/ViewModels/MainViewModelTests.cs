using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using YandexDictAndTrans.UI.Services;

namespace YandexDictAndTrans.UI.ViewModels.Tests
{
    [TestClass()]
    public class MainViewModelTests
    {
        [TestMethod()]
        public async Task GetTransationAsync_WhenRusInput_ThenEngOutput()
        {
            string input = "семь раз отмерь один раз отрежь";
            string output = "measure twice cut once\r\n";
            YandexServices services = new YandexServices();
            MainViewModel sut = new MainViewModel(services);

            sut.Input = input;
            sut.SelectedLang = 0;
            await sut.GetTransationAsync();

            Assert.AreEqual(output, sut.Output);
        }

        [TestMethod()]
        public async Task GetTransationAsync_WhenEngInput_ThenRusOutput()
        {
            string input = "measure twice cut once";
            string output = "семь раз отмерь один раз отрежь";
            YandexServices services = new YandexServices();
            MainViewModel sut = new MainViewModel(services);

            sut.Input = input;
            sut.SelectedLang = 1;
            await sut.GetTransationAsync();

            Assert.IsTrue(sut.Output.Contains(output));
        }

        [TestMethod()]
        public async Task GetDictionaryAsync_WhenRusInput_ThenEngOutput()
        {
            string input = "мысль";
            string output = "thought";
            YandexServices services = new YandexServices();
            MainViewModel sut = new MainViewModel(services);

            sut.Input = input;
            sut.SelectedLang = 0;
            await sut.GetDictionaryAsync();

            Assert.IsTrue(sut.Output.Contains(output));
        }

        [TestMethod()]
        public async Task GetDictionaryAsync_WhenEngInput_ThenRusOutput()
        {
            string input = "thought";
            string output = "мысль";
            YandexServices services = new YandexServices();
            MainViewModel sut = new MainViewModel(services);

            sut.Input = input;
            sut.SelectedLang = 1;
            await sut.GetDictionaryAsync();

            Assert.IsTrue(sut.Output.Contains(output));
        }
    }
}