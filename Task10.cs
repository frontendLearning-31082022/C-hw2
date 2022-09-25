using System.Text.RegularExpressions;
class Task10
{

    public Task10()
    {
        int digit333 = MainClass.readInteger("Введите трехзначное число");
        string digToString = Convert.ToString(digit333);

        if (digToString.Length > 3 || digToString.Length < 3)
        {
            Console.WriteLine("Введено не трехзначное число. Ошибка");
            Environment.Exit(1);
        }

        Console.WriteLine("Вторая цифра числа");
        string pattern = @"(?<=^.{1}).{1}";
        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(digToString, pattern, options))
        {
            Console.WriteLine(m.Value);
            break;
        }

    }
}