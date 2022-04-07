using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratciceProgram.BasicProgrms
{ 

	public class ReverseString
	{
		public String stringReverse(String input)
		{
			String dummy = "";
			for (int i = input.Length - 1; i >= 0; i--)
			{
				dummy = dummy + input[i];
			}
			return dummy;
		}
	}
}
