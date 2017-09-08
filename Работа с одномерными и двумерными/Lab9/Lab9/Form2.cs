///дает возможность ссылаться на классы, которые находятся в пространстве имен System, 
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
//компонентов.
using System.ComponentModel;
//Пространство имен System.Data обеспечивает доступ к классам, которые представляют архитектуру
//ADO.NET.Архитектура ADO.NET позволяет создавать компоненты, эффективно работающие с данными 
//из различных источников.
using System.Data;
//обеспечивает доступ к базовым функциональным возможностям графического интерфейса GDI+
using System.Drawing;
//Пространство имен System.Linq содержит классы и интерфейсы, которые поддерживают LINQ.
using System.Linq;
//Пространство имен содержит классы, представляющие ASCII и Unicode 
//кодировок; абстрактные базовые классы для преобразования блоков символов
//и из блоков байтов
using System.Text;
// содержит классы для создания приложений Windows, которые позволяют наиболее эффективно 
//использовать расширенные возможности пользовательского интерфейса, 
//доступные в операционной системе Microsoft Windows
using System.Windows.Forms;

// объявления области, которая содержит набор связанных объектов. Можно использовать 
//пространство имён для организации элементов кода, а также для создания глобально 
//уникальных типов.
namespace Lab9
{
    //Определения класса с именем Form1
    public partial class Form2 : Form
    {
        //Массив чисел
        double[,] a;
        //Генератор случайных чисел
        Random rand;

        //конструктор класса формы
        public Form2()
        {
            //Обязательный метод ля поддержки конструктора - НЕ ИЗМЕНЯЙТЕ СОДЕРЖИМОЕ ДАННОГО 
            //МЕТОДА ПРИ ПОМОЩИ РЕДАКТОРА КОДА 
            InitializeComponent();
            rand = new Random();
        }
        //Нажатие на кнопку "ОК"
        private void button1_Click(object sender, EventArgs e)
        {
            //Если не в интревале текстового окна1 ИЛИ не в интревале текстового окна2
            if ((!examOnInt(txt1)) || (!examOnInt(txt2)))
                //Прерывание
                return;
            //Переменная а = число двойной точности с плавающей точкой
            a = new double[Convert.ToInt32(txt1.Text), Convert.ToInt32(txt2.Text)];
            //Идем по строкам массива
            for (int i = 0; i < a.GetLength(0); i++)
                //Идем по столбцам массива
                for (int j = 0; j < a.GetLength(1); j++)
                    //В массиве рандомно записываются числа от (-10 до 10)
                    a[i, j] = rand.Next(-10, 10);
            output(grv, a);
        }
        //Интервал
        private bool examOnInt(TextBox txt)
        {
            {
                try
                {
                    //Преобразуем заданное строковое представление числа в эквивалентное 
                    //число с плавающей запятой двойной точности.
                    Convert.ToDouble(txt1.Text); Convert.ToDouble(txt2.Text);
                }

                //Ошибки, происходящие во время выполнения приложения.
                //Исключение
                catch (Exception)
                {
                    ////Ключевое слово this ссылается на текущий экземпляр класса, а также 
                    //используется в качестве модификатора первого параметра метода расширения
                    //Окно сообщения с ошибкой
                    MessageBox.Show(this, "Введите число!", "Сообщение об ошибке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Прерывание  ложно
                    return false;
                }
                //Прерывание
                return true;
            }
        }
        //Результат
        private void output(DataGridView grv, double[,] x)
        {
            //Получает коллекцию, содержащую все строки в элементе управления (отчищаем коллекцию)
            grv.Rows.Clear();
            //Задаем кол-во строк
            grv.RowCount = x.GetLength(0);
            //Задаем кол-во столбцов
            grv.ColumnCount = x.GetLength(1);
            //Идем по строкам массива
            for (int i = 0; i < x.GetLength(0); i++)
                //Идем по столбцам массива
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    //Получаем коллекцию столбцов
                    grv.Columns[j].Name = (j + 1).ToString();
                    //Задаем ширину столца
                    grv.Columns[j].Width = 30;
                    //Заполняем строку числами
                    grv.Rows[i].Cells[j].Value = (x[i, j]).ToString();
                }
        }
        //При отображении формы
        private void Form2_Shown(object sender, EventArgs e)
        {
            //Фокус становится в первое окно
            txt1.Focus();
            //Сетка задания 3 - недоступна
            grbTask3.Visible = false;
            ////Ключевое слово this ссылается на текущий экземпляр класса, а также 
            //используется в качестве модификатора первого параметра метода расширения
            this.Height = grbBasic1.Top + grbBasic1.Height + 50;
        }

        //Нажатие на меню - задача 3
        private void mnu3_Click(object sender, EventArgs e)
        {
            {
                //Задаем рассояние (в точках) между верхней границей элемента управления и верхней 
                //границей клиентской области контейнера
                grbTask3.Top = grbBasic1.Top + grbBasic1.Height + 10;
                ////Ключевое слово this ссылается на текущий экземпляр класса, а также 
                //используется в качестве модификатора первого параметра метода расширения
                this.Height = grbTask3.Top + grbTask3.Height + 50;
                //Сетка задания 3 - доступна
                grbTask3.Visible = true;
            }
        }
        //Кнопка "ОК" задачи 3
        private void btnTask3_Click(object sender, EventArgs e)
        {
            //Создаем новый массив
            double[,] b = new double[a.GetLength(0), a.GetLength(1)];
            //Использование ключевого слово ref приводит к передаче 
            //аргумента по ссылке, а не по значению.
            init(ref b);
            task3(ref b);
            //Результат
            output(grvTask3, b);
        }

