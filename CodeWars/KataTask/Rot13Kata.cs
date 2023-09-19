using System.Text;

namespace CodeWars.KataTask;

public class Rot13Kata
{
    /// <summary>
    /// ROT13 - это простой шифр замены букв, который заменяет букву буквой 13, следующей за ней в алфавите. ROT13 - это пример шифра Цезаря.
    /// Создайте функцию, которая принимает строку и возвращает строку, зашифрованную с помощью Rot13.
    /// Если в строку включены цифры или специальные символы, они должны быть возвращены такими, какие они есть.
    /// Только буквы из латинского / английского алфавита должны быть сдвинуты, как в оригинальной Rot13 "реализации".
    /// Ссылка на задание: https://www.codewars.com/kata/530e15517bc88ac656000716/train/csharp
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public static string Rot13(string message)
    {
        var resultWord = new StringBuilder();

        foreach (var letter in message)
        {
            if (char.IsDigit(letter) || !char.IsLetter(letter))
            {
                resultWord.Append(letter);
                continue;
            }

            var currentLetter = char.IsLower(letter) ? 'a' : 'A';
            var shiftedLetter = (char)(currentLetter + (letter - currentLetter + 13) % 26);

            resultWord.Append(shiftedLetter);
        }

        return resultWord.ToString();
    }
}