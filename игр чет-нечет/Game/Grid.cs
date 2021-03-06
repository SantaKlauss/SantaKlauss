﻿//дает возможность ссылаться на классы, которые находятся в пространстве имен System, 
//так что их можно использовать, не добавляя System. перед именем типа.
using System;
//Содержит интерфейсы и классы, определяющие универсальные коллекции, 
//которые позволяют пользователям создавать строго типизированные коллекции, 
//обеспечивающие повышенную производительность и безопасность типов 
//по сравнению с неуниверсальными строго типизированными коллекциями.
using System.Collections.Generic;
//Пространство имен System.ComponentModel содержит классы, реализующие поведение 
//компонентов и элементов управления во время проектирования и выполнения.Данное 
//пространство имен включает базовые классы и интерфейсы, предназначенные для реализации 
//преобразователей атрибутов и типов, для привязки к источникам данных и для лицензирования
//компонентов
using System.ComponentModel;
//Пространство имен System.Data обеспечивает доступ к классам, которые представляют архитектуру
//ADO.NET.Архитектура ADO.NET позволяет создавать компоненты, эффективно работающие с данными 
//из различных источников.
using System.Data;
//обеспечивает доступ к базовым функциональным возможностям графического интерфейса GDI+
using System.Drawing;
//Пространство имен содержит классы, представляющие ASCII и Unicode 
//кодировок; абстрактные базовые классы для преобразования блоков символов
//и из блоков байтов
using System.Text;
// содержит классы для создания приложений Windows, которые позволяют наиболее эффективно 
//использовать расширенные возможности пользовательского интерфейса, 
//доступные в операционной системе Microsoft Windows
using System.Windows.Forms;
//Пространство имен System.IO содержит типы, позволяющие осуществлять чтение и запись
//в файлы и потоки данных, а также типы для базовой поддержки файлов и папок.
using System.IO;

// объявления области, которая содержит набор связанных объектов. Можно использовать 
//пространство имён для организации элементов кода, а также для создания глобально 
//уникальных типов.
namespace Game
{
    //Определения класса с именем Grid
    class Grid
    {
        // private является модификатором доступа к члену.Закрытый (private) доступ является уровнем 
        //доступа с минимальными правами.Доступ к закрытым членам можно получить только внутри тела 
        //класса или структуры, в которой они объявлены
        private SolidBrush br; // заливка
        private Graphics dc; // графические объект
        private Pen pen; // кисть
        private int n; // размер сетки
        private int width; // ширина ячейки сетки
        private int height; // высота ячейки сетки
        private int[,] m; // массив введенных значений
        
        public static string path = @"log.txt";
        //StreamWriter f; // указатель на log файл

        //Сетка
        public Grid(PictureBox pictureBox1, int _n)
        {
            //Задаем объект для элемента управления
            dc = pictureBox1.CreateGraphics();
            //Создаем новый экземпляр класса
            //Кисти задаем черный цает 
		    pen  = new Pen(Color.Black, 2);
            //Инициализируем новый объект указанного цвета
            //Цвет заливки - белый
            br = new SolidBrush(Color.White);
            //Размер сетки
		    n = _n;
            //Задаем ширину
		    width   = pictureBox1.Width  / n;
            //Задаем высоту
		    height  = pictureBox1.Height / n;

            //f = new StreamWriter("log.txt");
            //f.Write("Число четных сумм   Число нечетных сумм\n");
            //File.WriteAllText(path, "Число четных сумм   Число нечетных сумм\r\n",Encoding.GetEncoding(1251));
            //Новый массив чисел
		    m = new int[n,n];
            //Вывод сетки соответственным введеным числам
		    for (int i = 0; i < n; i++)
		    {
			    for (int j = 0; j < n; j++)
				    m[i,j] = -1;
		    }
        }

        //Конструктор
        ~Grid()
        {
            //f.Close();
        }

        /// <summary>
        /// метод вывода сетки
        /// </summary>
        /// <param name="pictureBox1"></param>
        public void DrawGrid(PictureBox pictureBox1)
        {
            //Задаем ширину элемента управления
            pictureBox1.Width = width * n + 1;
            //Задаем высоту элемента управления
            pictureBox1.Height = height * n + 1;
            //Заполняет внутреннюю часть прямоугольника, который определен парой 
            //координат, шириной и высотой
            dc.FillRectangle(br, 0, 0, pictureBox1.Width, pictureBox1.Height);
            //Шаг = 0
            int step=0;
            //Увеличиваем шаг с каждым ходом
            for (int x = 0; x < pictureBox1.Width; x += width)
                for (int y = 0; y < pictureBox1.Height; y += height, step++)
                    //Ресуем прямоугольник, который определен парой координат, шириной и высотой
                    dc.DrawRectangle(pen, x, y, width, height);
        }

