using System.Text.RegularExpressions;

namespace CodeWars.KataTask;

public class SumOfIntegersInStringKata
{
    /// <summary>
    /// Функция, которая вычисляет сумму целых чисел внутри строки
    /// Ссылка на задачу: https://www.codewars.com/kata/598f76a44f613e0e0b000026
    /// </summary>
    /// <param name="s">Входная строка</param>
    /// <returns>Сумма чисел во входной строке</returns>
    public static int SumOfIntegersInString(string s)
    {
        var numbers = Regex.Matches(s, @"\d+")
            .Select(m => int.Parse(m.Value));

        return numbers.Sum();
    }
}