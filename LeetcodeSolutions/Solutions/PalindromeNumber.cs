namespace LeetcodeSolutions.Solutions;

public static class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        string xString = x.ToString();

        int i = 0;
        int j = xString.Length - 1;

        while (i < j)
        {
            if (xString[i] != xString[j])
                return false;
            i++;
            j--;
        }

        return true;
    }
}
