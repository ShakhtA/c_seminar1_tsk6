// Ввод числа

Console.WriteLine("Введите число");

string Str = Console.ReadLine() ?? "";
int Num = int.Parse(Str);

// Проверка числа на четность

if (Num % 2 == 0) Console.WriteLine($"{Num} - четное число");
else Console.WriteLine($"{Num} - нечетное число");    
