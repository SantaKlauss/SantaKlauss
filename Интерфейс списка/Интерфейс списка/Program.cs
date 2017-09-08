//Дает возможность ссылаться на классы, которые находятся в пространстве имен System, 
//так что их можно использовать, не добавляя System. перед именем типа.
using System;
//Содержит интерфейсы и классы, определяющие универсальные коллекции, 
//которые позволяют пользователям создавать строго типизированные коллекции, 
//обеспечивающие повышенную производительность и безопасность типов 
//по сравнению с неуниверсальными строго типизированными коллекциями.
using System.Collections.Generic;
//одержит интерфейсы и классы, которые определяют различные коллекции объектов, 
//такие как списки, очереди, двоичные массивы, хэш-таблицы и словари.
using System.Collections;
//Предоставляет компонент Timer, который позволяет вызывать событие через указанный интервал.
using System.Timers;
//Классы, позволяющие осуществлять взаимодействие с системными процессами, журналами событий и 
//счетчиками производительности.
using System.Diagnostics;

// объявления области, которая содержит набор связанных объектов. Можно использовать 
//пространство имён для организации элементов кода, а также для создания глобально 
//уникальных типов.
namespace Интерфейс_списка
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
            //Создаем 2 переменные 
            MyListTester ts1 = new MyListTester();
            MyListTester ts2 = new MyListTester();
            
            //Выводим текст на консоль
            Console.WriteLine("                      TEST");
            Console.WriteLine();
            // Запускаем 2 теста (MyVector - структура данных «вектор» и MyLinkedList - структуры данных «связный список»)
            Console.WriteLine("Add element in MyLinkedList - Execution time = " + ts1.TestAdd(new MyLinkedList<int>()).ToString());
            // Запускаем 2 теста (MyVector - структура данных «вектор» и MyLinkedList - структуры данных «связный список»)
            Console.WriteLine("Add element in MyVector     - Execution time = " + ts1.TestAdd(new MyVector<int>()).ToString());

            //Ждем следующую нажатую пользователем символ или функциональную клавишу.
            Console.ReadKey();

        }
    }

    //Класс связный список
    public class MyLinkedList<T> : IMylist<T>
    {
        //—private (Доступ ограничен содержащим типом.)---------------------------------------
        private class ListNode
        {
            //---public (Неограниченный доступ.)-------------------------------
            public T data;
            //Интерфейс списка
            public ListNode next;

            public ListNode(T data, ListNode next)
            {
                //слово this ссылается на текущий экземпляр класса, а также используется в качестве 
                //модификатора первого параметра метода расширения.
                //Объявляем 2 параметра
                this.data = data;
                this.next = next;
            }
        }

        //Кол-во элеметов = 0
        private int count = 0;
        //Начинаем считать от начала к концу
        private ListNode head = null;
        private ListNode tail = null;

        //—public-----------------------------------
        ///<summary>
        /// Добавление нового элемента в список
        /// </summary>
        /// <param name="data"></param>
        public void AddElement(T data)
        {
            //Если элементв еще нет, то добавляем его в начало 
            if (head == null)
            {
                //Создаем новый элемент
                head = new ListNode(data, null);
                //ставим в начало
                tail = head;
            }
            // иначе
            else
            {
                //Добавлякм элемент в конец списка
                tail.next = new ListNode(data, null);
                //Добавление 
                tail = tail.next;
            }
            //Увеличиваем колличество
            ++count;
        }

        //Добавление перед элементом 
        public void AddFront(T data)
        {
            //Если элементв еще нет, то добавляем его в начало 
            if (head == null)
            {
                //Создаем новый элемент
                head = new ListNode(data, null);
                //ставим в начало
                tail = head;
            }
            // иначе
            else
            {
                //Создаем новый узел
                ListNode newnode = new ListNode(data, head);
                //Добавлие
                head = newnode;
            }
            //Увеличиваем колличество
            ++count;

        }
        /// <summary>
        /// Вставка элемента в нужную позицию
        /// </summary>
        /// <param name="index">Позиция</param>
        /// <param name="data">Элемент</param>
        public void InsertElementIntoPos(int index, T data)
        {
            //Если элемент находится в нужном интревале
            if (index < 0 || index >= count)
                //ArgumentOutOfRangeException (Исключение, которое выбрасывается, когда значение 
                //аргумента находится вне допустимого диапазона значений, как определено вызываемым 
                //методом).
                //throw (Оператор throw используется для сообщения об аномальных ситуациях (исключениях) 
                //в ходе выполнения программы.)
                throw new ArgumentOutOfRangeException();
            
            //Если индекс = 0
            if (index == 0)
            {
                //Добавляем в нужную возицию
                AddFront(data);
            }
            
            //Иначе 
            else
            {
                //Создаем новый узел, добаляем элемент в начало списка
                ListNode r = head; 
                for (int i = 1; i < index; ++i) 
                    r = r.next;
                ListNode newnode = new ListNode(data, r.next);
                r.next = newnode;

                //Увеличиваем колличество
                ++count;
            }
        }
        /// <summary>
        /// Удаление всего списка
        /// </summary>
        public void ClearAll()
        {
            //Голова списка = о
            head = null;
            //Конец списка =0
            tail = null;
            //Колличество = 0
            count = 0;
        }

        ///<summary>
        ///Удаление элемента позиции
        ///</summary>
        ///<param name="index">Позиция</param>
        public void RemoveElement(int index)
        {
            //Если элемент находится в нужном интревале
            if (index < 0 || index >= count)
                //ArgumentOutOfRangeException (Исключение, которое выбрасывается, когда значение 
                //аргумента находится вне допустимого диапазона значений, как определено вызываемым 
                //методом).
                //throw (Оператор throw используется для сообщения об аномальных ситуациях (исключениях) 
                //в ходе выполнения программы.)
                throw new ArgumentOutOfRangeException();
            //Индекс = 0
            int idx = 0;

            // var ( Локальная переменная с неявным типом имеет строгую типизацию, как если бы тип был 
            //задан явно, только тип определяет компилятор.)
            var curr = head;

            //Предыдущий = 0
            ListNode prev = null;

            //Пока индекс элемента < индекса
            while (idx++ < index)
            {
                //Предыдущий = текущему
                prev = curr;
                curr = curr.next;
            }
            //Предыдущий = текущему
            prev.next = curr.next;

            //Количество уменьшается
            count--;
        }

        /// <summary>
        /// Перезапись элемента в позиции
        /// </summary>
        /// <param name="element">Элемент</param>
        /// <param name="index">Позиция</param>
        public void OverrideElementInPos(T element, int index)
        {
            //Если элемент находится в нужном интревале
            if (index < 0 || index >= count)
                //ArgumentOutOfRangeException (Исключение, которое выбрасывается, когда значение 
                //аргумента находится вне допустимого диапазона значений, как определено вызываемым 
                //методом).
                //throw (Оператор throw используется для сообщения об аномальных ситуациях (исключениях) 
                //в ходе выполнения программы.)
                throw new ArgumentOutOfRangeException();

            //Создаем элемент в начале списка
            head = new ListNode(element, null);
            //Вставляем в начало
            tail = head;
        }

        /// <summary>
        /// Получить элемент по позиции
        /// </summary>
        /// <param name="index">Позиция</param>
        /// <returns>Элемент</returns>
        public T GetElementInPos(int index)
        {
            //Если элемент находится в нужном интревале
            if (index < 0 || index >= count)
               
                throw new ArgumentOutOfRangeException();
            //ArgumentOutOfRangeException (Исключение, которое выбрасывается, когда значение 
            //аргумента находится вне допустимого диапазона значений, как определено вызываемым 
            //методом).
            //throw (Оператор throw используется для сообщения об аномальных ситуациях (исключениях) 
            //в ходе выполнения программы.)
            ListNode r = head;
            for (int i = 0; i < count; i++) 
            { 
                //Переменная = текущей позиции
                r = r.next; 
                if (index == i)
                {
                    //Прерывание 
                    return r.data;
                }
            }
            //Прерывание 
            return r.data;
        }

        //Перебор элементов
        public IEnumerator GetEnumerator()
        {
            //Для переменной r = началу списка, не равно 0, r= след элементу
            for (ListNode r = head; r != null; r = r.next)
                //Используйте выражение yield return для возвращения поочерёдно каждого элемента.
                yield return r.data;
        }

        //-- ............
        //Получить количество элементов списка
        public int Count
        {

            // метод доступа в свойстве или индексаторе, 
            //который извлекает значение свойства или элемент индексатора.
            get
            {
                //Прерывание
                return count;
            }
        }
        /// <summary>
        /// Получить количество элементов списка
        /// </summary>
        ///<returns></returns>
        public int GetCount()
        {
            //Прерывание
            return Count;
        }
    }

    ///<summary>
    ///Интерфейс 
    ///</summary>
    ///<typeparam name="T"></typeparam> 
    ///
    public interface IMylist<T>
    {
        //Получене элемента
        int GetCount();
        //Добавление элемента
        void AddElement(T element);
        //Вставить элемент по индексу
        void InsertElementIntoPos(int index, T element);
        //Удаление элемента
        void RemoveElement(int index);
        ////Вставить элемент по индексу
        T GetElementInPos(int index);
        //Вложение элемента 
        void OverrideElementInPos(T elementint, int index);
        //Очистить
        void ClearAll();
    }

    ///<summary>
    ///Класс Вектор 
    ///</summary>
    ///<typeparam name="T"></typeparam> 
    public class MyVector<T>:IMylist<T>
    {
        //—members------------------------------------------
        private T[] mArray;
        //—public-------------------------------------------
        public MyVector()
        {
            //Массив с нулевым размером
            mArray = new T[0];
        }
        //Количество
        public int Count()
        {
            //Прерывание 
            //Array.Length (Получает общее число элементов во всех измерениях массива Array.)
            return mArray.Length;
        }
        //Получение количества
        public int GetCount()
        {
            //Прерывание
            return Count();
        }
        /// <summary>
        /// Добавление нового элемента в список
        /// </summary>
        ///<param name="element"></param> 
        public void AddElement(T element)
        {
            //Манипулирует массивами простых типов.
            T[] buf = new T[mArray.Length];

            for (int i = 0; i < buf.Length; i++)
                buf[i] = mArray[i];

            //Создание нового массива
            mArray = new T[buf.Length + 1];
           
            for (int i = 0; i < buf.Length; i++)
                mArray[i] = buf[i];

            //Добавление в начло нового элемента
            mArray[mArray.Length - 1] = element;
        }

        ///<summary>
        ///Добавление нового элемента в список в нужную позицию 
        ///</summary>
        ///<param name="index">Позиция, куда вставляем</param>
        ///<param name="element">Элемент, который вставляем</param> 
        public void InsertElementIntoPos(int index, T element)
        {
            //Если элемент находится в нужном интревале
            if (index > mArray.Length || index < 0)
                //ArgumentOutOfRangeException (Исключение, которое выбрасывается, когда значение 
                //аргумента находится вне допустимого диапазона значений, как определено вызываемым 
                //методом).
                //throw (Оператор throw используется для сообщения об аномальных ситуациях (исключениях) 
                //в ходе выполнения программы.)
                throw new ArgumentOutOfRangeException();

            //Создание массива 
            T[] buf = new T[mArray.Length];

            for (int i = 0; i < buf.Length; i++)
                //Переменная = нужной позиции
                buf[i] = mArray[i];

            //Создание массива
            mArray = new T[buf.Length + 1];

            for (int i = 0; i < buf.Length; i++)
                mArray[i] = buf[i];
            T buffer = mArray[index];

            //Идем по элементам массива, начиная с конца
            for (int i = mArray.Length - 2; i >= index; i--)
            {
                //Находим нужный индекс
                T d = mArray[i];
                //Сдвигаем все элементы вправо 
                mArray[i + 1] = d;
            }
            
            //Добавляем элемент
            mArray[index] = element;
        }

        /// <summary>
        /// Удаление элемента no указанной позиции
        /// </summary>
        /// <param name="index">Позиция</param>
        public void RemoveElement(int index)
        {
            //Если элемент находится в нужном интревале
            if (index > mArray.Length || index < 0)
                //ArgumentOutOfRangeException (Исключение, которое выбрасывается, когда значение 
                //аргумента находится вне допустимого диапазона значений, как определено вызываемым 
                //методом).
                //throw (Оператор throw используется для сообщения об аномальных ситуациях (исключениях) 
                //в ходе выполнения программы.)
                throw new ArgumentOutOfRangeException();
            
            //Создание массива 
            T[] buf = new T[mArray.Length];
            for (int i = 0; i < buf.Length; i++)
                buf[i] = mArray[i];
            //Сдвигаем все элементы массива влево
            mArray = new T[buf.Length - 1];
            //Идем по элементам массива
            for (int i = 0; i < index; i++)
                mArray[i] = buf[i];
            //Находим указанный элемент
            for (int i = index; i < buf.Length - 1; i++)
                mArray[i] = buf[i + 1];
        }


        /// <summary>
        /// Перезаписать элемент в нужной позиции
        /// </summary>
        ///<param name="element"></param>
        ///<param name="index"></param>

        public void OverrideEleraentInPos(T element, int index)
        {
            //Идем по массиву
            for (int i = 0; i < mArray.Length; i++)
            {
                //Если элемент в нужной позиции
                if (i == index)
                    //Перезависываем
                    mArray[i] = element;
            }
        }

        /// <summary>
        /// Очистить список
        /// </summary>

        public void ClearAll()
        {
            //Создаем новый массив
            mArray = new T[0];
        }
        /// <summary>
        /// Вывод списка.
        /// </summary>

        public void Show()
        {
            //Выводим список на консоль
            Debug.WriteLine("");
            for (int i = 0; i < mArray.Length; i++)
                Debug.Write(mArray[i] + " ");
        }
    }
    ///<summary>
    ///Тест
    ///</summary>
    public class MyListTester
    {
        //—private---------------------------

        //Представляет генератор псевдослучайных чисел, то есть устройство, которое выдает 
        //последовательность чисел, отвечающую определенным статистическим критериям случайности.
        Random mRandom = new Random();

        //—public----------------------
        //Представляет интервал времени.
        public static TimeSpan mytimespan;
        //Засекам время начало
        public DateTime start;
        //Засекам время конца
        public DateTime end;

        //Интервал времени на добавление.
        public TimeSpan TestAdd(IMylist<int> list)
        {
            //Отчищаем лист
            list.ClearAll();
            for (int i = 0; i < 50000; i++)
            {
                //Выбираем рандомое кол-во элементов
                list.AddElement(mRandom.Next(100));
            }
            //Засекам время начало теста
            start = DateTime.Now;
            for (int i = 0; i < 300; i++)
            {
                //Добавление элемента
                list.AddElement(i);
            }
            //Засекаем время конца теста
            end = DateTime.Now;
            //Вычитаем
            mytimespan = end - start;
            //Прерывание
            return mytimespan;
        }

        //Интервал времени на вставку
        public TimeSpan TestInsert (IMylist<int> list)
            {
                //Засекам время начало теста
                start = DateTime.Now;
                //Вставляем в диапазон чисел 
                list.InsertElementIntoPos(1, 100);
                //Засекаем время конца теста
                end = DateTime.Now;
                //Вычитаем
                mytimespan = end - start;
                //Прерывание
                return mytimespan;
            }
        }
    }




