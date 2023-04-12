using NUnit.Framework;

namespace TestSuite
{
    public class CodeWarsTest
    {
        [Test]
        public void Test()
        {
            Assert.That(CodeWarsSolution.Add("91", "19"), Is.EqualTo("110"));
            Assert.That(CodeWarsSolution.Add("123456789", "987654322"), Is.EqualTo("1111111111"));
            Assert.That(CodeWarsSolution.Add("999999999", "1"), Is.EqualTo("1000000000"));
        }
    }
}