using System.Globalization;

namespace CodeWars.KataTask;

public class CheckCouponKata
{
    /// <summary>
    /// Написать вызываемую функциюcheckCoupon, которая проверяет, действителен ли код купона и не истек ли срок его действия.
    /// Купон больше не действителен на следующий день, ПОСЛЕ истечения срока действия. Все даты будут передаваться в виде строк в этом формате: "MONTH DATE, YEAR"
    /// Ссылка на задачу: https://www.codewars.com/kata/539de388a540db7fec000642/train/csharp
    /// </summary>
    /// <param name="enteredCode">Код купона введенный пользователем</param>
    /// <param name="correctCode">Корректный код купона</param>
    /// <param name="currentDate">Текущая дата</param>
    /// <param name="expirationDate">Дата истечения купона</param>
    /// <returns></returns>
    public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
    {
        if (enteredCode != correctCode)
            return false;

        var culture = new CultureInfo("en-US");

        var currentDateParse = DateTime.ParseExact(currentDate, "MMMM d, yyyy", culture);
        var expirationDateParse = DateTime.ParseExact(expirationDate, "MMMM d, yyyy", culture);

        return currentDateParse <= expirationDateParse;
    }
}