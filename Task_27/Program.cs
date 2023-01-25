// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void SumOfDigits()
{
	if (ulong.TryParse(Console.ReadLine(), out var number))
	{   	
            ulong temp=number;
    		double sum=0;
    		int count;
    		for (count=0; temp>0; count++)
    		{
        		temp/=10;
    		}
    		for (int i=0; i<count; i++)
    		{
        		sum+=(number%Math.Pow(10, i+1) - number%Math.Pow(10, i)) / Math.Pow(10, i);
    		}
    		Console.WriteLine($"Сумма цифр в числе: {sum}");
	}
	else
    		Console.WriteLine("Некорректное значение!");    
	}

Console.WriteLine("Введите целое положительное число:");

SumOfDigits();