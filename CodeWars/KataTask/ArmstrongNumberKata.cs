namespace CodeWars.KataTask;

public class ArmstrongNumberKata
{
    /// <summary>
    /// Нарциссическое число (или число Армстронга) - это положительное число, представляющее собой сумму собственных цифр,
    /// каждая из которых возведена в степень числа цифр в заданном основании.
    /// Ссылка на задание: https://www.codewars.com/kata/5287e858c6b5a9678200083c/train/csharp
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static bool Narcissistic(int value)
    {
        var stringNumber = value.ToString();
        var sum = stringNumber.Sum(digit => (long)Math.Pow((long)char.GetNumericValue(digit), stringNumber.Length));
        return value == sum;
    }
}