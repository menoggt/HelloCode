﻿using System;

class Answer {
    static void CheckIfEven(int number)
    {
      // Введите свое решение ниже
        if(number%2 == 0)
        {
            Console.WriteLine($" Число `{number}` чётное");
        }
        if(number%2 == 1)
        {
            Console.WriteLine($" Число `{number}` нечётное");
        }
    }
  

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 5;
        }

        // Не удаляйте строки ниже
        CheckIfEven(number);
    }
}