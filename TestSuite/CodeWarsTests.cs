using CodeSuite;

namespace TestSuite;

public class Tests
{
    [Test]
    public void TestCodeWarsSolution1()
    {
        CodeWarsSolution d = new CodeWarsSolution();
        Assert.That(d.Decompose(11), Is.EqualTo("1 2 4 10"));
    }

    [Test]
    public void TestCodeWarsSolution2()
    {
        CodeWarsSolution d = new CodeWarsSolution();
        Assert.That(d.Decompose(50), Is.EqualTo("1 3 5 8 49"));
    }

    [Test]
    public void TestCodeWarsSolution3()
    {
        CodeWarsSolution d = new CodeWarsSolution();
        Assert.That(d.Decompose(4), Is.EqualTo(null));
    }

    [Test]
    public void TestCodeWarsSolution5()
    {
        CodeWarsSolution d = new CodeWarsSolution();
        Assert.That(d.Decompose(9927447), Is.EqualTo("1 3 17 87 4455 9927446"));
    }
}
