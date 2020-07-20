namespace Leetcode.Problems
{
    /// <summary>
    /// 70. Climbing Stairs
    /// You are climbing a stair case. It takes n steps to reach to the top.
    /// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
    /// </summary>
    public class Problem_70
    {
        public int ClimbStairs(int n)
        {
            int LastisOneCount = 0;
            int LastisTwoCount = 0;
            if (n != 0)
            {
                LastisOneCount = 1;
                for (int i = 1; i < n; i++)
                {
                    int OldLastisOneCount = LastisOneCount;
                    int OldLastisTwoCount = LastisTwoCount;
                    LastisOneCount = OldLastisOneCount + OldLastisTwoCount;
                    LastisTwoCount = OldLastisOneCount;
                }
            }
            return LastisOneCount + LastisTwoCount;
        }
    }
}
