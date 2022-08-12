Console.WriteLine("Введите трехзначное число:");
string threeDigitNumber = (Console.ReadLine()!);
var digitArray = threeDigitNumber.Select(digit => int.Parse(digit.ToString())).ToArray(); // передали массиву строку полученную от Пользователя (число введенное Пользователем)
// и преобразовали ее в число, а затем вложили в массив
Console.WriteLine(digitArray[1]);
