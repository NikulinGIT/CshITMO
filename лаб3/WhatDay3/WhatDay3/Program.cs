﻿using System;


namespace WhatDay3
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class WhatDay
    {
        static void Main()
        {
            try
            {
                Console.Write("Please enter the year: ");
                string line = Console.ReadLine();
                int yearNum = int.Parse(line);
                
                bool isLeapYear = (yearNum % 4 == 0)
                && (yearNum % 100 != 0
                || yearNum % 400 == 0);
                int maxDayNum = isLeapYear ? 366 : 365;

                Console.Write("Please enter a day number between 1 and {0}: ", maxDayNum);
                line = Console.ReadLine();
                int dayNum = int.Parse(line);




                if (dayNum < 1 || dayNum > maxDayNum)
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }

                //if (isLeapYear)
                //{
                //    Console.WriteLine(" IS a leap year");
                //}
                //else
                //{
                //    Console.WriteLine(" is NOT a leap year");
                //}



                int monthNum = 0;



                int[] DaysInLeapMonths = { 31, 29, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
                int[] DaysInMonths = { 31, 28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
                if (isLeapYear)
                {
                    foreach (int daysInMonth in DaysInLeapMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }
                else
                {
                    foreach (int daysInMonth in DaysInMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }

                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();

                Console.WriteLine("{0} {1}", dayNum, monthName);
            }
            catch (Exception caught)
            {
                Console.WriteLine(caught);
            }
        }
    }

    }
