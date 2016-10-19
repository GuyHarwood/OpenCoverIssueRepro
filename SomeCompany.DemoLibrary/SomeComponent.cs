namespace SomeCompany.DemoLibrary
{
    public class SomeComponent
    {
        private readonly IProvideYear _yearProvider;

        public SomeComponent(IProvideYear yearProvider)
        {
            _yearProvider = yearProvider;
        }

        public int DoSomething(int x, int y)
        {
            var result = x + y + _yearProvider.GetYear();

            return result;
        }
    }

    public interface IProvideYear
    {
        int GetYear();
    }
}