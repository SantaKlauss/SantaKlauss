//Дает возможность ссылаться на классы, которые находятся в пространстве имен System, 
//так что их можно использовать, не добавляя System. перед именем типа.
using System;
//Содержит интерфейсы и классы, определяющие универсальные коллекции, 
//которые позволяют пользователям создавать строго типизированные коллекции, 
//обеспечивающие повышенную производительность и безопасность типов 
//по сравнению с неуниверсальными строго типизированными коллекциями.
using System.Collections.Generic;
//Содержит классы и интерфейсы, которые поддерживают запросы, 
//использующие LINQ.
using System.Linq;
//Пространство имен содержит классы, представляющие ASCII и Unicode 
//кодировок; абстрактные базовые классы для преобразования блоков символов
//и из блоков байтов
using System.Text;
//Создает и контролирует поток, задает приоритет и возвращает статус.
using System.Threading.Tasks;
//Пространство имен System.IO содержит типы, позволяющие осуществлять чтение и запись в 
//файлы и потоки данных, а также типы для базовой поддержки файлов и папок.
using System.IO;

// объявления области, которая содержит набор связанных объектов. Можно использовать 
//пространство имён для организации элементов кода, а также для создания глобально 
//уникальных типов.
namespace less_2__2__Шифратор
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
            string s;
            string filename; // имя файла
            int key;	//	ключ шифрования
            char algo;	//	алгоритм шифрования
            char mode;	//	режим: шифрование или	дешифрование

            // Проверяем аргументы.
            // Если их не хватает, просим пользователя указать их 
            if (args.Length < 4)
            {
                Console.WriteLine("Неверное число аргументов!");
                Console.Write("Введите путь к файлу: "); 
                filename = Console.ReadLine();

                // Добиваемся от пользователя ввода правильного значения 
                while (true)
                {
                    Console.Write("Введите ключ шифрования/дешифрования (целое число): "); 
                    s = Console.ReadLine();
                    
                    // Выходим из цикла только если аргумент введен правильно 
                    if (int.TryParse(s, out key))
                        break;
                }

                //Выбираем алгоритм шифрования/дешифрования
                while (true)
                {
                    Console.Write("Введите алгоритм шифрования/дешифрования ('x' -> XOR = , 'm' -> MOD): "); 
                    s = Console.ReadLine();

                    //TryParse Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком. 
                    //Возвращает значение, указывающее, успешно ли выполнена операция.
                    if (char.TryParse(s, out algo)) 
                        break;
                }

                //Выбираем режим шифрования/дешифрования
                while (true)
                {	
                    Console.Write("Введите режим: ('e' -> шифрование, 'd' -> дешифрование): "); 
                    s = Console.ReadLine();

                    //TryParse Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком. 
                    //Возвращает значение, указывающее, успешно ли выполнена операция.
                    if (char.TryParse(s, out mode)) 
                        break;
                }
            }

            // Иначе берем первые 4 аргумента
            else
            {
                //Имя файла
                filename = args[0];
                //ключ шифрования
                int.TryParse(args[1], out key);
                //алгоритм шифрования
                char.TryParse(args[2], out algo); 
                //режим: шифрование или	дешифрование
                char.TryParse(args[3], out mode);
            }
                
            // Вызываем метод шифрования/дешифрования
            Crypter.ErrorCode result = Crypter.Crypto(filename, key, (Crypter.CryptAlgo)algo, (Crypter.CryptMode)mode); 
                
            // Анализируем результат
            switch (result)
            {
                // Ошибка - Указанный файл не найден
                case Crypter.ErrorCode.FILE_NOT_FOUND:
                    Console.WriteLine("Указанный файл не найден!"); 
                    break;
                // Ошибка - Указан неверный аргумент для алгоритма
                case Crypter.ErrorCode.BAD_ALGO_ARG:
                    Console.WriteLine("Указан неверный аргумент для алгоритма!"); 
                    break;
                // Если параметр режима задан неверно - возвращаем соотв. ошибку 
                case Crypter.ErrorCode.BAD_MODE_ARG:
                    Console.WriteLine("Указан неверный аргумент для режима шифрования!"); 
                    break;
                // Файл преобразован успешно
                case Crypter.ErrorCode.NO_ERROR:
                    Console.WriteLine("Файл преобразован успешно!"); 
                    break;
            }
            
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Шифратор-дешифратор файлов 
    /// </summary>

    static class Crypter
    {
        /// <summary>
        /// Алгоритм (метод) шифрования/дешифрования
        /// </summary>
        public enum CryptAlgo { XOR = 'x', MOD = 'm' };

        /// <summary>
        /// Режим: шифрование или дешифрование
        /// </summary>
        public enum CryptMode { ENCRYPT = 'e', DECRYPT = 'd' }; 

        /// <summary>
        /// Код возвращаемой ошибки
        /// </summary>
        public enum ErrorCode { FILE_NOT_FOUND, BAD_ALGO_ARG, BAD_MODE_ARG, NO_ERROR };
                    
        ///<summary>
        ///Шифрует/дешифрует файл, применяя к каждому байту указанный алгоритм
        /// </summary>
        /// <param name="filename">Путь к (де)шифруемому файлу</param>
        /// <param пате="кеу">Ключ шифрования</param>
        /// <param name="mode">Алгоритм шифрования</param>
        /// <param name="mode">Режим: шифрование или дешифрование</param>
        /// <returns>Возвращает сообщение о результате операции</returns>
        public static ErrorCode Crypto(string filename, int key, CryptAlgo algo, CryptMode mode) 
        {
            byte[] bytes; // массив байтов файла 
            
            // Проверяем, существует ли файл
            // Если да - считываем все байты файла в массив байтов 
            if (File.Exists(filename))
                bytes = File.ReadAllBytes(filename);
            
            // Если нет - возвращаем соотв. ошибку 
            else
                return ErrorCode.FILE_NOT_FOUND;
            
            // Длина массива байтов
            int len = bytes.Length;	
            
            // Выбираем алгоритм шифрования 
            switch (algo)
            {
                // Для XOR все равно, шифруется или дешифруется файл.
                // В обоих случаях к каждому байту применяется "исключающее ИЛИ" по ключу (key) 
                case CryptAlgo.XOR:
                    for (int i = 0; i < len; ++i)
                        bytes[i] ^= (byte)(key % 256);

                    break;

                case CryptAlgo.MOD:
                    // При шифровании к каждому байту прибавляем значение ключа (key)
                    if (mode == CryptMode.ENCRYPT)
                    {
                        for (int i = 0; i < len; ++i)
                            bytes[i] += (byte)key;
                    }

                    // При дешифровании от каждого байта отнимаем значение ключа (key) 
                    else if (mode == CryptMode.DECRYPT)
                    {
                        for (int i = 0; i < len; ++i)
                            bytes[i] -= (byte)key;
                    }

                    // Если параметр режима задан неверно - возвращаем соотв. ошибку 
                    else
                        return ErrorCode.BAD_MODE_ARG;

                    break;

                // Если параметр алгоритма задан неверно - возвращаем ошибку 
                default:
                    return ErrorCode.BAD_MODE_ARG;
            }
            
            // Создаем понятное имя для файла, чтобы было ясно,
            // какие операции над ним производились
            string filenameOut = String.Format ("{0}_{1}_{2}.dat", mode, algo, key);
            
            // Создаем файл и записываем в него массив байтов 
            // Существующий файл будет перезаписан!
            File.WriteAllBytes(filenameOut, bytes);

            return ErrorCode.NO_ERROR;
        }
    }
}
