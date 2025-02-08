using NUnit.Framework;

namespace TestSuite;

[TestFixture]
public class CodeWarsTest
{
    [Test]
    public void SampleTests()
    {
        Assert.That(CodeWarsSolution.ToUnderscore("TestController"), Is.EqualTo("test_controller"));
        Assert.That(CodeWarsSolution.ToUnderscore("ThisIsBeautifulDay"), Is.EqualTo("this_is_beautiful_day"));
        Assert.That(CodeWarsSolution.ToUnderscore("Am7Days"), Is.EqualTo("am7_days"));
        Assert.That(CodeWarsSolution.ToUnderscore("My3CodeIs4TimesBetter"), Is.EqualTo("my3_code_is4_times_better"));
        Assert.That(CodeWarsSolution.ToUnderscore("ArbitrarilySendingDifferentTypesToFunctionsMakesKatasCool"), Is.EqualTo("arbitrarily_sending_different_types_to_functions_makes_katas_cool"));
        Assert.That(CodeWarsSolution.ToUnderscore(1), Is.EqualTo("1"), "Numbers should be turned to strings!");
    }
}