        /// <summary>
        /// метод прорисовки «1» - единицы
        /// </summary>
        /// <param name="pictureBox1"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public bool Draw1(PictureBox pictureBox1, int x, int y)
        {
            //берем 2 точки по модулю
            //ширина
            int sx = x - x % width;
            //высота
		    int sy = y - y % height;
            if (m[sx / width, sy / height] != -1) return false;
            //Проводим линую соединяющую 2 точки задаваемые парами координат
            //Преобразует строковое представление числа с указанным основанием системы счисления
            //в эквивалентное ему 32-битовое целое число со знаком.
		    dc.DrawLine(pen, Convert.ToInt32(sx + 0.5 * width), Convert.ToInt32(sy + 0.1 * height), 
                Convert.ToInt32(sx + 0.5 * width), Convert.ToInt32(sy + 0.9 * height));
            //Если массив =1 
		    m[sx / width,sy / height] = 1;
            //Прерывание
            return true;
        }

        /// <summary>
        /// метод прорисовки «0» -нуля
        /// </summary>
        /// <param name="pictureBox1"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public bool Draw0(PictureBox pictureBox1, int x, int y)
        {
            //берем 2 точки по модулю
            //ширина
            int sx = x - x % width;
            //высота
            int sy = y - y % height;

            if (m[sx / width, sy / height] != -1) return false;
            //Проводим линую соединяющую 2 точки задаваемые парами координат
            //Преобразует строковое представление числа с указанным основанием системы счисления
            //в эквивалентное ему 32-битовое целое число со знаком.
            dc.DrawEllipse(pen, Convert.ToInt32(sx + 0.1 * width), Convert.ToInt32(sy + 0.1 * height), 
                Convert.ToInt32(0.8 * width), Convert.ToInt32(0.8 * height));
            //Если массив = 0 
            m[sx / width, sy / height] = 0;
            //Прерывание
            return true;
        }
        
        /// <summary>
        /// метод расчетов результата игры
        /// </summary>
        /// <param name="textBox1"></param>
        /// <param name="textBox2"></param>
        public void Result(TextBox textBox1, TextBox textBox2)
        {
            //Изначально все переменные = 0
            int chet = 0, nechet = 0;
		    int s = 0, t = 0;
		
            //Идем по строке массива
		    for (int i = 0; i < n; i++)
		    {
                //Идем по столбцу массива
			    for (int j = 0; j < n; j++)
			    {
                    //Прибавляем по строке
				    s += m[i,j];
                    //Прибавляем по столбцу
				    t += m[j,i];
			    }
                // Если назначение модуля.Разделите значение s на значение 2, 
                //сохраните остаток в s и возвратите новое значение.
                //По строке считаем четные 
			    if (s % 2 == 0) chet++;
                // Если назначение модуля.Разделите значение s на значение 2, 
                //сохраните остаток в s и возвратите новое значение.
                //По строке считаем нечетные 
			    if (s % 2 == 1) nechet++;
                // Если назначение модуля.Разделите значение s на значение 2, 
                //сохраните остаток в s и возвратите новое значение.
                //По столбцу считаем четные 
			    if (t % 2 == 0) chet++;
                // Если назначение модуля.Разделите значение s на значение 2, 
                //сохраните остаток в s и возвратите новое значение.
                //По столбцу считаем нечетные 
			    if (t % 2 == 1) nechet++; 
			    s = 0; t = 0;
		    }
            //переменные = 0
            s = 0; t = 0;
            //Идем по строкам всей сетки
		    for (int i = 0; i < n; i++)
		    {
                //считаем по строке   
			    s += m[i,i];
                //считаем по диагонали
			    t += m[n - i - 1,i];
		    }
            // Если назначение модуля.Разделите значение s на значение 2, 
            //сохраните остаток в s и возвратите новое значение.
            //По строке считаем четные 
		    if (s % 2 == 0) chet++;
            // Если назначение модуля.Разделите значение s на значение 2, 
            //сохраните остаток в s и возвратите новое значение.
            //По строке считаем нечетные 
		    if (s % 2 == 1) nechet++;
            // Если назначение модуля.Разделите значение s на значение 2, 
            //сохраните остаток в s и возвратите новое значение.
            //По диагонали считаем четные 
		    if (t % 2 == 0) chet++;
            // Если назначение модуля.Разделите значение s на значение 2, 
            //сохраните остаток в s и возвратите новое значение.
            //По диагонали считаем нечетные
		    if (t % 2 == 1) nechet++; 

            //Вывод строкового значения в текстовом поле
            //С результатами 
		    textBox1.Text = chet.ToString();
		    textBox2.Text = nechet.ToString();
            //Сохраняем статистику в файле
            //При каждой новой игре создается новая строка 
            //f = new StreamWriter("log.txt");
            //f.Write("Число четных сумм   Число нечетных сумм\n");
            //File.WriteAllText(path, "Число четных сумм   Число нечетных сумм\r\n",Encoding.GetEncoding(1251));
            File.AppendAllText(path, String.Format("{0} {1}\r\n", chet, nechet), Encoding.GetEncoding(1251));
        }
    }
}
