using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Extension
{
    public static class CharExtension
    {
        public static bool CheckInt(this char chr)
        {
            bool Result = false;
            if (chr == '0' || chr == '1' || chr == '2' || chr == '3' || chr == '4'
              || chr == '5' || chr == '6' || chr == '7' || chr == '8' || chr == '9')
            {
                Result = true;
            }
            return Result;
        }

        public static bool CheckSign(this char chr)
        {
            bool Result = false;
            if (chr == '-' || chr == '+') Result = true;
            return Result;
        }
    }
}
