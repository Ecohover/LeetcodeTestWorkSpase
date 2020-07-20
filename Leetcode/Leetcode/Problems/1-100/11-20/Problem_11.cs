namespace Leetcode.Problems
{
    /// <summary>
    /// 11. Container With Most Water
    /// Given n non-negative integers a1, a2, ..., an,
    /// where each represents a point at coordinate (i, ai).
    /// n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0).
    /// Find two lines, which together with x-axis forms a container,
    /// such that the container contains the most water.

    /// Note: You may not slant the container.
    /// </summary>
    public class Problem_11
    {
        public int MaxArea(int[] height)
        {
            int MaxArea = 0;
            int Right = height.Length - 1;
            int Left = 0;
            int TempH = 0;
            int TempW = 0;
            int TempArea = 0;
            while (true)
            {
                TempH = height[Right] > height[Left] ? height[Left] : height[Right];
                TempW = Right - Left;
                TempArea = TempH * TempW;
                MaxArea = MaxArea > TempArea ? MaxArea : TempArea;
                if (height[Right] > height[Left])
                {
                    Left++;
                }
                else
                {
                    Right--;
                }
                if (TempW <= 0) break;
            }
            return MaxArea;
        }
    }
}
