namespace Utilities
{
    public static class AlphanumericChecker
    {
        public static bool IsAlphanumeric(string input)
        {
            // Проверка на пустую строку или null
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            // Проверка каждого символа на соответствие буквам или цифрам
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
