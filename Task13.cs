using System.Text.RegularExpressions;
class Task13
{

    public Task13()
    {
           int digit333 = MainClass.readInteger("Введите число");
        string digToString = Convert.ToString(digit333);

        string pattern = @"(?<=^.{2}).{1}";
        RegexOptions options = RegexOptions.Multiline;

   

        foreach (Match m in Regex.Matches(digToString, pattern, options))
        {
            Console.WriteLine("Третья цифра числа - "+m.Value);
            Environment.Exit(0);
        }

         Console.WriteLine("В введенной строке отсутствует третья цифра");
    }
}