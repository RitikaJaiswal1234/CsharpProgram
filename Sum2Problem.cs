using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratciceProgram.BasicProgrms
{
    public class Sum2Problem
    {
        public int[] TargetOfSum(int[] array, int target, int size)
        {
            int[] result = new int[2];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        result[0] = array[i];
                        result[1] = array[j];
                    }
                }
            }
            return result;
        }
    }
}

