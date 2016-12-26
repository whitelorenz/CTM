using CTM.Support;
using NUnit.Framework;

namespace CTM
{
    [SetUpFixture]
    public class SetUpFixture
    {
        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Browser.Driver();
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Browser.Driver().Quit();
        }
    }
}
