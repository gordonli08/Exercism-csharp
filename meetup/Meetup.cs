using System;
using System.Linq;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private int month;
    private int year;
    public Meetup(int month, int year)
    {
        this.month = month;
        this.year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var daysMatching = Enumerable
            .Range(1,DateTime.DaysInMonth(this.year,this.month))
            .Select(day => new DateTime(this.year,this.month,day))
            .Where(day => day.DayOfWeek == dayOfWeek)
            .ToList();
        
        var meetup = new DateTime();
        if (schedule == Schedule.Teenth) {
            meetup = daysMatching.Where(day => day.Day >= 13).First();
        } else if (schedule == Schedule.Last) {
            meetup = daysMatching.Last();
        } else {
            meetup = daysMatching[(int)schedule - 1];
        }
        return meetup;
    }
}