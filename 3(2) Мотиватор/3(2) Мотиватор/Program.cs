//дает возможность ссылаться на классы, которые находятся в пространстве имен System, 
//так что их можно использовать, не добавляя System. перед именем типа.
using System;
//Пространство имен System.IO содержит типы, позволяющие осуществлять чтение и запись в 
//файлы и потоки данных, а также типы для базовой поддержки файлов и папок.
using System.IO;

// объявления области, которая содержит набор связанных объектов. Можно использовать 
//пространство имён для организации элементов кода, а также для создания глобально 
//уникальных типов.
namespace _3_2__Мотиватор
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
            // Файл в котором запоминается первый запуск
            string filename = "firstrun.txt";
            string[] content;
            string str;

            //Дата первого запуска
            DateTime dateFirstRun;
            //Дата юбилея
            DateTime dateAnniversary;
            //Дата ДР
            DateTime dateBirthday;

            //Получение дат
            //Если файл существует, то мы читаем из него информацию
            //И распознаем дату первого запуска и дату юбилея
            if (File.Exists(filename))
            {
                content = File.ReadAllLines(filename);
                //Первый запкск
                dateFirstRun = DateTime.Parse(content[0]);
                //Юбилей (необходимо для времени расчета)
                dateAnniversary = DateTime.Parse(content[1]);
            }
            // Иначе, если файл не существет, то просим пользователся ввести данные
            else
            {
                //Дата первого запуска - текущие время и дата ПК
                dateFirstRun = DateTime.Now;
                // Создает бесконечный цикл.
                for (; ; )
                {
                    Console.Write("Когда у вас день рождения?(yyyy-mm-dd) ");
                    str = Console.ReadLine();

                    //Проверка на корректность введения даты
                    if (DateTime.TryParse(str, out dateBirthday))
                    {
                        //Если дата рождения > даты первого запуска
                        //То выводим текст
                        if (dateBirthday.Date > dateFirstRun.Date)
                        {
                            Console.WriteLine("Baша дата рождения не верна!");
                            continue;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка при вводе даты! Попробуйте еще раз!");
                    }
                }
                // Вычисление юбилея
                int i;
                // В цикле сдвигаем переменые i в нужное место 
                for (i = dateBirthday.Year; i < dateFirstRun.Year + 3; i = i + 10) ;
                dateAnniversary = new DateTime(i, dateBirthday.Month, dateBirthday.Day);
                
                // В файле создаем 2 строки
                content = new string[2];
                //Дата первого запуска
                content[0] = dateFirstRun.Date.ToString();
                //Дата юбилея
                content[1] = dateAnniversary.Date.ToString();
                //Создаем новый файл, записывает в него указанный массив строк и затем закрывает файл.
                File.WriteAllLines(filename, content);
            }

            //Используется класс OutputData и вызывается два метода
            //// Дни до запуска
            OutputData.DrawDaysBeforeToday(dateFirstRun, DateTime.Now);
            //Дни после первого запуска
            OutputData.DrawDaysAfterToday(dateAnniversary, DateTime.Now);
            Console.ReadLine();

        }
    }
}
