namespace Leetcode.Problems
{
    /// <summary>
    /// 264. UglyNumber2
    /// Write a program to find the n-th ugly number.
    /// Ugly numbers are positive numbers whose prime factors only include 2, 3, 5.
    /// For example, 1, 2, 3, 4, 5, 6, 8, 9, 10, 12 is the sequence of the first 10 ugly numbers.
    /// Note that 1 is typically treated as an ugly number.
    /// </summary>
    public class Problem_264
    {
        public int NthUglyNumber(int n)
        {
            int[] Ugly = new int[n];

            int factor2 = 2;
            int factor3 = 3;
            int factor5 = 5;
            int Index2 = 0;
            int Index3 = 0;
            int Index5 = 0;

            Ugly[0] = 1;
            for (int i = 1; i < n; i++)
            {
                Ugly[i] = Min(Min(factor2, factor3), factor5);

                if (Ugly[i] == factor2) factor2 = 2 * Ugly[++Index2];
                if (Ugly[i] == factor3) factor3 = 3 * Ugly[++Index3];
                if (Ugly[i] == factor5) factor5 = 5 * Ugly[++Index5];
            }
            return Ugly[n - 1];
        }

        public int Min(int num1, int num2)
        {
            if (num1 > num2) return num2;
            else return num1;
        }
    }
}
