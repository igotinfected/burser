using NUnit.Framework;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Burser.UiTests.Tests;

public class MainPageTests : BaseTest
{
    private readonly Query _countButton = x => x.Marked("IncrementButton");

    public MainPageTests(Platform platform)
        : base(platform)
    {
    }

    [Test]
    public void TapOneTime()
    {
        //check if button is on screen (a.k.a. Arrange)
        App.WaitForElement(_countButton);

        //tap on button (a.k.a. Action)
        App.Tap(_countButton);


        // check label updated and screenshot(a.k.a. Assert)
        var buttonLabelValue = "Clicked 1 time";
        Assert.DoesNotThrow(() => App.WaitForElement(x => x.Marked(buttonLabelValue)), "Button was not clicked");
        App.Screenshot("Tapped 1 time");
    }

    [Test]
    public void TapTwoTimes()
    {
        //check if button is on screen (a.k.a. Arrange)
        App.WaitForElement(_countButton);

        //tap on button (a.k.a. Action)
        App.Tap(_countButton);
        App.Screenshot("Tapped 1 time");
        App.Tap(_countButton);

        // check label updated and screenshot(a.k.a. Assert)
        var buttonLabelValue = "Clicked 2 times";
        Assert.DoesNotThrow(() => App.WaitForElement(x => x.Marked(buttonLabelValue)), "Button was not clicked");
        App.Screenshot("Tapped 2 times");
    }

    [Test]
    public void Repl() => App.Repl();
}
