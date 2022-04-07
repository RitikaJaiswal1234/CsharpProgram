using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratciceProgram.BasicProgrms
{
    public class Anagram
    {
        public Boolean checkAnagram(String str1, String str2)
        {

            bool Flag = false;
                
                char[] ch1 = str1.ToLower().ToCharArray();
                char[] ch2 = str2.ToLower().ToCharArray();
                Array.Sort(ch1);
                Array.Sort(ch2);
                string newstr1 = new string(ch1);
                string newstr2 = new string(ch2);

                if (newstr1 == newstr2)
                {
                   //string result= Console.WriteLine("Both the strings are Anagrams");
                 Flag = true;
                }
            return Flag;
            
        }
    }
}





    
	

