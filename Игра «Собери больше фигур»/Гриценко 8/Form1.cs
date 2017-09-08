//дает возможность ссылаться на классы, которые находятся в пространстве имен System, 
//так что их можно использовать, не добавляя System. перед именем типа.
using System;
//обеспечивает доступ к базовым функциональным возможностям графического интерфейса GDI+
using System.Drawing;
// содержит классы для создания приложений Windows, которые позволяют наиболее эффективно 
//использовать расширенные возможности пользовательского интерфейса, 
//доступные в операционной системе Microsoft Windows.
using System.Windows.Forms;

// объявления области, которая содержит набор связанных объектов. Можно использовать 
//пространство имён для организации элементов кода, а также для создания глобально 
//уникальных типов.
namespace Гриценко_8
{
    //Определения класса с именем FormMain
    public partial class Form1 : Form
    {
        //конструктор класса формы
        public Form1()
        {
            //Обязательный метод ля поддержки конструктора - НЕ ИЗМЕНЯЙТЕ СОДЕРЖИМОЕ ДАННОГО 
            //МЕТОДА ПРИ ПОМОЩИ РЕДАКТОРА КОД
            InitializeComponent();
        }
        //задается графические поля для ..
        Graphics graphField, graphUser, graphPC;
        //4 ромба, 2 элипса
        static int countRhombus = 4, countEllipse = 2;
        //начальные зачения у компьютера и чеовека.в начале игры
        static int countRhombusUser = 0, countEllipseUser = 0;
        static int countRhombusPC = 0, countEllipsePC = 0;
        //кол-во клеток.размер поля.размер стороны квадрада
        static int sizeField = 6, koef = 40;
        //начало игры.
        int[,] arrGame = new int[sizeField, sizeField];
        //это когда не нажата данная кнопка
        static int valEmpty = 0, valTriangle = 1, valEllipse = 2;
        //нажата кнопка
        static int valGuessEmpty = 10, valGuessTriangle = 11, valGuessEllipse = 12;
        // кол-во нажатых фигур в начале игры
        // 1
        static int countItems = 0, countGuess = 0;

        //Событие происходит до первоначального отображения формы.
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //при запуске игры массив срыт.заа кнопкой
            this.Width = btnShow.Left + btnShow.Width + 25;
            //задается поле для рисования в форме 1.большое поле игры
            graphField = pctField.CreateGraphics();
            //для чел. 
            graphUser = pctUser.CreateGraphics();
            //для компа
            graphPC = pctPC.CreateGraphics();
            //массив очищается
            grid.Rows.Clear();
            //кол-во столбцов и строк равны рамеру игрового поля
            grid.RowCount = sizeField;
            grid.ColumnCount = sizeField;
        }
        //6

