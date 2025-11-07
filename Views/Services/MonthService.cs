namespace Organaize.Services
{
    static public class MonthService
    {

        static public List<DateTime> GenerateMonths(int MonthCount = 12)
        {
            var currentDate = DateTime.Now;
            var months = new List<DateTime>();

            for (int i = 0; i < MonthCount; i++)
            {
                months.Add(new DateTime(currentDate.Year, currentDate.Month, 1).AddMonths(i));
            }

            return months;
        }

    }
}