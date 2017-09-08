//Дает возможность ссылаться на классы, которые находятся в пространстве имен System, 
//так что их можно использовать, не добавляя System. перед именем типа.
using System;

// объявления области, которая содержит набор связанных объектов. Можно использовать 
//пространство имён для организации элементов кода, а также для создания глобально 
//уникальных типов
namespace CrissCrossGame
{
    //Определения класса с именем GameEngine
    /// <summary>
    /// Движок игры
    /// </summary>
    class GameEngine
    {
        //--- public ----------------------------------------------------------        
        /// <summary>
        /// Инициализация игрового поля
        /// </summary>
        public static GameField Start(int size)
        {
            // Инициализация игрового поля.
            GameField f = new GameField(size);
            return f;
        }

        /// <summary>
        /// Ход компьютера
        /// хранения логических значений, true и false.
        /// </summary>
        public static bool PutComputerChar(GameField f)
        {
            bool dang; // Признак наличия угрозы
            int countZero; // Счетчик "Нулей"
            int countCross; // Счетчик "Крестов"

            //Проверить на "угрозу" заполнения противником горизонтали 
            //и ликвидировать ее
            for (int y = 0; y < f.Size; y++) // Цикл по вертикали для проверки всех гор-ей
            {
                // Признак наличия угрозы вкл
                dang = true;
                // Счетчик "Нулей" равен 0
                countZero = 0;
                //Счетчик "Крестов" раве 0
                countCross = 0;
                for (int x = 0; x < f.Size; x++) // Цикл по горизонтали
                {
                    if (f.GetChar(x,y) == GameChar.Cross)
                    {
                        dang = false;
                        break;
                    }
                    if (f.GetChar(x,y) == GameChar.Zero) countZero++;
                    if (f.GetChar(x,y) == GameChar.Cross) countCross++;
                }
                if (countZero < f.Size -1)
                    dang = false;
                // Если опасность - ликвидировать ее (поставить Cross)
                // Или если можно заполнить всю линию - тоже поставить Cross
                if ( (dang == true) || (countCross >= f.Size - 1) )
                {
                    for (int x = 0; x < f.Size; x++) // Цикл по горизонтали
                        if (f.GetChar(x,y) == GameChar.Null)
                        {
                            f.SetChar(GameChar.Cross,x,y);
                            return true;
                        }
                }
            }//end for (y)

            //Проверяем на "угрозу" заполнения противником вертикали и ликвидировать ее
            for (int x = 0; x < f.Size; x++) // Цикл по горизонтали для проверки всех вертикалей
            {
                // Признак наличия угрозы вкл
                dang = true;
                // Счетчик "Нулей" равен 0
                countZero = 0;
                //Счетчик "Крестов" раве 0
                countCross = 0;
                for (int y = 0; y < f.Size; y++) // Цикл по вертикали
                {
                    if (f.GetChar(x, y) == GameChar.Cross)
                    {
                        // Признак наличия угрозы выкл
                        dang = false;
                        break;
                    }
                    if (f.GetChar(x, y) == GameChar.Zero) countZero++;
                    if (f.GetChar(x, y) == GameChar.Cross) countCross++;
                }
                if (countZero < f.Size - 1)
                    dang = false;
                // Если опасность - ликвидировать ее (поставить Cross)
                // Или если можно заполнить всю линию - тоже поставить Cross
                if ((dang == true) || (countCross >= f.Size - 1))
                {
                    for (int y = 0; y < f.Size; y++) // Цикл по вертикали
                        if (f.GetChar(x, y) == GameChar.Null)
                        {
                            f.SetChar(GameChar.Cross, x, y);
                            return true;
                        }
                }
            } // end for (x)

            // Проверить на "урозу" заполнения противником первой диагонали ликвидировать ее
            dang = true;
            // Счетчик "Нулей" равен 0
            countZero = 0;
            //Счетчик "Крестов" раве 0
            countCross = 0;
            for (int x = 0; x < f.Size; x++) // Цикл по первой диагонали
            {
                int y;
                y = x;
                if (f.GetChar(x, y) == GameChar.Cross)
                {
                    dang = false;
                    break;
                }
                if (f.GetChar(x, y) == GameChar.Zero) countZero++;
                if (f.GetChar(x, y) == GameChar.Cross) countCross++;
            } // end for (x)
            if (countZero < f.Size - 1)
                dang = false;

            // Если опасность - ликвидировать ее (поставить Cross)
            // Или если можно заполнить всю линию - тоже поставить Cross
            if ((dang == true) || (countCross >= f.Size - 1)) // Если опасность - ликвидировать ее (
            {
                for (int x = 0; x < f.Size; x++)
                {
                    int y;
                    y = x;
                    if (f.GetChar(x, y) == GameChar.Null)
                    {
                        f.SetChar(GameChar.Cross, x, y);
                        return true;
                    }
                }
            }

            // Проверить на "урозу" заполнения противником второй диагонали ликвидировать ее
            dang = true;
            // Счетчик "Нулей" равен 0
            countZero = 0;
            //Счетчик "Крестов" раве 0
            countCross = 0;
            for (int x = 0; x < f.Size; x++) // Цикл по второй диагонали
            {
                int y;
                y = f.Size - 1 - x;
                if (f.GetChar(x, y) == GameChar.Cross)
                {
                    dang = false;
                    break;
                }
                if (f.GetChar(x, y) == GameChar.Zero) countZero++;
                if (f.GetChar(x, y) == GameChar.Cross) countCross++;
            } // end for (x)
            if (countZero < f.Size - 1)
                dang = false;

            // Если опасность - ликвидировать ее (поставить Cross)
            // Или если можно заполнить всю линию - тоже поставить Cross
            if ((dang == true) || (countCross >= f.Size - 1)) // Если опасность - ликвидировать ее (
            {
                for (int x = 0; x < f.Size; x++)
                {
                    int y;
                    y = f.Size - 1 - x;
                    if (f.GetChar(x, y) == GameChar.Null)
                    {
                        f.SetChar(GameChar.Cross, x, y);
                        return true;
                    }
                }
            }

                //
                // Иначе перебором заполняем в свободную клетку.
                //
                for (int i = 0; i < f.Size; i++)
                {
                    for (int j = 0; j < f.Size; j++)
                    {
                        if (f.GetChar(i, j) == GameChar.Null)
                        {
                            f.SetChar(GameChar.Cross, i, j);
                            return true;
                        }
                    }
                }

            return false;
        }

