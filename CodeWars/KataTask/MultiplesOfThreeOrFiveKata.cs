namespace CodeWars.KataTask;

public class MultiplesOfThreeOrFiveKata
{
    /// <summary>
    /// Если мы перечислим все натуральные числа ниже 10, кратные 3 или 5, мы получим 3, 5, 6 и 9. Сумма этих кратных равна 23.
    /// Завершите решение так, чтобы оно возвращало сумму всех чисел, кратных 3 или 5 ниже переданное число.
    /// Кроме того, если число отрицательное, верните 0.
    /// Ссылка на задание: https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int Solution(int value)
    {
        if (value < 0)
            return 0;

        var sum = 0;

        for (var i = 0; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
                sum += i;
        }
        
        return sum;
    }
}