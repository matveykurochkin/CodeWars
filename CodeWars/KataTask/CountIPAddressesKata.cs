namespace CodeWars.KataTask;

// ReSharper disable once InconsistentNaming
public class CountIPAddressesKata
{
    /// <summary>
    /// Реализуйте функцию, которая получает два адреса IPv4 и возвращает количество адресов между ними (включая первый, исключая последний).
    /// Все входные данные будут действительными адресами IPv4 в виде строк. Последний адрес всегда будет больше первого.
    /// Ссылка на задание: https://www.codewars.com/kata/526989a41034285187000de4/train/csharp
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public static long IpsBetween(string start, string end)
    {
        var startIp = start
            .Split('.')
            .Select(digit => int.Parse(digit.ToString())).ToArray();

        var endIp = end
            .Split('.')
            .Select(digit => int.Parse(digit.ToString())).ToArray();
        
        long totalCount = 0;

        for (var i = 0; i < 4; i++)
        {
            totalCount += (endIp[i] - startIp[i]) * (long)Math.Pow(256, 3 - i);
        }

        return totalCount;
    }
}