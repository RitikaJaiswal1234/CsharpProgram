using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratciceProgram.BasicProgrms
{
    public class PrimeNumber
    {
        public Boolean CheckPrime(int number)
        {
            //int count = 0;
            Boolean flag = true;
            if (number == 1 || number == 0 || number < 0)
            {
                flag = false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    flag = false;
                }//if close
            }//for close
            return flag;
        }
    }
}
