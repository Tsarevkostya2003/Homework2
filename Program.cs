// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;

int a; // вводимое число
int b; // случайное число
int znak =1;
Random rnd = new Random(100); //Создание объекта для генерации чисел
int[,] table1 = new int[9,9] ; // создадим новую матрицу

while (znak!=4)
{
    Console.WriteLine("1 - Угадай число");
    Console.WriteLine("2 - Таблица умножения");
    Console.WriteLine("3 - Вывод делителей числа");
    Console.WriteLine("4 - Закрыть программу");
    Console.WriteLine("Выберите номер программы");
    znak = Convert.ToInt32(Console.ReadLine()); //Вводим номер программы

    if (znak==1) //Попадаем в игру "Угадай число"
    {
        Console.WriteLine("Угадай число от 0 от 100");
        b = rnd.Next(0,100); //Получаем случайное число
        a = Convert.ToInt32(Console.ReadLine()); //вводим число
        while (a != b)  //Пока числа не совпали
        {
            if (a > b)
            {
                Console.WriteLine("Случайное число меньше");
                a = Convert.ToInt32(Console.ReadLine()); //опять вводим число
            }
            else if (a < b)
            {
                Console.WriteLine("Случайное число больше");
                a = Convert.ToInt32(Console.ReadLine()); //опять вводим число
            }
                
        }
        Console.WriteLine("Угадал число!");
    }
    if (znak == 2) { // попадаем в таблицу умножения
        for (int m = 0; m <9; m++) //Заполнить матрицу
        {
            for (int n = 0; n < 9; n++)
            {
                table1[m, n] = (m+1) * (n+1);
            }
        }
        // вывод таблицы умножения
        for (int m = 0; m < 9; m++) {
            for (int n = 0; n < 9; n++)
            {
                Console.Write(string.Format("{0:d2}", table1[m, n]) +" ");
            }
            Console.WriteLine();
        }
    }

}

