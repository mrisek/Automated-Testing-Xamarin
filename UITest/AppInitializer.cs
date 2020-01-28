using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Utils;

namespace UITest
{
    // Android emulators are slow, give some time for test.

    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .InstalledApp("com.companyname.automatedtesting")
                    .EnableLocalScreenshots()
                    .DeviceSerial("emulator-5554")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}