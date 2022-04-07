using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratciceProgram.BasicProgrms
{
    public class FactorialNumber
    {
			public int factorialOfGivenNumber(int number)
			{
				int factorial = 1;
				for (int i = 1; i <= number; i++)
					factorial = factorial * i;
				return factorial;
			}
		}
}
