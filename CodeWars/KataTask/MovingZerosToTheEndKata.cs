namespace CodeWars.KataTask;

public class MovingZerosToTheEndKata
{
    /// <summary>
    /// Напишите алгоритм, который принимает массив и перемещает все нули в конец,
    /// сохраняя порядок расположения других элементов.
    /// Ссылка на задачу: https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int[] MoveZeroes(int[] arr)
    {
        var zeroArr = arr.Where(digit => digit == 0).Select(digit => digit);

        var resultArr = arr.Where(digit => digit != 0).Select(digit => digit).Concat(zeroArr).ToArray();
        
        return resultArr;
    }
}