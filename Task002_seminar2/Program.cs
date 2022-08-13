Console.WriteLine("Введите число:");
string threeDigitNumber = (Console.ReadLine()!);
var digitArray = threeDigitNumber.Select(digit => int.Parse(digit.ToString())).ToArray(); // передали массиву строку полученную от Пользователя (число введенное Пользователем)
// и преобразовали ее в число, а затем вложили в массив

if(digitArray.Length >= 3)
{
    Console.WriteLine(digitArray[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}