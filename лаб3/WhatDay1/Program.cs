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
        if (dayNum <= 31)
        { // January
            goto End;
        }
        else
        {
            dayNum -= 31;
            monthNum++;
        }
        if (dayNum <= 28)
        { // February
            goto End;
        }
        else
        {
            dayNum -= 28;
            monthNum++;
        }
        if (dayNum <= 31)
        { // March
            goto End;
        }
        else
        {
            dayNum -= 31;
            monthNum++;
        }
        if (dayNum <= 30)
        { // April
            goto End;
        }
        else
        {
            dayNum -= 30;
            monthNum++;
        }
        if (dayNum <= 31)
        { // May
            goto End;
        }
        else
        {
            dayNum -= 31;
            monthNum++;
        }
        if (dayNum <= 30)
        { // June
            goto End;
        }
        else
        {
            dayNum -= 30;
            monthNum++;
        }
        if (dayNum <= 31)
        { // July
            goto End;
        }
        else
        {
            dayNum -= 31;
            monthNum++;
        }
        if (dayNum <= 31)
        { // August
            goto End;
        }
        else
        {
            dayNum -= 31;
            monthNum++;
        }
        if (dayNum <= 30)
        { // September
            goto End;
        }
        else
        {
            dayNum -= 30;
            monthNum++;
        }
        if (dayNum <= 31)
        { // October
            goto End;
        }
        else
        {
            dayNum -= 31;
            monthNum++;
        }
        if (dayNum <= 30)
        { // November
            goto End;
        }
        else
        {
            dayNum -= 30;
            monthNum++;
        }
        if (dayNum <= 31)
        { // December
            goto End;
        }
        else
        {
            dayNum -= 31;
            monthNum++;
        }
    End:
        MonthName temp = (MonthName)monthNum;
        string monthName = temp.ToString();

        Console.WriteLine("{0} {1}", dayNum, monthName);


    }

}
