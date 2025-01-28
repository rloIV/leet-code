public class Solution {
    public int Reverse(int x)
{
    if (x == int.MinValue)
    {
        return 0;
    }

    bool isNegative = x < 0;
    if (isNegative)
    {
        x = Math.Abs(x);
    }

    string reversedString = new string(x.ToString().Reverse().ToArray());

    int reversedNumber;
    try
    {
        reversedNumber = int.Parse(reversedString);
    }
    catch
    {
        return 0;
    }

    if (isNegative)
    {
        reversedNumber *= -1;
    }

    if (reversedNumber < int.MinValue || reversedNumber > int.MaxValue)
    {
        return 0;
    }

    return reversedNumber;
}


}
