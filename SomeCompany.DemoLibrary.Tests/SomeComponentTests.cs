using NSubstitute;
using NUnit.Framework;

namespace SomeCompany.DemoLibrary.Tests
{
    [TestFixture]
    public class SomeComponentTests
    {
        [Test]
        public void SumCorrect()
        {
            var yearProviderMock = Substitute.For<IProvideYear>();
            var currentYear = 2016;
            var x = 123;
            var y = 456;

            yearProviderMock.GetYear().Returns(currentYear);

            var sut = new SomeComponent(yearProviderMock);

            var expected = currentYear + x + y;

            var actual = sut.DoSomething(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}