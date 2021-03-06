﻿///дает возможность ссылаться на классы, которые находятся в пространстве имен System, 
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
//содержит классы, реализующие поведение компонентов и элементов управления во время 
//проектирования и выполнения.Данное пространство имен включает базовые классы и интерфейсы, 
//предназначенные для реализации преобразователей атрибутов и типов, для привязки к 
//источникам данных и для лицензирования компонентов.
using System.ComponentModel;

// объявления области, которая содержит набор связанных объектов. Можно использовать 
//пространство имён для организации элементов кода, а также для создания глобально 
//уникальных типов.
namespace lab12
{
    //Определения класса с именем Form1
    public partial class Form1 : Form
    {
        //конструктор класса формы
        public Form1()
        {
            //Обязательный метод для поддержки конструктора - НЕ ИЗМЕНЯЙТЕ СОДЕРЖИМОЕ ДАННОГО 
            //МЕТОДА ПРИ ПОМОЩИ РЕДАКТОРА КОДА
            InitializeComponent();
        }
        //Нажатие на кнопку "ОК"
        private void button1_Click(object sender, EventArgs e)
        {
            //Если тектовое окно пустое
            if (txt1.Text == "")
            {
                //Вывод окна с ошибкой
                MessageBox.Show("Текст не введен!", "Ошибка!");
                //Фокус на 1 текстовое окно
                txt1.Focus();
                //прерывание
                return;
            }
            //Добавляем элемент в список (listBox1)
            listBox1.Items.Add(txt1.Text);

        }

        //Нажатие на кнопку "Перевернуть все слова в строке"
        private void btn3_Click(object sender, EventArgs e)
        {
            //Если тектовое окно пустое
            if (txt1.Text == "")
            {
                //Вывод окна с ошибкой
                MessageBox.Show("Текст не введен!", "Ошибка!");
                //Фокус на 1 текстовое окно
                txt1.Focus();
                //прерывание
                return;
            }
            //переменную s1 преобразуем в текст
            string s1 = txt1.Text;
            //Пучтая строка f
            string f = "";

            //Получаем строковый массив, содержащий след подстроки, разделенные элементами заданного массива
            string[] split = s1.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            //Оператор foreach обрабатывает элементы в порядке, возвращенном массивом или 
            //перечислителем типа коллекции, обычно от нулевого до последнего элемента.
            foreach (string s in split)
            {
                //Идем сначала массива
                for (int i = 0; i < s.Length; i++)
                {
                    //К пустой строке f добавдяем имеющуюся строку s (в которой переставляем элементы)
                    f += s[(s.Length - i - 1)];

                }
                //Записываем получившуюся строку
                f += " ";
            }
            //Добавляем в список
            listBox1.Items.Add(f);

        }

        //Нажатие на кнопку "Удалить в строке все числовые символы"
        private void btn2_Click(object sender, EventArgs e)
        {
            //Если тектовое окно пустое
           if (txt1.Text == "")
            {
                //Вывод окна с ошибкой
                MessageBox.Show("Текст не введен!", "Ошибка!");
                //Фокус на 1 текстовое окно
                txt1.Focus();
                //прерывание
                return;
            }
           //переменную s1 преобразуем в текст
            string s1 = txt1.Text;
            //Идем сначала массива
            for (int i = 0; i < s1.Length;i++ )
            {
                //Если символ относится к категории десятичных цыфр
                if (Char.IsDigit(s1[i]))
                {
                    //Удаляем его
                    s1=s1.Remove(i,1);
                    i--;
                }
            }
            //Добавляем в список
            listBox1.Items.Add(s1);

        }

        //Событие происходит, когда форма начинает отображаться.
        private void Form1_Shown(object sender, EventArgs e)
        {
            //Фокус на 1 текстовое окно 
            txt1.Focus();
        }
    }
}
