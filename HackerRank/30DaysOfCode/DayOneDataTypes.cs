﻿using System;
namespace HackerRank.DaysOfCode
{
    public class DayOneDataTypes
    {
        public DayOneDataTypes()
        {
            Console.WriteLine("From Day One");

            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int number;
            //float 32-bit; double 64-bit; and decimal 128-bit
            double dobuleNumber;
            string text;

            int.TryParse(Console.ReadLine(), out number);
            double.TryParse(Console.ReadLine(), out dobuleNumber);
            text = Console.ReadLine();

            Console.WriteLine(i+number);
            Console.WriteLine("{0:0.0}",d +dobuleNumber);
            Console.WriteLine(s + text);

            #region Task Details
//            Task
//Complete the code in the editor below.The variables, , and  are already declared and initialized for you.You must:
//Declare  variables: one of type int, one of type double, and one of type String.
//Read  lines of input from stdin (according to the sequence given in the Input Format section below) and initialize your variables.
//Use the  operator to perform the following operations:
//            Print the sum of  plus your int variable on a new line.
//            Print the sum of plus your double variable to a scale of one decimal place on a new line.
//           Concatenate  with the string you read as input and print the result on a new line.
            #endregion
        }
    }
}
