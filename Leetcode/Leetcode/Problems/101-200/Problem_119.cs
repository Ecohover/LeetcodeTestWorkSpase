using System.Collections.Generic;

namespace Leetcode.Problems
{
    /// <summary>
    /// 119. Pascal's Triangle II
    /// Given an index k, return the kth row of the Pascal's triangle.
    /// For example, given k = 3,
    /// Return [1,3,3,1].
    /// Note:
    /// Could you optimize your algorithm to use only O(k) extra space?
    /// </summary>
    public class Problem_119
    {
        public List<int> GetRow(int rowIndex)
        {
            List<int> list = new List<int>();
            list.Add(1);
            for (int i = 1; i <= rowIndex; i++)
            {
                int startj;
                int startk;
                if (i % 2 == 0)//奇
                {
                    list[i / 2] = list[i / 2] + list[i / 2 - 1];
                    startj = i / 2 - 1;
                    startk = i / 2 + 1;
                }
                else
                {
                    startj = i / 2;
                    startk = i / 2 + 1;
                }
                for (int j = startj, k = startk; j > 0 && k < i; j--, k++)
                {
                    list[j] = list[j] + list[j - 1];
                    list[k] = list[j];
                }


                list.Add(1);
            }
            return list;
        }
    }
}
