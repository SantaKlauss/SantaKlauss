//дает возможность ссылаться на классы, которые находятся в пространстве имен System, 
//так что их можно использовать, не добавляя System. перед именем типа.
using System;

// объявления области, которая содержит набор связанных объектов. Можно использовать 
//пространство имён для организации элементов кода, а также для создания глобально 
//уникальных типов.
namespace _3_2__Мотиватор
{
    //Определения класса с именем OutputData
    class OutputData
    {
        // Дни до запуска
        public static void DrawDaysBeforeToday(DateTime f, DateTime now)
        {
            //Задаем цвет фона консоли
            Console.ForegroundColor = ConsoleColor.Red;
            //Время после первого запуска
            TimeSpan dif = now - f;
            int i = 1;
            // Выводим в цикле сивол X красным цыетом 
            while (i <= dif.Days)
            {
                Console.Write('X');
                i++;
            }
        }
        // Дни после первого запуска
        public static void DrawDaysAfterToday(DateTime a, DateTime now)
        {
            //Задаем цвет фона консоли
            Console.ForegroundColor = ConsoleColor.Green;
            TimeSpan dif = a - now;
            int i = 1;
            // Выводим в цикле сивол X зеленым цыетом 
            while (i <= dif.Days)
            {
                Console.Write('X');
                i++;
            }
        }
    }
}
