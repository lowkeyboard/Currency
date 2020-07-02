//a beginner c# program for practice. this was supposed to be a currency converter (: 
//program that continues to divide and display the both results and remainders. 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace Currency
{
    class Program
    {

         static int remainder;
         static List<int> quotients = new List<int>();
        static int resultoF;
        private static string UnderFive(int num)
         {

            for (int j = num / 5; j < 5; j--)
            {
                
                remainder = num % 5;
                num = num / 5;

                Console.WriteLine("remainder: " + remainder);
                Console.WriteLine("quotient: " + num);
                break;

            }

            string toDisplay = ("rem:" + remainder + "quo" + num);

            return toDisplay;

           

        }

         private static string  OverEqualFive(int num)
        {
            do
            {


                for (int i = num / 5; i >= 5; i--)
                { 
                    remainder = num % 5;
                    num /= 5;

                    Console.WriteLine("quotient: " + num);

                    Console.WriteLine("remainder: " + remainder);


                    if (num < 5)
                    {
                        break;
                    }

                    
                    quotients.Add(num);
                    Quotients(num);
                    
                    


                }
            }
            while (num / 5 >= 5);

            string toDisplay = ("rem:" + SumOfKl(remainder) + "quo" + num);

            return toDisplay;
        }

        public static string Quotients(int quotient)
        {


            foreach (int b in quotients)
            {
                if (b >= 2)
                {
                    theTwoCase(b);
                }

                else
                {
                     //
                }
            }

            



            string toDisplay = ("b<2" +resultoF );

            return toDisplay;
        }



        public static List<int> SumOfKl (int remainder)
        {

            List<int> remainderlar = new List<int>();
            remainderlar.Add(remainder);

            

            return remainderlar;
        }

        public static string theTwoCase (int quotient)
        {
            int nick = quotient % 10;
            int dime = quotient - nick;

            string toDisplay = ("dime: " + dime + "nick: " + nick);

            return toDisplay;

        }

        static void Main(string[] args)
        {

            int num = 38;
            

            if (num / 5 < 5)
            {
                UnderFive(num);

            }

            else 
            {
                OverEqualFive(num);

            }




        }
    }
}
