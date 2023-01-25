// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void PowCalculate(int a, int b)
{
    int result=1;
	for (int i=0; i<b; i++)
	{
		result=result*a;
	}
    Console.WriteLine($"Результат {a}^{b}: {result}");
}

Console.WriteLine("Введите число:");
if (int.TryParse(Console.ReadLine(), out int num))
    Console.WriteLine("Введите натуральную степень:");
else
{   
    Console.WriteLine("Некорректное значение!");
    return;
}
	
if (int.TryParse(Console.ReadLine(), out int pow) && pow>=0)
    PowCalculate(num, pow);
else
    Console.WriteLine("Некорректное значение!");