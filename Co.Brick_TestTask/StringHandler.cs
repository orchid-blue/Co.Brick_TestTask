namespace Co.Brick_TestTask
{
    public static class StringHandler
    {
        public static string GetMiddleCharacter(string input)
        {
            int length = input.Length;
            if (length == 1 || length == 2)
            {
                return input;
            }

            int wholePart = length / 2;
            string result = input[wholePart].ToString();

            bool isEven = (length % 2) == 0;
            if (isEven)                
            {
                return input[wholePart - 1] + result;
            }

            return result;
        }
    }
}
