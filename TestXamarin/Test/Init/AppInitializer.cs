using Xamarin.UITest;
using Xamarin.UITest.Utils;

namespace TestXamarin.Test.Init
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
                return ConfigureApp
                         .Android
                         .ApkFile("D:/Selenium in c#/UnitTestXamarin/UnitTestXamarin/UnitTestXamarin.Android/bin/Release/com.companyname.unittestxamarin.apk")
                         .WaitTimes(new WaitTimes())
                         .StartApp();
            return ConfigureApp.iOS
                                .WaitTimes(new WaitTimes())
                                .StartApp();
        }

        public class WaitTimes : IWaitTimes
        {
            public TimeSpan GestureCompletionTimeout => TimeSpan.FromMinutes(1);

            public TimeSpan GestureWaitTimeout => TimeSpan.FromMinutes(1);

            public TimeSpan WaitForTimeout => TimeSpan.FromMinutes(1);
        }
    }
}
