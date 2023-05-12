using System.Text.RegularExpressions;

namespace Co.Brick_TestTask
{
    public class MarkdownParser
    {
        public string GetFormattedText(string input) => ParseMarkup(input);

        private string ParseMarkup(string input)
        {
            string pattern = @"^(\#{1,6}) (.*)";
            Regex rx = new Regex(pattern);
            MatchCollection matches = rx.Matches(input);
            Match? match = matches.FirstOrDefault();

            if (match == null || match.Groups.Count != 3)
            {
                return input;
            }

            string hashtags = match.Groups[1].Value;
            string inputText = match.Groups[2].Value;

            if (inputText[0] == ' ')
            {
                return input;
            }

            return GetTextWithTags(hashtags, inputText);
        }

        private string GetTextWithTags(string hashtags, string text)
        {
            string[] tags = GetTags(hashtags);

            return $"{tags[0]}{text}{tags[1]}";
        }

        private string[] GetTags(string hashtags)
        {
            int hashtagsCount = hashtags.Length;

            return new string[] { $"<h{hashtagsCount}>", $"</h{hashtagsCount}>" };
        }
    }
}
