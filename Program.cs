bool IsPermutationOfPalindrome(string input)
{
    var charCounts = new Dictionary<char, int>();

    foreach (char c in input.ToLower())
    {
        if (char.IsWhiteSpace(c)) continue;

        if (!charCounts.ContainsKey(c))
            charCounts[c] = 0;

        charCounts[c]++;
    }

    int oddCount = 0;

    foreach (int count in charCounts.Values)
    {
        if (count % 2 != 0)
        {
            oddCount++;
            if (oddCount > 1) return false;
        }
    }

    return true;
}

IsPermutationOfPalindrome("ala ma kota");
