namespace LeetcodeSolutions.Solutions;

public static class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        int reversedNumber = ReverseNumber(x);
        if (reversedNumber != x)
            return false;

        return true;
    }

    private static int ReverseNumber(int num)
    {
        int reversedNumber = 0;

        while (num > 0)
        {
            int remainder = num % 10;
            reversedNumber = (reversedNumber * 10) + remainder;
            num = num / 10;
        }

        return reversedNumber;
    }
}
