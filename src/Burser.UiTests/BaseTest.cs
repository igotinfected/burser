using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace Burser.UiTests;

[TestFixture(Platform.Android)]
[TestFixture(Platform.iOS)]
public class BaseTest
{
    [SetUp]
    public virtual void BeforeEachTest()
    {
        _app = AppInitializer.StartApp(Platform);

        App.Screenshot("App Initialized");
    }

    private IApp _app;
    protected IApp App => _app ?? throw new NullReferenceException();

    protected readonly Platform Platform;

    protected BaseTest(Platform platform) => Platform = platform;
}
