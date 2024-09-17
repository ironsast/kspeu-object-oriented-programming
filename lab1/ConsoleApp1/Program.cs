using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {   //Задание 1
            // Console.WriteLine($"3 + 5 = {labFuncs.Proc('3', '5', '+')}");
            // Console.WriteLine($"9 - 2 = {labFuncs.Proc('9', '2', '-')}");
            // Console.WriteLine($"4 * 6 = {labFuncs.Proc('4', '6', '*')}");
            // Console.WriteLine($"8 / 2 = {labFuncs.Proc('8', '2', '/')}");

            //ЗАДАНИЕ 2
            //labFuncs.PrintCharCodes();

            //Задание 3
            //labFuncs.PrintAllCharCodes();

            //Задание 4
            // string s = @" s45g, df:\n = уам. Nи8т\tм Пт
            // Чdb; <>ум5ы). :Ядиь, vf3ь:9м( +
            // Djб6x2b 7; [] Ймд. Sfw 22я.";
            // char[] charArray = labFuncs.ConvertToCharArray(s);
            // foreach (char c in charArray)
            // {
            //     Console.Write(c);
            // }

            //Задание 5
            // char[] charArray = { 'H', 'e', 'l', 'l', 'o', ',', ' ', 'W', 'o', 'r', 'l', 'd', '!' };
            // string text = labFuncs.ConvertToText(charArray);
            // Console.WriteLine(text);

            //Задание 6
            // char[] charArray = { 'H', 'e', 'l', 'l', 'o', ',', ' ', 'W', 'o', 'r', 'l', 'd', '!' };
            // labFuncs.PrintCharArray(charArray);

            //Задание 7
            // char[] charArray = { 'H', 'e', 'l', 'l', 'o', ',', ' ', 'W', 'o', 'r', 'l', 'd', '!' };
            // labFuncs.PrintInputCharCodes(charArray);

            //Задание 8
            // char[] charArray = { 'H', 'e', 'l', 'l', 'o', ' ', ',', '\t', 'W', 'o', 'r', 'l', 'd', ' ', '!' };
            // labFuncs.PrintWhitespaceCharCodes(charArray);

            //Задание 9
            // char[] charArray = { 'H', 'e', 'l', 'l', 'o', '1', '2', '3', ' ', 'W', 'o', 'r', 'l', 'd', '4', '5', '6', '!' };
            // labFuncs.CountLettersAndDigits(charArray, out int letterCount, out int digitCount);
            // Console.WriteLine($"Количество букв: {letterCount}");
            // Console.WriteLine($"Количество цифр: {digitCount}");

            //Задание 10
            // char[] charArray = { 'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd', '!' };
            // char targetChar = 'o';
            // int index = labFuncs.FindChar(charArray, targetChar);
            // if (index != -1)
            // {
            //     Console.WriteLine($"Символ '{targetChar}' найден на индексе {index}.");
            // }
            // else
            // {
            //     Console.WriteLine($"Символ '{targetChar}' не найден.");
            // }

            //Задание 11
            // char[] charArray = { 'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd', '!' };
            // char targetChar = 'l';
            // int occurrences = labFuncs.CountCharOccurrences(charArray, targetChar);
            // Console.WriteLine($"Символ '{targetChar}' встречается {occurrences} раз(а).");

            //Задание 12
            // char[] charArray = { 'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd', '!' };
            // char firstChar = 'o';
            // char secondChar = 'x';
            // labFuncs.ReplaceChar(charArray, firstChar, secondChar);
            // Console.WriteLine(charArray);

            //Задание 13
            // char[] charArray = { 'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd', '!' };
            // char targetChar = 'l';
            // char[] newArray = labFuncs.RemoveChar(charArray, targetChar);
            // Console.WriteLine(newArray);

            //Задание 14
            // char[] charArray = { 'T', 'h', 'i', 's', ' ', ' ', 'i', 's', ' ', 'a', ' ', 't', 'e', 's', 't', '.', ' ', ' ', ' ', ' ', ' ' };
            // char[] newArray = labFuncs.CompressSpaces(charArray);
            // Console.WriteLine(newArray);

            //Задание 15
            // char[] charArray = { 'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd', '!' };
            // char[] reversedArray = labFuncs.ReverseArray(charArray);
            // Console.WriteLine(reversedArray);

            //Задание 16
            // char[] charArray1 = { 'r', 'a', 'c', 'e', 'c', 'a', 'r' };
            // char[] charArray2 = { 'h', 'e', 'l', 'l', 'o' };
            // Console.WriteLine($"Массив {new string(charArray1)} палиндром: {labFuncs.IsPalindrome(charArray1)}");
            // Console.WriteLine($"Массив {new string(charArray2)} палиндром: {labFuncs.IsPalindrome(charArray2)}");

            //Задание 17
            // char[] charArray = { 'H', 'e', 'l', 'l', 'o', '.', ' ', 'W', 'o', 'r', 'l', 'd', '!', ' ', 'T', 'h', 'i', 's', ' ', 'i', 's', ' ', 'a', ' ', 't', 'e', 's', 't', '.' };
            // var (wordCount, sentenceCount) = labFuncs.CountWordsAndSentences(charArray);
            // Console.WriteLine($"Количество слов: {wordCount}");
            // Console.WriteLine($"Количество предложений: {sentenceCount}");

            //Задание 18
            // char[] charArray = { 't', 'h', 'i', 's', ' ', 'i', 's', ' ', 'a', ' ', 't', 'e', 's', 't', '.', ' ', 'h', 'o', 'w', ' ', 'a', 'r', 'e', ' ', 'y', 'o', 'u', '?' };
            // char[] resultArray = labFuncs.CapitalizeSentences(charArray);
            // Console.WriteLine(resultArray);

            //Задание 19
            // char[] charArray = "Hello, world! How are you? I am fine. Thank you;".ToCharArray();
            // var (separators, punctuation) = labFuncs.ExtractSeparatorsAndPunctuation(charArray);
            // Console.WriteLine("Разделители:");
            // foreach (var separator in separators)
            // {
            //     Console.Write($"'{separator}' ");
            // }
            // Console.WriteLine();
            // Console.WriteLine("Знаки препинания:");
            // foreach (var punct in punctuation)
            // {
            //     Console.Write($"'{punct}' ");
            // }
            // Console.WriteLine();

            //Задание 20
            // string testString = "Это строка для теста";
            // string result = labFuncs.RemoveSpaces(testString);
            // Console.WriteLine("Исходная строка: " + testString);
            // Console.WriteLine("Строка без пробелов: " + result);

            //Задание 21
            // string testString = "Это строка для теста";
            // string result = labFuncs.ReplaceSpacesWithHyphens(testString);
            // Console.WriteLine("Исходная строка: " + testString);
            // Console.WriteLine("Строка с дефисами: " + result);

            // //Задание 22
            // string testString = "Это строка для теста";
            // string result = labFuncs.ReverseString(testString);
            // Console.WriteLine("Исходная строка: " + testString);
            // Console.WriteLine("Строка наоборот: " + result);

            //Задание 23
            // string testString = "Это строка для теста, чтобы проверить количество букв а и т.";
            // int result = labFuncs.CountAAndT(testString);
            // Console.WriteLine("Исходная строка: " + testString);
            // Console.WriteLine("Суммарное количество букв 'а' и 'т': " + result);

            //Задание 24
            // string testString = "Это строка для подсчета количества слов";
            // int wordCount = labFuncs.CountWords(testString);
            // Console.WriteLine("Исходная строка: " + testString);
            // Console.WriteLine("Количество слов: " + wordCount);

            //Задание 25
            // string testString = "Это строка для теста";
            // string[] words = labFuncs.ExtractWords(testString);
            // Console.WriteLine("Исходная строка: " + testString);
            // Console.WriteLine("Массив слов:");
            // foreach (string word in words)
            // {
            //     Console.WriteLine(word);
            // }

            //Задание 26
            // string[] words = { "Это", "строка", "для", "теста" };
            // Console.WriteLine("Массив слов:");
            // labFuncs.PrintStringArray(words);

            //Задание 27
            // string testString = "Это строка для теста";
            // string result = labFuncs.ReverseWordsInSentence(testString);
            // Console.WriteLine("Исходное предложение: " + testString);
            // Console.WriteLine("Предложение с обратным порядком слов: " + result);

            //Задание 28
            // string text = "Это первая строка.\nЭто вторая строка.\nТретья строка.";
            // int[] counts = labFuncs.CountCharsInLines(text);
            // for (int i = 0; i < counts.Length; i++)
            // {
            //     Console.WriteLine($"Количество символов в строке {i + 1}: {counts[i]}");
            // }

            //Задание 29
            // string text = "Это первая строка.\nЭто вторая строка?\nЭто третья строка.\nЧетвертая строка?\nПятая строка.";
            // int lineToRemove = 2;
            // string newText = labFuncs.RemoveLineAndQuestionLine(text, lineToRemove);
            // Console.WriteLine("Исходный текст:");
            // Console.WriteLine(text);
            // Console.WriteLine("\nОбработанный текст:");
            // Console.WriteLine(newText);

            //Задание 30
            // string text = "(1 + 2) * 3\n(4 + 5) * (6 - 7\n8 * (9 - 3))";
            // Console.WriteLine("Проверка на сбалансированность скобок:");
            // labFuncs.CheckBracketBalance(text);

            //Задание 31
            // string text = "Это первая строка.\nВторая строка длиннее.\nТретья строка.";
            // int longestLineLength = labFuncs.GetLongestLineLength(text);
            // int longestLineNumber = labFuncs.GetLongestLineNumber(text);
            // string longestLine = labFuncs.GetLongestLine(text);
            // Console.WriteLine($"Длина самой длинной строки: {longestLineLength}");
            // Console.WriteLine($"Номер самой длинной строки: {longestLineNumber}");
            // Console.WriteLine($"Самая длинная строка: {longestLine}");

            //Задание 32
            // string text = "Первая строка.\nВторая строка.\nТретья строка.";
            // Console.WriteLine("Исходный текст:");
            // Console.WriteLine(text);
            // string reversedSameOrder = labFuncs.ReverseLinesInSameOrder(text);
            // Console.WriteLine("\nСтроки в перевёрнутом виде, с сохранением порядка:");
            // Console.WriteLine(reversedSameOrder);
            // string reversedReverseOrder = labFuncs.ReverseLinesInReverseOrder(text);
            // Console.WriteLine("\nСтроки в перевёрнутом виде, с обратным порядком строк:");
            // Console.WriteLine(reversedReverseOrder);

            //Задание 33
            // string[] array = { "короткий", "средней длины", "длинная строка", "ещё длиннее строка" };
            // string longest = labFuncs.FindLongestString(array);
            // Console.WriteLine("Строка с наибольшим количеством символов:");
            // Console.WriteLine(longest);

            //Задание 34
            // string[] array = { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            // string resultComma = labFuncs.JoinWithDelimiter(array, ',');
            // string resultSemicolon = labFuncs.JoinWithDelimiter(array, ';');
            // Console.WriteLine("Строка с разделителем ',':");
            // Console.WriteLine(resultComma);
            // Console.WriteLine("\nСтрока с разделителем ';':");
            // Console.WriteLine(resultSemicolon);

            // Задание 35
            // string input = "один,два,три,четыре,пять,шесть,семь,восемь,девять";
            // string[] arrayComma = labFuncs.SplitIntoArray(input, ',');
            // Console.WriteLine("Массив, разделённый запятыми:");
            // labFuncs.PrintArray(arrayComma);
            // string inputSemicolon = "один;два;три;четыре;пять;шесть;семь;восемь;девять";
            // string[] arraySemicolon = labFuncs.SplitIntoArray(inputSemicolon, ';');
            // Console.WriteLine("\nМассив, разделённый точкой с запятой:");
            // labFuncs.PrintArray(arraySemicolon);

            //Задание 36
            // string[] array = { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            // string resultComma = labFuncs.JoinArrayWithDelimiter(array, ',');
            // Console.WriteLine("Строка с разделителем ',':");
            // Console.WriteLine(resultComma);
            // string resultSemicolon = labFuncs.JoinArrayWithDelimiter(array, ';');
            // Console.WriteLine("\nСтрока с разделителем ';':");
            // Console.WriteLine(resultSemicolon);
        }
    }
}