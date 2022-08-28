//Задача 19/ Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.WriteLine("Введите пятизначное число; ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number / 10000;
int number2 = number / 1000 % 10;
int number3 = number / 100 % 10;
int revers1 = number % 10;
int revers2 = number / 10 % 10;
int revers3 = number / 100 % 10;
 if(number  >= 100000)
 {
    Console.WriteLine ("Это не пятизначное число");
 }
 else 

if(number1 == revers1 && number2 == revers2 && number3 == revers3)
{
    Console.WriteLine("Да");
}

else 
{
    Console.WriteLine("Нет");
}

