using NUnit.Framework;

namespace TestSuite
{
    public class CodeWarsTest
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(
                "apples, pears\ngrapes\nbananas",
                CodeWarsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));

            Assert.AreEqual("a\nc\nd", CodeWarsSolution.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));
        }
    }
}