namespace Leetcode.Problems
{
    /// <summary>
    /// 263. UglyNumber
    /// Write a program to check whether a given number is an ugly number.
    /// Ugly numbers are positive numbers whose prime factors only include 2, 3, 5. For example, 6, 8 are ugly
    /// while 14 is not ugly since it includes another prime factor 7.
    /// Note that 1 is typically treated as an ugly number.
    /// </summary>
    public class Problem_263
    {
        public bool IsUgly(int num)
        {

            if (num == 0) return false;
            num = Check(num, 2);
            num = Check(num, 3);
            num = Check(num, 5);
            if (num == 1) return true;
            else return false;
        }

        public int Check(int cNum, int fNum)
        {
            if (cNum % fNum != 0)
            {
                return cNum;
            }
            else
            {
                cNum = cNum / fNum;
                cNum = Check(cNum, fNum);
                return cNum;
            }

        }
    }
}
