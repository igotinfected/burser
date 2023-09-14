using System;
using Xamarin.UITest;
using Xamarin.UITest.Configuration;

namespace Burser.UiTests;

public static class AppInitializer
{
    public static IApp StartApp(Platform platform) => platform switch
    {
        Platform.Android => ConfigureApp.Android
            .ApkFile("../../../../Burser/bin/Debug/net7.0-android33.0/lu.igotinfected.burser.apk")
            .StartApp(AppDataMode.Clear),
        Platform.iOS => ConfigureApp.iOS
            //.InstalledApp("com.companyname.mauiuitestsample")
            .AppBundle("../../../../Burser/bin/Debug/net7.0-ios/iossimulator-x64/Burser.app")
            .StartApp(AppDataMode.Clear),
        _ => throw new NotSupportedException()
    };
}
