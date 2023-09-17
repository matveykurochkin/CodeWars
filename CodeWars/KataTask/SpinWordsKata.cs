namespace CodeWars.KataTask;

public class SpinWordsKata
{
    /// <summary>
    /// Напишите функцию, которая принимает строку из одного или нескольких слов и возвращает ту же строку,
    /// но со всеми словами из пяти или более букв в обратном порядке.
    /// Передаваемые строки будут состоять только из букв и пробелов.
    /// Пробелы будут включены только в том случае, если присутствует более одного слова.
    /// Ссылка на задание: https://www.codewars.com/kata/5264d2b162488dc400000001
    /// </summary>
    /// <param name="sentence">Исходная строка</param>
    /// <returns>Преобразованная строка</returns>
    public static string SpinWords(string sentence)
    {
        return string.Join(" ", sentence
            .Split(' ')
            .Select(word => word.Length >= 5 ? new string(word.Reverse().ToArray()) : word)
            .ToArray());
    }
}