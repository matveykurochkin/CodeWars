namespace CodeWars.KataTask;

public class DigitalRootKata
{
    /// <summary>
    /// Рекурсивная сумма всех цифр в числе.
    /// Ссылка на задание: https://www.codewars.com/kata/541c8630095125aba6000c00
    /// </summary>
    /// <param name="n">Исходное число</param>
    /// <returns>Рекурсивная сумма</returns>
    public static int DigitalRoot(long n)
    {
        var originalNumber = Convert.ToString(n);

        var result = originalNumber.Select(digit => long.Parse(digit.ToString())).Sum();

        return result >= 10 ? DigitalRoot(result) : Convert.ToInt32(result);
    }
}