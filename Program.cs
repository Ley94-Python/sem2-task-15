// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



Console.WriteLine($"Введите цифру дня недели от 1 до 7:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number < 1)
{
    Console.WriteLine($"Ввели неверную цифру");
    
}

if (number > 5 || number < 7) 
{
    Console.WriteLine($"Круто! Этот день выходной!");
}
else
{
    Console.WriteLine($"Увы( День рабочий!");
}
