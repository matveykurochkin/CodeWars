using System.Text.RegularExpressions;

namespace CodeWars.KataTask;

public class SolveKata
{
    /// <summary>
    /// Задача - сравнить группировки чисел и вернуть наибольшее число
    /// Ссылка на задачу: https://www.codewars.com/kata/59dd2c38f703c4ae5e000014
    /// </summary>
    /// <param name="s">Исходная строка</param>
    /// <returns>Наибольшее число</returns>
    public static int Solve(string s)
    {
        return Regex.Matches(s, @"\d+").Select(number => int.Parse(number.ToString())).Max();
    }
}