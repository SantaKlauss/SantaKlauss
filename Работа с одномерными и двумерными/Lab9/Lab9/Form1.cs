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
    public partial class Form1 : Form
    {
        //Массив чисел
        int[] a;
        //Генератор случайных чисел
        Random rand;

        //конструктор класса формы
        public Form1()
        {
            //Обязательный метод ля поддержки конструктора - НЕ ИЗМЕНЯЙТЕ СОДЕРЖИМОЕ ДАННОГО 
            //МЕТОДА ПРИ ПОМОЩИ РЕДАКТОРА КОДА 
            InitializeComponent();
            rand = new Random();
        }

        //Событие происходит, когда форма начинает отображаться.
        private void Form1_Shown(object sender, EventArgs e)
        {
            //Ключевое слово this ссылается на текущий экземпляр класса, а также используется 
            //в качестве модификатора первого параметра метода расширения.
            this.Height = grbBasic.Top + grbBasic.Height + 50;
            //Воскус ставится на текстовое окно, для ввода элементов
            txtCount.Focus();
        }
        //Событие происходит при изменении значения свойства Text.
        //Введите количество элементов
        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            //Задача 1 недоступна
            grbTask1.Visible = false;
            //Задача 2 недоступна
            grbTask2.Visible = false;
            //Задачи недоступны
            mnuTask.Enabled = false;
        }

        //Событие происходит при нажатии клавиши с буквой,пробела или клавиши BACKSPACE, 
        //если фокус находится в элементе управления.
        //Введите количество элементов
        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Если количество элементов неравно цыфрам
            if (txtCount.Text != "" && e.KeyChar == 13)
                btnCount_Click(sender, e);
        }

        //Нажатие на кнопку ОК
        private void btnCount_Click(object sender, EventArgs e)
        {
            //Если нет на интервале
            if (!examOnInt(txtCount))
                //Прерывание
                return;
            //Преобразует строковое представление числа с указанным основанием системы счисления
            //в эквивалентное ему 32-битовое целое число со знаком.
            a = new int[Convert.ToInt32(txtCount.Text)];
            //Идем по массиву начиная с начала, пока i не станет > a
            for (int i = 0; i < a.Length; i++)
                //Диапазон от -10 до 10
                a[i] = rand.Next(-10, 10);
            //Результат исходный массив
            output(grvBasic, a);
            //Видимость Задачи доступна
            mnuTask.Enabled = true;
            //Видимость массива доступна
            mnuArray.Enabled = true;
        }

        //Итервал
        //Ключевое слово bool является псевдонимом для типа System.Boolean. 
        //Оно используется для объявления переменных для хранения логических значений, 
        //true и false.
        private bool examOnInt(TextBox txt)
        {
            //
            try
            {
                //Преобразует строковое представление числа с указанным основанием системы 
                //счисления в эквивалентное ему 32-битовое целое число со знаком.
                Convert.ToInt32(txt.Text);
            }
            //Представляет ошибки, происходящие во время выполнения приложения.
            catch (Exception)
            {
                //Отображает перед заданным объектом окно сообщения, содержащее заданный текст, 
                //заголовок, кнопки и значок.
                MessageBox.Show(this, "Введите число!", "Сообщение об ошибке",
                //Задает константы, определяющие кнопки, которые нужно отображать в окне MessageBox.
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Focus();
                //Ложное прерывание
                return false;
            }
            //Прерывание
            return true;
        }

        //Результат
        private void output(DataGridView grv, int[] d)
        {
            //Получает коллекцию, содержащую все строки в элементе управления (отчищаем коллекцию)
            grv.Rows.Clear();
            //Число строк = 1 
            grv.RowCount = 1;
            //Задаем кол-во столбоцов
            grv.ColumnCount = d.Length;

            for (int i = 0; i < d.Length; i++)
            {
                //Получает коллекцию, содержащую все строки в элементе управления
                grv.Columns[i].Name = (i + 1).ToString();
                //Задаем ширину столбца = 30
                grv.Columns[i].Width = 30;
                //Возвращаем коллекцию ячеек, заполняющих строку - преобразуем в строку
                grv.Rows[0].Cells[i].Value = (d[i]).ToString();
            }
        }
        //Задача 1
        private void mnuTask1_Click(object sender, EventArgs e)
        {
            //Задаем рассояние (в точках) между верхней границей элемента управления и верхней 
            //границей клиентской области контейнера
            grbTask1.Top = grbBasic.Top + grbBasic.Height + 10;
            //Ключевое слово this ссылается на текущий экземпляр класса, а также 
            //используется в качестве модификатора первого параметра метода расширения
            this.Height = grbTask1.Top + grbTask1.Height + 50;
            //Задача 1 доступна
            grbTask1.Visible = true;
            //Задача 2 недоступна
            grbTask2.Visible = false;
            txtTask1.Focus();
        }
        //Событие происходит при нажатии клавиши с буквой,пробела или клавиши 
        //BACKSPACE, если фокус находится в элементе управления.
        private void txtTask1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Если количество элементов неравно цыфрам
            if (txtTask1.Text != "" && e.KeyChar == 13)
                btnTask1.Focus();
        }

        //Нажатие на кнопку ОК
        private void btnTask1_Click(object sender, EventArgs e)
        {
            //Создаем новый массив
            int[] b = new int[a.Length];
            //Использование ключевого слово ref приводит к передаче 
            //аргумента по ссылке, а не по значению.
            init(ref b);
            task1(ref b);
            //Результат
            output(grvTask1, b);
        }

        private void init(ref int[] g)
        {
            //Идем по массиву пока i меньше кол-ва элементов в массиве
            for (int i = 0; i < g.Length; i++)
                //Уравнение массива
                g[i] = a[i];
        }

        //Задача 1
        private void task1(ref int[] b)
        {
            //Вывод окна с ошибкой
            if (txtTask1.Text == "")
            {
                MessageBox.Show("Введите число!", "Ошибка!");
                //Фокус на вводе элементов массива
                txtTask1.Focus();
                //Прерывание
                return;
            }
            // переменная z преобразуется в 2-битовое целое число со знаком.
            int z = Convert.ToInt32(txtTask1.Text);

            //заменение = 0
            int replaced = 0;
            // Идем с конца массива
            for (int i = b.Length-1; i >= 0; --i)
            {
                int index = i + replaced;
                //Если остаток от деления = 0 И индек > 0
                if ((b[index] % z == 0) && (b[index] > 0))
                {
                    //Заменяем индекс
                    int replace_value = b[index];

                    // Идем с конца массива
                    for (int j = index; j >= 1; --j)
                    {
                        b[j] = b[j - 1];
                    }
                    //Ставим в начало 
                    b[0] = replace_value;
                    replaced++;
                }                
            }
        }

        //Задача 2
        private void mnuTask2_Click(object sender, EventArgs e)
        {
            //Задаем рассояние (в точках) между верхней границей элемента управления и верхней 
            //границей клиентской области контейнера
            grbTask2.Top = grbBasic.Top + grbBasic.Height + 10;
            //Ключевое слово this ссылается на текущий экземпляр класса, а также 
            //используется в качестве модификатора первого параметра метода расширения
            this.Height = grbTask2.Top + grbTask2.Height + 50;
            //Задача 2 доступна
            grbTask2.Visible = true;
            //Задача 1 недоступна
            grbTask1.Visible = false;
        }
        //Задача 2
        private void task2(ref int[] b)
        {
            //минимальное число
            int min = b[0];
            //Мин индекс
            int min_ind = 0;
            
            int p_min = b[0];
            //Вставка
            bool p_min_set = (p_min > 0);

            //Идем сначала массива
            for (int i = 1; i < b.Length; i++)
            {
                //Находим минимальный ълемент
                if (b[i] < min)
                {
                    min = b[i];
                    min_ind = i;
                }

                //Если элемент > 0
                if (b[i] > 0)

                    //Если элемент < минимального ИЛИ не равен минимальнрму
                    if ( (b[i] < p_min) || !p_min_set )
                    {
                        //Находим мин 
                        p_min = b[i];
                        p_min_set = true;
                    }
            }
            //Если не нашли минимального положительного числа
            if (!p_min_set)
            {
                //Вывадим ошибку
                MessageBox.Show("Отсутствуют положительные числа!", "Ошибка!");
                txtTask1.Focus();
                return;
            }
       
            //Создаем новый массив
            int[] b2 = new int[b.Length+2];

            //Идем сначала масиива
            for (int i = 0; i < b.Length; i++)
            {
                //Индекс равен i
                int index = i;
                //Емси i = минимальноку индексу, индекс +1
                if (i == min_ind) index += 1;
                //Если i больше мин индекса, индекс +2
                if (i > min_ind) index += 2;
                b2[index] = b[i];
            }

            int b2_min_ind = min_ind + 1;
            //Переменная b2 = минимальному
            b2[b2_min_ind] = min;
            //Ставим перед и после этого числа
            b2[b2_min_ind - 1] = p_min;
            b2[b2_min_ind + 1] = p_min;
            b = b2;
        }

        //Сохранение результат 
        private void mnuSave_Click(object sender, EventArgs e)
        {
            //Если массив = 0
            if (a == null)
            {
                //Выводим ошибку
                MessageBox.Show("Массив не определен, сохранение невозможно", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Прерывание
                return;
            }
            //Реализует TextWriter для записи символов в поток в определенной кодировке.
            //TextWriter Представляет модуль записи, который может записывать последовательные 
            //наборы символов.Это абстрактный класс.
            System.IO.StreamWriter fileWrite = new System.IO.StreamWriter("Array.dat");
            fileWrite.WriteLine(a.Length);
            //Записывает указанные данные с текущим признаком конца строки 
            //в стандартный выходной поток.
            for (int i = 0; i < a.Length; i++)
                fileWrite.WriteLine(a[i]);
            fileWrite.Close();
        }
        //Меню открыть 
        private void mnuOpen_Click(object sender, EventArgs e)
        {
            //Пространство имен System.IO содержит типы, позволяющие осуществлять чтение и 
            //запись в файлы и потоки данных, а также типы для базовой поддержки файлов и папок.
            System.IO.StreamReader fileReader = null;
            try
            {
                //Создаем новый файл
                //StreamReader  Реализует объект TextReader, который считывает символы из потока 
                //байтов в определенной кодировке.
                fileReader = new System.IO.StreamReader("Array.dat");
                if (fileReader.Peek() >= 0)
                {
                    //Преобразуем в строку
                    int n = Convert.ToInt32(fileReader.ReadLine());
                    a = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        //Преобразуем в строку
                        a[i] = Convert.ToInt32(fileReader.ReadLine());
                        //Введите количество элементов преобразуем в строку
                    } txtCount.Text = n.ToString();
                    //Результат Исходный массив
                    output(grvBasic, a);
                    //Задачи доступны
                    mnuTask.Enabled = true;
                }
            }
            
            //Представляет ошибки, происходящие во время выполнения приложения.
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
        //Кнопка для задачи 2 "Ок"
        private void btnTask2_Click(object sender, EventArgs e)
        {
            //Массив 
            int[] b = new int[a.Length];
            //в нем хранится инф
            init(ref b);
            //Использование ключевого слово ref приводит к передаче 
            //аргумента по ссылке, а не по значению.
            task2(ref b);
            //Результат
            output(grvTask2, b);
        }
        //Меню = выход
        private void mnuExit_Click(object sender, EventArgs e)
        {
            //Закрытие
            Close();
        }
        //Меню - задачи - задача 3
        private void mnuTask3_Click(object sender, EventArgs e)
        {
            //Создание формы
            Form2 frmSet = new Form2();
            //Отображение формы в виде окна
            if (frmSet.ShowDialog() == DialogResult.OK);
        }
    }
}
