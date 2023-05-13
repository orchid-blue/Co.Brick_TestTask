using Co.Brick_TestTask;

namespace Co.Brick_Tests
{
    public class TypeFormatValidatorTest
    {
        [Test]
        [TestCase(true, FormatType.Number, "12")]
        [TestCase(false, FormatType.Number, "12qwerty")]
        [TestCase(true, FormatType.TimeSpan, "00:00:01")]
        [TestCase(false, FormatType.TimeSpan, "00:00:01:90")]
        [TestCase(true, FormatType.Date, "13-May-23 5:38:48 PM")]
        [TestCase(false, FormatType.Date, "13-May-23 5:38:48 qa")]
        public void IsFormatTest(bool expected, FormatType inputType, string inputString)
        {            
            Assert.That(TypeFormatValidator.CanBeParsed(inputString, inputType), Is.EqualTo(expected));
        }
    }
}
