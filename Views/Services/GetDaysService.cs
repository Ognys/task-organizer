namespace Organaize.Services
{
    static public class GetDaysService
    {

    static public List<DateTime> GetDays(int index)
    {
        var months = MonthService.GenerateMonths();

        var selectMonth = months[index];
        var daysInMonth = DateTime.DaysInMonth(selectMonth.Year, selectMonth.Month);
        var days = new List<DateTime>();

        for (int i = 1; i <= daysInMonth; i++)
        {
            days.Add(new DateTime(selectMonth.Year, selectMonth.Month, i));
        }

        return days;
    }
    }
}