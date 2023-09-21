namespace CodeWars.KataTask;

public class PersistentKata
{
    /// <summary>
    /// Напишите функцию, persistence, которая принимает положительный параметр num и возвращает его мультипликативную персистентность,
    /// то есть количество раз, которое вы должны перемножить цифры num, пока не получите однозначную цифру.
    /// Ссылка на задачу: https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec/train/csharp
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int Persistence(long n)
    {
        if (n < 10)
            return 0;

        var currentNumber = Convert.ToString(n);

        var counter = 0;

        long resultNumber = 100;

        while (resultNumber >= 10)
        {
            resultNumber = currentNumber.Select(digit => long.Parse(digit.ToString()))
                .Aggregate<long, long>(1, (current, digit) => current * digit);
            counter++;
            currentNumber = Convert.ToString(resultNumber);
        }

        return counter;
    }
}