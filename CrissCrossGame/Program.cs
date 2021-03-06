﻿//Дает возможность ссылаться на классы, которые находятся в пространстве имен System, 
//так что их можно использовать, не добавляя System. перед именем типа.
using System;
//Создает и контролирует поток, задает приоритет и возвращает статус.
using System.Threading;

// объявления области, которая содержит набор связанных объектов. Можно использовать 
//пространство имён для организации элементов кода, а также для создания глобально 
//уникальных типов
namespace CrissCrossGame
{
    //Определения класса с именем Program
    class Program
    {
        //Модификатор static используется для объявления статического члена, принадлежащего 
        //собственно типу, а не конкретному объекту.
        //Слово void указывает, что метод не возвращает значение
        //Метод Main является точкой входа EXE-программы, в которой начинается и заканчивается 
        //управление программой.
        //string[] содержит аргументы командной строки, или без него.
        //Массив аргументов, который передается приложению операционной системой.
        static void Main(string[] args)
        {
           
            // Инициалтзация поля 3х3. Возвращает экземпляр класса "Игровое поле"
            GameField f = GameEngine.Start(3);
            bool userExit = false; // Признак того что пользователь хочет закончт игру

            GameOutput.ShowGame(f); // Перевывести поле
            Thread.Sleep(500); // Задержка для имитации "задумчивости" комптютера :)

           // Пока пользователь не оборвал игру и игра не завершена
            while (!userExit && !GameEngine.IsGameFinished(f))
            {
                GameEngine.PutComputerChar(f); // Сделать ход компьютера
                GameOutput.ShowGame(f); // Перевывести поле

               // Если игра не завершена
                if (!GameEngine.IsGameFinished(f))
                {
                    int x, y; // Координаты хода пользователя

                    userExit = !GameInput.GetInput(out x, out y); // Ход пользователя. Получаем координаты и признак "выйти"

                    //Пока пользователь не оборвал игру и такой ход возможен (чтобы пропускать неправильные ходы)
                    // выполняем ход пользователя на эти координаты
                    while (!userExit && !GameEngine.PutUserChar(f, x, y))
                        userExit = !GameInput.GetInput(out x, out y); // Ход пользователя. Получаем координаты и признак "выйти"

                    // Если пользовател не оборвал игру
                    if (!userExit)
                    {
                        GameOutput.ShowGame(f); // Перевывести поле
                        Thread.Sleep(500); // Задержка для имитации "задумчивости" комптютера
                    }
                }
            }

            // Если игра завершена или если проьхователь оборвал игру
            if (!userExit) // Если пользователь не оборвал игру
            {
                GameChar winner = GameEngine.GetWinner(f); // Кто выйграл
                GameOutput.ShowResult(winner); // Показать исход игры
                Console.ReadKey(true); // Чтоб пользователь увидел результат 
            }
        }
    }
}
