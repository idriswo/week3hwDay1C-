
//task1.
// List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
// int sum = numbers.Sum();
// Console.WriteLine("The sum of all the elements in the list is: " + sum);


//task2.
// List<string> words = new List<string>{ "hello", "world", "!" };
// string concat = string.Concat(words);
// Console.WriteLine("The concatenated string is: " + concat);


//task3.
// List<DateTime> dates = new List<DateTime>
// {
//     new DateTime(2020, 10, 1),
//     new DateTime(2022, 8, 15),
//     new DateTime(2021, 4, 28)
// };
// dates.Sort();
// Console.WriteLine("The sorted dates are:");
// foreach (DateTime date in dates)
// {
//     Console.WriteLine(date.ToShortDateString());
// }



//task4.
// List<double> numbers = new List<double>{ 3.5, 2.7, 6.9, 1.2 };
// double average = numbers.Average();
// Console.WriteLine("The average value of all the elements in the list is: " + average);




//task5.
// List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
// List<int> evenNumbers = numbers.FindAll(num => num%2==0);
// Console.WriteLine("The filtered numbers are:");
// foreach (int number in evenNumbers)
// {
//     Console.WriteLine(number);
// }



//task6.
// List<bool> values = new List<bool>{ true, true, true };
// bool allTrue = values.All(n => n == true);
// Console.WriteLine("Are all the values in the list true? " + allTrue);



//task7.
// List<string> items = new List<string>{ "apple", "banana", "cherry" };
// items.RemoveAt(2);
// Console.WriteLine("List after removal:");
// foreach (var item in items)
// {
//     Console.Write(item+" ");
// }



//task8.
// List<string> items = new List<string>{ "apple", "banana", "cherry" };
// bool found = items.Exists(str => str == "apple");
// bool found1 = items.Exists(str => str == "appl1e");
// Console.WriteLine("Is the element found? " + found);
// Console.WriteLine("Is the element found? " + found1);



//task9.
// List<int> numbers = new List<int>();
// numbers.AddRange([1,2,3,4,5]);
// Console.Write("All numbers in the list : ");
// foreach (var number in numbers)
// {
//     Console.Write(number+" ");
// }



//task10.
// List<int> numbers = new List<int>();
// Random n = new Random();
// int RandomNumber = n.Next(1,100);
// numbers.Add(RandomNumber);
// Console.Write("Random numbers in the list : ");
// foreach (var number in numbers)
// {
//     Console.WriteLine(number);
// }
