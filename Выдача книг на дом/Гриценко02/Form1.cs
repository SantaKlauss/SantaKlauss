//дает возможность ссылаться на классы, которые находятся в пространстве имен System, 
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
namespace Гриценко02
{
    //Определения класса с именем Form1
    public partial class Form1 : Form
    {
        //конструктор класса формы
        public Form1()
        {
            //Обязательный метод ля поддержки конструктора - НЕ ИЗМЕНЯЙТЕ СОДЕРЖИМОЕ ДАННОГО 
            //МЕТОДА ПРИ ПОМОЩИ РЕДАКТОРА КОДА
            InitializeComponent();
        }

        //Событие отображения формы
        private void Form1_Load(object sender, EventArgs e)
        {
            // выделение/первого элемента списка
            cmbReader.SelectedIndex = 0;
            // выделение/первого элемента списка
            lstBooks.SelectedIndex = 0;
        }

        //Нажатие на кнопку выход
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); // закрытие приложения
        }

        //Нажатие на кнопку Скрыть информацию
        private void btnVisibleInform_Click(object sender, EventArgs e)
        {
            grbInfrom.Visible = false; // рамка «Информация» невидима
            btnRemove.Enabled = false; // кнопка «Удалить строку» недоступна
            btnClear.Enabled = false; // кнопка «Очистить» недоступна
            btnVisibleInform.Enabled = false; // кнопка «Скрыть информацию» недоступна
        }

        //Нажатие на кнопку отчистить
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstInform.Items.Clear(); // очистка элементов списка
            btnRemove.Enabled = false; // кнопка «Удалить строку» недоступна
            btnClear.Enabled = false; // кнопка «Очистить» недоступна
        }

        //Нажатие на кнопку удалить
        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstInform.Items.Remove(lstInform.Text); // удаление выделенного элемента
            lstInform.SelectedIndex = lstInform.Items.Count - 1; // выделение последнего элемента
            if(lstInform.Items.Count == 0)
            {
                // если список пустой, тогда кнопки недоступны
                btnRemove.Enabled = false;
                btnClear.Enabled = false;
        }
    }
        //Нажатие на кнопку Получить информацию
        private void btnInform_Click(object sender, EventArgs e)
        {
            // рамка «Информация» видима
            grbInfrom.Visible = true;
            // кнопка «Удалить строку» видима
            btnRemove.Enabled = true;
            // кнопка «Очистить» видима
            btnClear.Enabled = true;
            // кнопка «Скрыть информацию» недоступна
            btnVisibleInform.Enabled = true;
            // очистка элементов отчишены
            lstInform.Items.Clear();
            lstInform.Items.Add(cmbReader.Text); // добавление нового элемента в список
            //Если выбран Школьник
            if (rdbStatus1.Checked)
                //Добавление элемента
                lstInform.Items.Add(rdbStatus1.Text);
                //Иначе если выбран Судент
            else if (rdbStatus2.Checked)
                //Добавление элемента
                lstInform.Items.Add(rdbStatus2.Text);
                //Иначе если выбран Работник
            else
                //Добавление элемента
                lstInform.Items.Add(rdbStatus3.Text);
            //Если выбрана книга
            if (chkBook.Checked)
                //Добавление элемента
                lstInform.Items.Add("Книги на руках");
            lstInform.Items.Add(lstBooks.Text);
            //Вывод количеста дней
            lstInform.Items.Add("Количество дней " + txtKol.Text);
            //Получает или задает индекс выбранного в настоящий момент 
            //элемента в объекте ListBox (индекс, начинающийся с нуля).
            lstInform.SelectedIndex = lstInform.Items.Count - 1;
        }
    }
}
