namespace CodeWars.KataTask;

public class IsANumberPrimeKata
{
    /// <summary>
    /// Определите функцию, которая принимает целочисленный аргумент и возвращает логическое значение true или false в зависимости от того, является ли целое число простым.
    /// Согласно Википедии, простое число (или a prime ) - это натуральное число, большее 1 , у которого нет положительных делителей, кроме 1 и самого себя.
    /// Ссылка на задачу: https://www.codewars.com/kata/5262119038c0985a5b00029f/train/csharp
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (var i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}