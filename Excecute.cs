using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PratciceProgram.BasicProgrms
{
    public class Excecute
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("List of Programs");
            Console.WriteLine("Enter 1 for primeprogram");
            Console.WriteLine("Enter 2 for Factorial Program");
            Console.WriteLine("Enter 3 for Sum of n number Program");
            Console.WriteLine("Enter 4 for Reverse String Program");
            Console.WriteLine("Enter 5 for Anagram Program");
            Console.WriteLine("Enter 6 for Sum 2 number in aaray Program");
            Console.WriteLine("Enter your Choise");
            int Choise = int.Parse(Console.ReadLine()); 
            
            switch (Choise) {
             case 1:
                    {
                        PrimeNumber primeNumber = new PrimeNumber();
                        Console.WriteLine("Enter any number:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Boolean ans = primeNumber.CheckPrime(number);
                        if (ans == true)
                        {
                            Console.WriteLine("number is a Prime Number");
                        }
                        else 
                        {
                            Console.WriteLine("Not a Prime Number");

                        }
                        break;
                    }


             case 2:
                    {
                        FactorialNumber factorialNumber = new FactorialNumber();
                        Console.WriteLine("Enter any number:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(factorialNumber.factorialOfGivenNumber(5));
                        break;
                    }
              case 3:
                    {
                        SumOfNumber sumOfNumber = new SumOfNumber();
                        Console.WriteLine("Enter any number:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(sumOfNumber.sumofdigit(number));
                        break;
                    }
              case 4:
                    {
                        ReverseString reverseString = new ReverseString();
                        Console.WriteLine("Enter any String to be reversed:");
                        string str = Console.ReadLine();
                        Console.WriteLine("Reverse String is " + reverseString.stringReverse(str));
                        break;
                    }

               case 5:
                    {
                        Anagram anagram = new Anagram();
                        Console.WriteLine("Enter first String:");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Enter second string:");
                        string str2 = Console.ReadLine();
                        bool flag = anagram.checkAnagram(str1 , str2);
                        Console.WriteLine(flag);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Enter Size of Array");
                        int size = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the element in aaray");
                        int[] array = new int[size];
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Enter the target value");
                        int target = int.Parse(Console.ReadLine());

                        Sum2problem sumproblem = new Sum2problem();
                        int[] result = sumproblem.TargetOfSum(array, target, size);
                        Console.WriteLine("the array element " + result[0] + " + " +result[1]+ " "+" = " + target);
                        break;
                    }
                        
                    }


            }
    }
}


