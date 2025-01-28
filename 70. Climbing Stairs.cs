public class Solution {
  public int ClimbStairs(int n)
  {
    int x = 1, y = 1;
    if (n <= 1) return 1;

    for (int i = 2; i <= n; i++)
    {
        int temp = y;
        y = y + x;
        x = temp;
    }
    return y;
  }

}
