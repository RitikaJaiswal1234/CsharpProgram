using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratciceProgram.BasicProgrms
{
    public class SumOfNumber
    {
        public int sumofdigit(int number)
        {
            int i, sum = 0;
            for (i = 1; i <= number; i++)
                sum = sum + i;
            return sum;
        }
    }
}
