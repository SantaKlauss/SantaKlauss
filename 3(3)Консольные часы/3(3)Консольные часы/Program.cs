//Дает возможность ссылаться на классы, которые находятся в пространстве имен System, 
//так что их можно использовать, не добавляя System. перед именем типа.
using System;
//Создает и контролирует поток, задает приоритет и возвращает статус.
using System.Threading;

// объявления области, которая содержит набор связанных объектов. Можно использовать 
//пространство имён для организации элементов кода, а также для создания глобально 
//уникальных типов.
namespace _3_3_Консольные_часы
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
            // Массив строк час
            string[] hour = { "час", "часа", "часов" };
            // Массив строк минута
            string[] minute	= { "минута", "минуты", "минут" };
            // Массив строк секунда
            string[] second	=	{ "секунда", "секунды","секунд" };
            //Цвет фона
            Console.ForegroundColor = ConsoleColor.Green;
            //Заголвок программы
            Console.Title = "ЧАСЫ \"ЭЛЕКТРОНИКА\" :)";
           //Видимость курсора
            Console.CursorVisible = false;
            
            // Горизонтальная черта
            string hLine = new string('\u2550', 50);

            while (true)
            {
                //Отчищаем консолю
                Console.Clear();
                //Устаавоиваем положение курсора 
                Console.SetCursorPosition(6, 8);
                //Оступ
                Console.WriteLine(hLine);
                //Устаавоиваем положение курсора
                Console.SetCursorPosition(10, 10);
                //Записываем текущую дату
                Console.WriteLine("Текущая дата : {0}", DateTime.Now.ToLongDateString());
                //Устаавоиваем положение курсора
                Console.SetCursorPosition(10, 12);
                //Записываем текущее время
                Console.WriteLine("Текущее время: {0:HH} {1} {2:mm} {3} {4:ss} {5}",
                    //Час
                    DateTime.Now, hour[GetEndingFor(DateTime.Now.Hour)],
                    //Минуты
                    DateTime.Now, minute[GetEndingFor(DateTime.Now.Minute)],
                    //Секунды
                    DateTime.Now, second[GetEndingFor(DateTime.Now.Second)]);
                //Устаавоиваем положение курсора
                Console.SetCursorPosition(6, 14);
                Console.WriteLine(hLine);
                
                //Обновление потока
                Thread.Sleep(700);
            }
        }

        /// <summary>
        /// Определяет, какое падежное окончание нужно выбрать в зависимости 
        /// от количества предметов.
        /// </summary>
        ///<param name="number">Количество предметов (часов, минут, секунд)</param>
        ///<returns>Возвращает индекс массива набора падежных окончаний</returns> 
        static int GetEndingFor(int number)
        {
            if (number % 10 == 1 && number != 11) 
                return 0;
            else if (number % 10 >= 2 && number % 10 <= 4 && (number <5 || number > 20)) 
                return 1;
            else
                return 2;
        }
    }
}

