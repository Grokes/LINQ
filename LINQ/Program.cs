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


//1.Задача: Найти все пары чисел в списке, сумма которых равна заданному числу.
//заданное число к примеру 7
//{1, 2, 3, 4, 5}
//2 + 5 = 7
//3 + 4 = 7
//Вывод
//2,5
//3,4

//2. Задача: Подсчитать количество уникальных слов в списке строк, игнорируя регистр.

List<string> strings2 = new List<string> {"One two three", "tWo one second", "only uniQue words" };
List<string> task6 = new List<string>();

strings2.ForEach(el => task6.AddRange(el.ToLower().Trim().Split()));
Console.WriteLine(task6.GroupBy(word => word).Count(word => word.Count() == 1));



//3. Задача: Получить список всех чисел от 1 до 100, которые являются квадратами другого числа.
//Использовать Enumerable.Range(1, 100). Задает списко чисел от 1 до 100;
//К пример результатом будет 6 => 36 (6 является квадратом 36).
//Также стоит использовать Any(). 

//4.Задача: Найти все строки в списке, которые содержат все гласные буквы. Для повторения.

//5. Задача: Получить список уникальных символов из заданной строки. (Без дубликатов, пример рабирали на занятии)




//6.Задача: Выполнить соединение(Join()) двух коллекций на основе общего свойства и выбрать определенные поля из каждой коллекции.
//```csharp
//List<Person> persons = new List<Person>
//{
//    new Person { Id = 1, Name = "John" },
//    new Person { Id = 2, Name = "Jane" },
//};

//List<Address> addresses = new List<Address>
//{
//    new Address { PersonId = 1, City = "New York" },
//    new Address { PersonId = 2, City = "London" },
//};

//// Здесь решение

//Console.WriteLine("Соединенные данные из двух коллекций:");
//foreach (var result in query)
//{
//Console.WriteLine($"{result.Name} - {result.City}");
//}

//class Person
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}

//class Address
//{
//    public int PersonId { get; set; }
//    public string City { get; set; }
//}
//```
