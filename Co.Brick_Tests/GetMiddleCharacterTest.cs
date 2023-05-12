using Co.Brick_TestTask;

namespace Co.Brick_Tests
{
    public class Tests
    {
        [Test]
        [TestCase("es", "test")]
        [TestCase("t", "testing")]
        [TestCase("dd", "middle")]
        [TestCase("A", "A")]
        [TestCase("my", "my")]
        public void GetMiddleCharacter(string expected, string input)
        {
            Assert.That(StringHandler.GetMiddleCharacter(input), Is.EqualTo(expected));
        }
    }
}