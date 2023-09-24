//1 Найти все строки в списке строк, которые состоят только из цифр.
List<string> strings = new List<string> { "123", "2D4", "456", "ABC", "ABC", "ABC","123","123","123","123","Wwwwwwwwwwww", "Awwwwwwwwwww" };

var task1 = strings.Where(el => el.All(char.IsDigit));

foreach(var el in task1)
    Console.Write(el + " ");
Console.WriteLine();

//2 Найти максимальное и минимальное значение в числовом списке только с положительными числами.
List<int> numbers = new List<int> { -2, 4, -6, 8, 10, -12 };

var task2 = numbers.Where(el => el > 0);
Console.WriteLine($"max = {task2.Max()}, min = {task2.Min()}");

//3.Найти наиболее часто встречающееся слово в списке строк.
var task3 = strings.GroupBy(el => el).MaxBy(el => el.Count())?.Key;
Console.WriteLine(task3);

//4. Отсортировать список строк по длине в порядке убывания, а затем по алфавиту для строк одинаковой длины.
//Подсказка: после сортировки спользовать ThenBy (OrderBy(...).ThenBy(...))

var task4 = strings.OrderByDescending(el => el.Length).ThenBy(el => el);
foreach (var el in task4)
    Console.WriteLine(el + " ");

//5.Найти разницу в днях между самым ранним и самым поздним днем в списке дат.
//List<DateTime> dates = new List<DateTime> { new DateTime(2022, 1, 1), new DateTime(2022, 3, 15), new DateTime(2022, 2, 10) };
//int dayDifference = ...
//Console.WriteLine($"Разница в днях: {dayDifference}");
//Подсказка: можно использовать Substract(...);

List<DateTime> dates = new List<DateTime> { new DateTime(2022, 1, 1), new DateTime(2022, 3, 15), new DateTime(2022, 2, 10) };
int dayDifference = dates.Max().Subtract(dates.Min()).Days;
Console.WriteLine($"Разница в днях: {dayDifference}");


