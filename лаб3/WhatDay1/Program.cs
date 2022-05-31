using System;
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
        Console.Write("Please enter a day number between 1 and 365: ");
        string line = Console.ReadLine();
        int dayNum = int.Parse(line);
        int monthNum = 0;
        int[] DaysInMonths = {31,28,31,30,31, 30, 31, 30, 31, 30, 31, 30 };
        int i = 0;
        foreach (int dayInMonth in DaysInMonths)
        {
            if (dayNum <= dayInMonth)
            {
                break;
            }
            else
            {
                dayNum -= dayInMonth;
                monthNum++;
            }
        }

        MonthName temp = (MonthName)monthNum;
        string monthName = temp.ToString();

        Console.WriteLine("{0} {1}", dayNum, monthName);


    }

}
