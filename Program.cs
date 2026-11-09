Console.WriteLine(IsPalindrome("Топот"));
Console.WriteLine(IsPalindrome("А роза упала на лапу Азора"));
Console.WriteLine(IsPalindrome("Привет"));

static bool IsPalindrome(string text)
{
    var letters = new List<char>();

    foreach (char symbol in text)
    {
        if (!char.IsWhiteSpace(symbol))
        {
            letters.Add(char.ToLowerInvariant(symbol));
        }
    }

    for (int left = 0, right = letters.Count - 1; left < right; left++, right--)
    {
        if (letters[left] != letters[right])
        {
            return false;
        }
    }

    return true;
}