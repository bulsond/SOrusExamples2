using System;
using Xunit;
using Rectangle.Core;

namespace Rectangle.Tests
{
    public class MainFormViewModelTests
    {
        [Fact(DisplayName = "Въюмодель имеет свойство ширины")]
        public void ViewModel_HasWidthProperty()
        {
            var vm = new MainFormViewModel();

            vm.Width = "3";

            Assert.IsType<string>(vm.Width);
            Assert.Equal("3", vm.Width);
        }

        [Fact(DisplayName = "Въюмодель имеет свойство длины")]
        public void ViewModel_HasLengthProperty()
        {
            var vm = new MainFormViewModel();

            vm.Length = "3";

            Assert.IsType<string>(vm.Length);
            Assert.Equal("3", vm.Length);
        }

        [Fact(DisplayName = "Вычисление площади выбрасывает исключение если высота не число")]
        public void ViewModel_CalculateArea_ThrowsExceptionIfWidthIsNotNumber()
        {
            var vm = new MainFormViewModel();
            vm.Width = "a";
            vm.Length = "3";

            Assert.Throws<ArgumentException>("Width", () => vm.GetArea());
        }

        [Fact(DisplayName = "Вычисление площади выбрасывает исключение если высота отрицательное число")]
        public void ViewModel_CalculateArea_ThrowsExceptionIfWidthIsNegativeNumber()
        {
            var vm = new MainFormViewModel();
            vm.Width = "-3";
            vm.Length = "3";

            Assert.Throws<ArgumentException>("Width", () => vm.GetArea());
        }

        [Fact(DisplayName = "Вычисление площади выбрасывает исключение если высота равна нулю")]
        public void ViewModel_CalculateArea_ThrowsExceptionIfWidthEqualsZero()
        {
            var vm = new MainFormViewModel();
            vm.Width = "0";
            vm.Length = "3";

            Assert.Throws<ArgumentException>("Width", () => vm.GetArea());
        }

        [Fact(DisplayName = "Вычисление площади выбрасывает исключение если высота не число")]
        public void ViewModel_CalculateArea_ThrowsExceptionIfLengthIsNotNumber()
        {
            var vm = new MainFormViewModel();
            vm.Width = "3";
            vm.Length = "a";

            Assert.Throws<ArgumentException>("Length", () => vm.GetArea());
        }

        [Fact(DisplayName = "Вычисление площади выбрасывает исключение если длина отрицательное число")]
        public void ViewModel_CalculateArea_ThrowsExceptionIfLengthIsNegativeNumber()
        {
            var vm = new MainFormViewModel();
            vm.Width = "3";
            vm.Length = "-3";

            Assert.Throws<ArgumentException>("Length", () => vm.GetArea());
        }

        [Fact(DisplayName = "Вычисление площади выбрасывает исключение если длина равна нулю")]
        public void ViewModel_CalculateArea_ThrowsExceptionIfLengthEqualsZero()
        {
            var vm = new MainFormViewModel();
            vm.Width = "3";
            vm.Length = "0";

            Assert.Throws<ArgumentException>("Length", () => vm.GetArea());
        }

        [Theory(DisplayName = "Вычисляет площадь прямоугольника")]
        [InlineData("3", "3", 9)]
        [InlineData("5", "10", 50)]
        public void ViewModel_CalculateArea(string width, string length, int output)
        {
            var vm = new MainFormViewModel();
            vm.Width = width;
            vm.Length = length;

            int area = vm.GetArea();

            Assert.Equal(output, area);
        }

        [Theory(DisplayName = "Вычисляет периметр прямоугольника")]
        [InlineData("3", "3", 12)]
        [InlineData("5", "10", 30)]
        public void ViewModel_CalculatePerimeter(string width, string length, int output)
        {
            var vm = new MainFormViewModel();
            vm.Width = width;
            vm.Length = length;

            int perimeter = vm.GetPerimeter();

            Assert.Equal(output, perimeter);
        }
    }
}