        /// <summary>
        /// Попытка пользователя сделать ход
        /// </summary>
        public static bool PutUserChar(GameField f, int x, int y)
        {
            if (f.GetChar(x, y) == GameChar.Null)
            {
                f.SetChar(GameChar.Zero, x, y);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Окончена ли игра
        /// </summary>
        public static bool IsGameFinished(GameField f)
        {
            if (CheckVictory(f, GameChar.Cross))
                return true;

            if (CheckVictory(f, GameChar.Zero))
                return true;

            return !CheckFreeSpace(f);
        }

        /// <summary>
        /// Кто победитель
        /// </summary>   
        public static GameChar GetWinner(GameField f)
        {
            if (CheckVictory(f, GameChar.Cross))
                return GameChar.Cross;

            if (CheckVictory(f, GameChar.Zero))
                return GameChar.Zero;

            return GameChar.Null;
        }


        //--- private ---------------------------------------------------------
        /// <summary>
        /// Победитель ли "с"
        /// </summary>
        private static bool CheckVictory(GameField f, GameChar c)
        {
            // Проверяем перебором все возможные варианты выйгрыша: заполнение 
            // по вертикали, по горизонтали и по двум диагоналям
            if ( CheckX(f, c) || CheckY(f, c) || CheckDiag1(f ,c) || CheckDiag2 (f, c) )
            {
                return true;
            }
           
            return false; // ничья
        }

        ///<summary>
        ///Проверка заполненности символом 'с' по горизонтали
        ///</summary>
        
        private static bool CheckX(GameField f, GameChar c)
        { 
            bool ret; // Возвращаемое значение

            for (int y = 0; y < f.Size; y++) // Цикл по всем вертикалям
            {
                ret = true;
                for (int x = 0; x < f.Size; x++) // Цикл по горизонтали
                {
                    if (f.GetChar(x, y) != c)
                    {
                        ret = false;
                        break;
                    }
                }
                if (ret == true)
                {
                    return true;
                }
            }
            return false;
        }
        ///<summary>
        ///Проверка заполненности символом 'с' по вертикали
        ///</summary>

        private static bool CheckY(GameField f, GameChar c)
        {
            bool ret; // Возвращаемое значение
            ret = true;

            for (int x = 0; x < f.Size; x++) // Цикл по всем горизонталям
            {
                
                for (int y = 0; y < f.Size; y++) // Цикл по вертикалям
                {
                    if (f.GetChar(x, y) != c)
                    {
                        ret = false;
                        break;
                    }
                }
                if (ret == true)
                {
                    return true;
                }
            }
            return false;
        }

        ///<summary>
        ///Проверка заполненности символом 'с' по первой диагонали
        ///</summary>

        private static bool CheckDiag1(GameField f, GameChar c)
        {

            bool ret; // Возвращаемое значение
            ret = true;

            for (int x = 0; x < f.Size; x++) // Цикл по первой диагонали
            {
                int y;
                y = x;
                
                if (f.GetChar(x, y) != c)
                {
                    ret = false;
                    break;
                           }
                }
                if (ret == true)
                {
                    return true;
                }

            return false;
        }

        ///<summary>
        ///Проверка заполненности символом 'с' по второй диагонали
        ///</summary>
        private static bool CheckDiag2(GameField f, GameChar c)
        {

            bool ret; // Возвращаемое значение
            ret = true;

            for (int x = 0; x < f.Size; x++) // Цикл по первой диагонали
            {
                int y;
                y = f.Size - 1 - x;

                if (f.GetChar(x, y) != c)
                {
                    ret = false;
                    break;
                }
            }
            if (ret == true)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Есть ли еще пустые клетки
        /// хранения логических значений, true и false.
        /// </summary>
        /// 
        private static bool CheckFreeSpace(GameField f)
        {
            for (int i = 0; i < f.Size; i++)
            {
                for (int j = 0; j < f.Size; j++)
                {
                    if (f.GetChar(i, j) == GameChar.Null)
                        return true;
                }
            }

            return false;
        }
    }
}
