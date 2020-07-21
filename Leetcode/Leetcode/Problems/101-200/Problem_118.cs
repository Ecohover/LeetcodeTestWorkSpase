using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Problems
{
    /// <summary>
    /// 118. Pascal's Triangle
    /// Given numRows, generate the first numRows of Pascal's triangle.
    /// For example, given numRows = 5,
    /// Return
    /// [
    ///      [1],
    ///     [1,1],
    ///    [1,2,1],
    ///   [1,3,3,1],
    ///  [1,4,6,4,1]
    /// [1,5,10,10,5,1]
    /// ]
    /// </summary>
    public class Problem_118
    {
        public Mylist<Mylist<int>> Generate(int numRows)
        {
            Mylist<Mylist<int>> result = new Mylist<Mylist<int>>();
            Mylist<int> mylist = new Mylist<int>();
            if (numRows > 0)
            {
                mylist.Add(0, 1);
                result.Add(0, mylist);
                for (int i = 1; i < numRows; i++)
                {
                    result.Add(i, GetNextLevel(result.GetbyKey(i - 1)));
                }
            }

            return result;
        }
        public Mylist<int> GetNextLevel(Mylist<int> olddic)
        {
            Mylist<int> newlist = new Mylist<int>();
            newlist.Add(0, 1);
            for (int i = 0; i < olddic.Count() - 1; i++)
            {
                newlist.Add(i + 1, olddic[i] + olddic[i + 1]);
            }
            newlist.Add(olddic.Count(), 1);
            return newlist;
        }

        public class Mylist<T> : List<T>
        {
            Dictionary<int, T> map = new Dictionary<int, T>();
            public void Add(int i, T t)
            {
                map.Add(i, t);
                this.Add(t);
            }
            public T GetbyKey(int key)
            {
                return map[key];
            }
        }
    }
}