        //Событие происходит при перерисовке элемента управления.
        private void pctField_Paint_1(object sender, PaintEventArgs e)
        {
            //поле для игры очищается белым
            graphField.Clear(Color.WhiteSmoke);
            //начало цикла 
            for (int i = 0; i < sizeField + 1; i++)
            {
                //рисование клеочек для игрового поля
                //Метод проводит линию, соединяющую две структуры Point.
                graphField.DrawLine(new Pen(Color.Black), 0, i * koef, pctField.Width, i * koef);
                graphField.DrawLine(new Pen(Color.Black), i * koef, pctField.Width, i * koef, 0);
            }
            
            for (int i = 0; i < sizeField; i++)
                for (int j = 0; j < sizeField; j++)
                {
                    //Если фигуры нет в данном квадратике,то квадратик закашивается белым
                    if (arrGame[i, j] == valGuessEmpty)
                        //Закрашиваем белым цветом
                        DrawFigure.doDrawEmpty(graphField, Color.White, koef / 10, i * koef, j *
                            koef);
                    //если есть то ромб
                    else if (arrGame[i, j] == valGuessTriangle)
                        //В ячейке рысуется ромб
                        DrawFigure.doDrawRhombus(graphField, DrawFigure.penRhombus,
                        DrawFigure.brushRhombus, koef / 10, i * koef, j * koef);
                    //если есть то элипс
                    else if (arrGame[i, j] == valGuessEllipse)
                        //В ячейке рысуется элипс
                        DrawFigure.doDrawEllipse(graphField, DrawFigure.penEllipse,
                        DrawFigure.brushEllipse, koef / 10, i * koef, j * koef);
                }
        }
        //2
        //Событие при нажатии кнопуи старт.
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            //кол-во открытых =0
            countItems = 0;
            countGuess = 0;
            countRhombusUser = 0; countEllipseUser = 0;
            countRhombusPC = 0; countEllipsePC = 0;
            //массив размера игрового поля
            for (int i = 0; i < sizeField; i++)
                for (int j = 0; j < sizeField; j++)
                    arrGame[i, j] = 0;
            //рандомно распологаются в массиве
            Random random = new Random();
            int iNum, jNum;
            // Ромб
            for (int numPlace = 0; numPlace < countRhombus; )
            {
               //кол-во расставленных фигур,
               //кол-во расставленных треугольников не должно превышать заданное кол-во
               //рандомное расположение фигур
                iNum = random.Next(0, sizeField);
                jNum = random.Next(0, sizeField);
                if (arrGame[iNum, jNum] == valEmpty)
                {
                    arrGame[iNum, jNum] = valTriangle;
                    //цикл будет рботать до 4х
                    numPlace++;
                }
            }
            // эллипсы
            for (int numPlace = 0; numPlace < countEllipse; )
            {
                //кол-во расставленных фигур,
                //кол-во расставленных элипсов не должно превышать заданное кол-во
                //рандомное расположение фигур
                iNum = random.Next(0, sizeField);
                jNum = random.Next(0, sizeField);
                if (arrGame[iNum, jNum] == valEmpty)
                {
                    arrGame[iNum, jNum] = valEllipse;
                    //цикл будет рботать до 4х
                    numPlace++;
                }
            }
            //что из за нажатия 1 меняется на 11
            doShowGrid();
            doShowCount();
            //Ключевое слово this ссылается на текущий экземпляр класса, а также используется
            //в качестве модификатора первого параметра метода расширения.
            pctField_Paint_1(this, null);
            pctUser_Paint_1(this, null);
            pctPC_Paint_1(this, null);
        }
        //3
        //Показ количества угаданных ячеек
        void doShowCount()
        {
            //изменение метки,если выигрывает человек или комп
            lblRhombusUser.Text = countRhombusUser.ToString();
            lblEllipseUser.Text = countEllipseUser.ToString();
            lblRhombusPC.Text = countRhombusPC.ToString();
            lblEllipsePC.Text = countEllipsePC.ToString();
        }
        //4
        //Показ сетки
        void doShowGrid()
        {
            for (int i = 0; i < sizeField; i++)
            {
                //заполняются номерками ячейки массива
                grid.Columns[i].Name = (i + 1).ToString();
                grid.Columns[i].Width = 30;
                for (int j = 0; j < sizeField; j++)
                    grid.Rows[i].Cells[j].Value = (arrGame[i, j]).ToString();
            }
        }
        //5
        //нажатие мышью на ячейку
        private void pctField_MouseUp_1(object sender, MouseEventArgs e)
        {
            //если игра закончена то таймер включен
            if (isGameOver() || timer.Enabled == true)
                //таймер = ход компьютера
                return;
            //читает значение координаты,по х и у
            int i = e.Y / koef;
            int j = e.X / koef;
            // если в массиве i и j > 10 то нажимать нельзя
            if (arrGame[i, j] >= 10)
                return;
            //если меньше то играем дальше
            if (arrGame[i, j] < 10)
            {
                //если нажимаешь на треугольник
                //появляется треугольник на поле
                if (arrGame[i, j] == valTriangle)
                    countRhombusUser++;
                else if (arrGame[i, j] == valEllipse)
                    countEllipseUser++;
                // и в массив добавляется значение +10 если попадаешь на пустое место
                arrGame[i, j] += 10;
                countItems++;
            }
            //если мы попадаем на не пустую клетку
            if (arrGame[i, j] > valGuessEmpty)
            {
                //добавляется кол-во открытых фигур
                countGuess++;
            }
            doShowGrid();
            doShowCount();
            pctField_Paint_1(this, null);
            //запускает теймер
            timer.Start();
        }
        //8
        //Событие происходит, когда указанный интервал таймера истек и таймер включен.
        private void timer_Tick_1(object sender, EventArgs e)
        {
            //Если окончание игры
            if (isGameOver())
                //Прерываем
                return;
            //когда игра заканчивается и начинается новая. то создаем новый рандомный массив
            Random random = new Random();
            int iNum, jNum;
            //Пока истина
            while (true)
            {
                //Рандомное расположение фигур
                iNum = random.Next(0, sizeField);
                jNum = random.Next(0, sizeField);
                //Если массив < колл-ва угаданых ячеек
                if (arrGame[iNum, jNum] < valGuessEmpty)
                {
                    //Увелич массив
                    arrGame[iNum, jNum] += 10;
                    //Кол-во пунктов увелич на 1
                    countItems++;
                    //Если массив > колл-ва угаданых ячеек
                    if (arrGame[iNum, jNum] > valGuessEmpty)
                    {
                        //Кол-во угаданых ячеек увелич на 1 
                        countGuess++;
                        if (arrGame[iNum, jNum] == valGuessTriangle)
                            //Увелич количество ромбов угаданных ПК
                            countRhombusPC++;
                        else if (arrGame[iNum, jNum] == valGuessEllipse)
                            //Увелич количество элипсов угаданных ПК
                            countEllipsePC++;
                    }
                    doShowGrid();
                    doShowCount();
                    pctField_Paint_1(this, null);
                    //ход компьютера
                    timer.Stop();
                    break;
                }
            }
            //Конец игры
            isGameOver();
        }
        //7
        //Ключевое слово bool является псевдонимом для типа System.Boolean. Оно используется 
        //для объявления переменных для хранения логических значений, true и false.
        private bool isGameOver()
        {
            //Если кол-во угаданных = кол-ву ромбов и элепсов ИЛИ пункты равны размеры сетки
            if (countGuess == countRhombus + countEllipse ||
                countItems == sizeField * sizeField)
            {
                //Останавливаем таймер
                timer.Stop();
                //Если количество угаданных пользователем ромбов и элемпсов > чем кол-во
                //у ПК, то выводим окно с текстом ""
                if (countRhombusUser + countEllipseUser > countRhombusPC + countEllipsePC)
                    MessageBox.Show("Вы выйграли со счетом " + (countRhombusUser
                        + countEllipseUser).ToString() +
                        ":" + (countRhombusPC + countEllipsePC).ToString(), "Итог игры");
                //Иначе если количество угаданных пользователем ромбов и элемпсов < чем кол-во
                //у ПК, то выводим окно с текстом ""
                else if (countRhombusUser + countEllipseUser < countRhombusPC + countEllipsePC)
                    MessageBox.Show("Вы проиграли со счетом " + (countRhombusUser +
                        countEllipseUser).ToString() +
                        ":" + (countRhombusPC + countEllipsePC).ToString(), "Итог игры");
                //Иначе ничья
                else
                    MessageBox.Show("Ничья " + (countRhombusUser + countEllipseUser).ToString() +
                        ":" + (countRhombusPC + countEllipsePC).ToString(), "Итог игры");
                return true;
            }
            else
                return false;
        }

        //Нажатие на кнопку "->"
        private void btnShow_Click_1(object sender, EventArgs e)
        {
            //меняется стрелоча в другую сторону
            if (btnShow.Text.CompareTo("->") == 0)
            {
                //Ключевое слово this ссылается на текущий экземпляр класса, а также используется
                //в качестве модификатора первого параметра метода расширения.
                this.Width = grid.Left + grid.Width + 25;
                btnShow.Text = "<-";
            }
                //Иначе
            else
            {
                this.Width = btnShow.Left + btnShow.Width + 25;
                btnShow.Text = "->";
            }
        }

        //Нажатие на Настройки
        private void mnuSettings_Click_1(object sender, EventArgs e)
        {
            //Создание новой формы 
            FormSettings frmSet = new FormSettings();
            //после изменения и нажатия кнопки ОК данные записываются в 
            if (frmSet.ShowDialog() == DialogResult.OK)
                //фигуры изображаются исходя из настроек
                pctField_Paint_1(this, null);
        }
        //5
        //Нажатие на меню Выход
        private void mnuExit_Click_1(object sender, EventArgs e)
        {
            //Закрытие
            Close();
        }

        //Рисвание фигуры пользователя
        private void pctUser_Paint_1(object sender, PaintEventArgs e)
        {
            //с класса считываются
            //начение фигур.координаты фигур
            DrawFigure.doDrawRhombus(graphUser, DrawFigure.penRhombus, DrawFigure.brushRhombus,
               30 / 10, 0, 0);
            DrawFigure.doDrawEllipse(graphUser, DrawFigure.penEllipse, DrawFigure.brushEllipse, 30 /
                10, 30, 0);
        }
        //6
        //Рисвание фигуры ПК
        private void pctPC_Paint_1(object sender, PaintEventArgs e)
        {
            //с класса считываются
            //начение фигур.координаты фигур
            DrawFigure.doDrawRhombus(graphPC, DrawFigure.penRhombus, DrawFigure.brushRhombus, 30
                / 10, 0, 0);
            DrawFigure.doDrawEllipse(graphPC, DrawFigure.penEllipse, DrawFigure.brushEllipse, 30 /
                10, 30, 0);
        }

        //Нажатие на справку Правила игры
        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаем новую форму
            Game frmSet = new Game();
            // DialogResult Возвращает или задает результат диалога для формы.
            if (frmSet.ShowDialog() == DialogResult.OK)
                pctField_Paint_1(this, null);
        }
   
    }
}
