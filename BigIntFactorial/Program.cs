﻿using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigIntFactorial
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("big int calc, input number");
        //    int userNum = int.Parse(Console.ReadLine());

        //    BigInteger result = userNum;
        //    for(int i = 1; i < userNum; i++)
        //    {
        //        result = result * i;
        //        Console.WriteLine(result);
        //    }
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a No. to reverse");
        //    int Number = int.Parse(Console.ReadLine());
        //    int Reverse = 0;
        //    while (Number > 0)
        //    {
        //        int remainder = Number % 10;
        //        Reverse = (Reverse * 10) + remainder;
        //        Number = Number / 10;
        //    }
        //    Console.WriteLine("Reverse No. is {0}", Reverse);
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("input word to check for palindrome");
        //    var userString = Console.ReadLine();

        //    var noSpace = userString.ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray();
        //    var flipped = noSpace.Reverse().ToArray();
        //    var noSpaceString = new String(noSpace);
        //    var flippedString = new String(flipped);
        //    Console.WriteLine(noSpaceString);
        //    Console.WriteLine(flippedString);

        //    if (noSpaceString == flippedString)
        //    {
        //        Console.WriteLine("true");
        //    }
        //    else if (noSpaceString != flippedString)
        //    {
        //        Console.WriteLine("false");
        //    }
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    //fibonacci calc
        //    Console.WriteLine("enter the nth number you would like me to calculate in the fibonacci sequence");
        //    var userNum = int.Parse(Console.ReadLine());

        //    BigInteger a = 0;
        //    BigInteger b = 1;
        //    BigInteger c = 0;
        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //    for(int i = 0; i< userNum; i++)
        //    {
        //        c = a + b;
        //        Console.WriteLine(c);
        //        a = b;
        //        b = c;
        //    }
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    for(var i = 1; i <= 100; i++)
        //    {
        //        if(i%3 == 0 && i%5 == 0)
        //        {
        //            Console.WriteLine("Fizz Buzz");
        //        }
        //        else if (i%3 == 0)
        //        {
        //            Console.WriteLine("Fizz");
        //        }
        //        else if(i%5 == 0)
        //        {
        //            Console.WriteLine("Buzz");
        //        }
        //        else
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    //number flipper take two
        //    Console.WriteLine("input number to reverse");
        //    var flipped = int.Parse(new String(Console.ReadLine().Reverse().ToArray()));
        //    Console.WriteLine(flipped);
        //    Console.ReadKey();

        //}
        //}
        //}



        //        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        //        {
        //            int max = -1;

        //            for (int i = 0; i < keyboards.Count(); i++)
        //            {
        //                for (int j = 0; j < drives.Count(); j++)
        //                {
        //                    if (keyboards[i] + drives[j] <= b && keyboards[i] + drives[j] > max)
        //                        max = keyboards[i] + drives[j];
        //                }
        //            }
        //            return max;
        //        }
        //    }
        //}


        static int ActivityNotifications(int[] expenditure, int d)
        {
            var dailyMedian = 0;
            var trailingDaysToCheck = new int[d];
            Array.Copy(expenditure, trailingDaysToCheck, d);
            var trailingDaysInOrder = trailingDaysToCheck.OrderByDescending(num => num);
            var theArrayToCheck = trailingDaysInOrder.ToArray();
            var notifications = 0;
            var middle1 = 0;
            var middle2 = 0;
            var daytoCheck = d + 1;

            if (d % 2 == 0)
            {
                middle1 = theArrayToCheck[d / 2];
                middle2 = theArrayToCheck[d / 2] - 1;
                dailyMedian = (middle1 + middle2) / 2;
            }
            else
            {
                dailyMedian = theArrayToCheck[d / 2];
            }

            if (expenditure.Length < d)
            {
                return 0;
            }

            while (daytoCheck < expenditure.Length)
            {
                if (expenditure[daytoCheck] >= dailyMedian * 2)
                {
                    notifications++;
                    daytoCheck++;
                }
            }
            return notifications;
        }
    }
}

