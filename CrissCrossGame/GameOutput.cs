//Дает возможность ссылаться на классы, которые находятся в пространстве имен System, 
//так что их можно использовать, не добавляя System. перед именем типа.
using System;

// объявления области, которая содержит набор связанных объектов. Можно использовать 
//пространство имён для организации элементов кода, а также для создания глобально 
//уникальных типов
namespace CrissCrossGame
{
    /// <summary>
    /// "Устройство" вывода в игре
    /// </summary>
    class GameOutput
    {
        //--- public ----------------------------------------------------------
        /// <summary>
        /// Показать игровое поле
        /// </summary>
        public static void ShowGame(GameField f)
        {
            // Данный метод можно улучшить, используя табличные символы
            // ANSI-графики:

            // Граничный символ.
            char box = (char)0x2592;            

            // Построчный вывод матрицы и границ.
            for (int y = 0; y < f.Size; y++)
            {
                // Устанавливаем положение курсора
                Console.SetCursorPosition(0, y * 2);

                for (int i = 0; i < f.Size * 2 + 1; i++)
                    Console.Write(box);
                //Устанавливаем положение курсора
                Console.SetCursorPosition(0, y * 2 + 1);

                // Цикл по горизонтали для проверки всех вертикалей
                for (int x = 0; x < f.Size; x++)
                {
                    GameChar gameChar = f.GetChar(x, y);
                    // Превращение игрового символа в текстовый
                    char c = GetChar(gameChar);                    
                    Console.Write(box);
                    Console.Write(c);
                }

                Console.Write(box);
            }

            // Вывод последней строки.
            Console.SetCursorPosition(0, f.Size * 2);

            for (int i = 0; i < f.Size * 2 + 1; i++)
                Console.Write(box);
        }

        /// <summary>
        /// Показать исход игры
        /// </summary>
        public static void ShowResult(GameChar winner)
        {
            // Идем вниз экрана.
            Console.SetCursorPosition(0, 23);
            
            // Выводим исход игры.
            switch (winner)
            {
                case GameChar.Null:
                    Console.WriteLine("Ничья.");
                    break;

                case GameChar.Cross:
                    Console.WriteLine("Вы проиграли, увы.");
                    break;

                case GameChar.Zero:
                    Console.WriteLine("Поздравляю! Вы выиграли.");
                    break;
            }
        }


        //--- private ---------------------------------------------------------        
        /// <summary>
        /// Превращение игрового символа в текстовый
        /// </summary>
        private static char GetChar(GameChar c)
        {
            switch (c)
            {
                case GameChar.Cross:
                    return 'X';

                case GameChar.Zero:
                    return 'O';

                default:
                    return ' ';
            }
        }
    }
}
