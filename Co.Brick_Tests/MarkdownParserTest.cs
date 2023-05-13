using Co.Brick_TestTask;

namespace Co.Brick_Tests
{
    public class MarkdownParserTest
    {
        [Test]
        [TestCase("<h1>Header</h1>", "# Header")]
        [TestCase("<h2>Header</h2>", "## Header")]
        [TestCase("<h6>Header</h6>", "###### Header")]
        [TestCase("####### Header", "####### Header")]
        [TestCase("###  Header", "###  Header")]
        [TestCase("Header", "Header")]
        [TestCase("", "")]
        [TestCase("<h4># Header</h4>", "#### # Header")]
        [TestCase("<h5></h5>", "##### ")]
        [TestCase("#####  ", "#####  ")]
        public void GetFormattesTest(string expected, string input)
        {
            MarkdownParser mp = new MarkdownParser();
            Assert.That(mp.GetFormattedText(input), Is.EqualTo(expected));
        }
    }
}
