using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestXamarin.Test.Init;
using Xamarin.UITest;

namespace TestXamarin.Test
{
    [TestFixture(Platform.Android)]
    public class LoginTest
    {
        IApp app;
        Platform platform;

        public LoginTest(Platform platform) => this.platform = platform;

        [SetUp]
        public void BeforeEachTest()=> app = AppInitializer.StartApp(platform);

        [Test]
        public void ShouldBeAbleToLogin()
        {
            Login();
        }
        public void Login()
        {
            app.Tap("entryNameId");
            app.EnterText("Juan");
            app.DismissKeyboard();
        }
    }
}