        private void init(ref double[,] y)
        {
            //Идем по строкам массива
            for (int i = 0; i < a.GetLength(0); i++)
                //Идем по столбцам массива
                for (int j = 0; j < a.GetLength(1); j++)
                    y[i, j] = a[i, j];
        }
        //Решение задачи 3
        private void task3(ref double[,] b)
        {
            //Идем от начала масива по строкам
            for (int i = 0; i < b.GetLength(0); i++)
            {
                //Идем по столбцам массива
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    //Если строка мешьне столбца
                    //Делим на кол-во элементов
                    if (i < j) b[i, j] = 1.0 / (double) (i + j);
                        //Иначе
                    else
                        //Если строка - столбца
                        if (i == j) b[i, j] = 1.0;
                        else
                            //Делим по формуле
                            b[i, j] = Math.Asin((double) (i + j) / ((double) (2 * i + 3 * j)));
                }
            }
        }
        //Событие происходит при нажатии клавиши с буквой,пробела или клавиши 
        //BACKSPACE, если фокус находится в элементе управления.
        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Если нажатая кнопка не равна цифре
            if (txt1.Text != "" && e.KeyChar == 13)
                txt2.Focus();
        }
        //Событие происходит при нажатии клавиши с буквой,пробела или клавиши 
        //BACKSPACE, если фокус находится в элементе управления.
        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Если нажатая кнопка не равна цифре
            if (txt2.Text != "" && e.KeyChar == 13)
                button1_Click(sender, e);
        }
        //Нажатие на меню - сохранить
        private void mnuSave_Click(object sender, EventArgs e)
        {
            //Если массив = 0
            if (a == null)
            {
                //Вывод ошибки
                MessageBox.Show("Массив не определен, сохранение невозможно", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Прерывание
                return;
            }
            //Пространство имен System.IO содержит типы, позволяющие осуществлять чтение и запись
            //в файлы и потоки  данных, а также типы для базовой поддержки файлов и папок.
            //StreamWriter реализует TextWriter для записи символов в поток в определенной кодировке.
            //TextWriter представляет модуль записи, который может записывать последовательные наборы символов
            System.IO.StreamWriter fileWrite = new System.IO.StreamWriter("Array.dat"); fileWrite.WriteLine(a.GetLength(0));
            fileWrite.WriteLine(a.GetLength(1));
            //Записывает указанные данные с текущим признаком конца строки 
            //в стандартный выходной поток.
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    fileWrite.WriteLine(a[i, j]);
            //Закрытие файла
            fileWrite.Close();
        }
        //Нажатие на меню - открыть
        private void mnuOpen_Click(object sender, EventArgs e)
        {
            {
                //Пространство имен System.IO содержит типы, позволяющие осуществлять чтение и запись
                //в файлы и потоки  данных, а также типы для базовой поддержки файлов и папок.
                //StreamReader реализует объект TextReader, который считывает символы из потока байтов 
                //в определенной кодировке.
                System.IO.StreamReader fileReader = null;
                try
                {
                    //Создаем новый файл
                    //StreamReader  Реализует объект TextReader, который считывает символы из потока 
                    //байтов в определенной кодировке.
                    fileReader = new System.IO.StreamReader("Array.dat");
                    if (fileReader.Peek() >= 0)
                    {
                        //Преобразуем в строку 2 переменные (строка, столбец)
                        int n = Convert.ToInt32(fileReader.ReadLine());
                        int m = Convert.ToInt32(fileReader.ReadLine());
                        //Переменная а = число двойной точности с плавающей точкой
                        a = new double[n, m];
                        //Идем по массиву 
                        //строка
                        for (int i = 0; i < n; i++)
                            //Столбец
                            for (int j = 0; j < m; j++)
                            {
                                //Преобразуем заданное строковое представление числа в эквивалентное 
                                //число с плавающей запятой двойной точности
                                a[i, j] = Convert.ToDouble(fileReader.ReadLine());
                            }
                        //Преобразуем текст в строку
                        txt2.Text = m.ToString();
                        //Преобразуем текст в строку
                        txt1.Text = n.ToString();
                        //Результат Исходный массив
                        output(grv, a);
                        //Кнопка "Ок" доступна
                        button1.Enabled = true;
                    }
                }
                //Ошибки, происходящие во время выполнения приложения.
                //Исключение
                catch (Exception)
                {
                    //Вывод ошибки
                    MessageBox.Show("Открыть файл не удалось.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                //С помощью блока finally можно выполнить очистку всех ресурсов, выделенных в
                //блоке try, и можно запускать код даже при возникновении исключения в блоке try
                finally
                {
                    //Если текстовые редактор не равен 0
                    if (fileReader != null)
                        //Закрываем его
                        fileReader.Close();
                }
            }
        }
    }
}
