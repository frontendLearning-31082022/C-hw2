using System.Text.RegularExpressions;
using System.Globalization;
class Task15
{

    public Task15()
    {
        int digit333 = MainClass.readInteger("Введите число");
        string digToString = Convert.ToString(digit333);


        DateTime now = DateTime.Now;
        string choosedDate = now.ToString("dd/MM/yyyy HH:mm:ss");
        choosedDate = Regex.Replace(choosedDate, @"^\d*\.", digToString + ".");
        Console.WriteLine(choosedDate);

        choosedDate = Regex.Replace(choosedDate, @"\s.*", "");
        Match m = Regex.Match(choosedDate, @"^\d\.", RegexOptions.IgnoreCase);
        if (m.Success) { choosedDate = "0" + choosedDate; }

        try
        {
            DateTime dt = DateTime.ParseExact(choosedDate, "dd.MM.yyyy", new CultureInfo("ru-RU"));

            if ((DayOfWeek)Enum.Parse(typeof(DayOfWeek), "Sunday") == dt.DayOfWeek
               || (DayOfWeek)Enum.Parse(typeof(DayOfWeek), "Saturday") == dt.DayOfWeek)
            {
                Console.WriteLine("Это выходной день");
            }
            else
            {
                Console.WriteLine("Это будний день");
            }

        }
        catch (Exception)
        {
            Console.WriteLine("Введен неправильный день");
        }


    }
}