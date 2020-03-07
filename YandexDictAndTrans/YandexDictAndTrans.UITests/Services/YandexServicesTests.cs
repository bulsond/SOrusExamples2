using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace YandexDictAndTrans.UI.Services.Tests
{
    [TestClass()]
    public class YandexServicesTests
    {
        [TestMethod()]
        public async Task GetTranslateAnswerAsyncTest()
        {
            var ru = "семь раз отмерь один раз отрежь";
            var eng = "measure twice cut once\r\n";
            YandexServices sut = new YandexServices();
            YandexServices.TranslationDirection direction
                = YandexServices.TranslationDirection.RuEng;

            YandexAnswer answer = await sut.GetTranslateAnswerAsync(ru, direction);

            Assert.AreEqual("OK", answer.Code);
            Assert.AreEqual(eng, answer.Text);
        }

        [TestMethod()]
        public async Task GetDictionaryAnswerAsyncTest()
        {
            var ru = "мысль";
            var eng = "thought";
            YandexServices sut = new YandexServices();
            YandexServices.TranslationDirection direction
                = YandexServices.TranslationDirection.RuEng;

            YandexAnswer answer = await sut.GetDictionaryAnswerAsync(ru, direction);

            Assert.AreEqual("OK", answer.Code);
            Assert.IsTrue(answer.Text.Contains(eng));
        }
    }
}