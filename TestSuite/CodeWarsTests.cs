using CodeSuite;

namespace TestSuite;

public class Tests
{
    [Test]
    public void TestCodeWarsSolution()
    {
        Assert.That(CodeWarsSolution.Scramble("rkqodlw", "world"), Is.EqualTo(true));
        Assert.That(CodeWarsSolution.Scramble("cedewaraaossoqqyt", "codewars"), Is.EqualTo(true));
        Assert.That(CodeWarsSolution.Scramble("katas", "steak"), Is.EqualTo(false));
        Assert.That(CodeWarsSolution.Scramble("scriptjavx", "javascript"), Is.EqualTo(false));
        Assert.That(CodeWarsSolution.Scramble("scriptingjava", "javascript"), Is.EqualTo(true));
        Assert.That(CodeWarsSolution.Scramble("scriptsjava", "javascripts"), Is.EqualTo(true));
        Assert.That(CodeWarsSolution.Scramble("javscripts", "javascript"), Is.EqualTo(false));
        Assert.That(CodeWarsSolution.Scramble("aabbcamaomsccdd", "commas"), Is.EqualTo(true));
        Assert.That(CodeWarsSolution.Scramble("commas", "commas"), Is.EqualTo(true));
        Assert.That(CodeWarsSolution.Scramble("sammoc", "commas"), Is.EqualTo(true));
    }
}
