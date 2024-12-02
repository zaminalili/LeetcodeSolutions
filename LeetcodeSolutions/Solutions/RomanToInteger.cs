namespace LeetcodeSolutions.Solutions;

public class RomanToInteger
{
    private Dictionary<char, int> symbolValue = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

    private string[] subtraction = { "IV", "IX", "XL", "XC", "CD", "CM" };

    public int RomanToInt(string s)
    {
        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char left = s[i];
            char right = left;

            if (i != s.Length-1)
                right = s[i + 1];
            

            if (subtraction.Contains(left.ToString() + right.ToString()))
            {
                result += symbolValue[right] - symbolValue[left];
                i++;
            }
            else
                result += symbolValue[left];
        }
       
        return result;
    }

    public int RomanToIntV2(string s)
    {
        int result = 0;
        int previous = 0;

        for (int i = s.Length-1; i >= 0; i--)
        {
            int current = symbolValue[s[i]];

            if (previous > current)
                result -= current;
            else
                result += current;

            previous = current;
        }

        return result;
    }
}
