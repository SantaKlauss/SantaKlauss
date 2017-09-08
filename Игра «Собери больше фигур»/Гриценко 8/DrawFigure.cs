//дает возможность ссылаться на классы, которые находятся в пространстве имен System, 
//так что их можно использовать, не добавляя System. перед именем типа.
using System;
//обеспечивает доступ к базовым функциональным возможностям графического интерфейса GDI+
using System.Drawing;

// объявления области, которая содержит набор связанных объектов. Можно использовать 
//пространство имён для организации элементов кода, а также для создания глобально 
//уникальных типов.
namespace Гриценко_8
{
    //Определения класса с именем DrawFigure
    class DrawFigure
    {
        //цвет контура и заливки в начале игры
        public static Pen penRhombus = new Pen(Color.Orange, 2), penEllipse = new Pen(Color.Red, 2);
        //Заливка фигуры
        public static SolidBrush brushRhombus = new SolidBrush(Color.Lime), brushEllipse = 
            new SolidBrush(Color.Yellow);
        //объявление переменных
        public static void doDrawEmpty(Graphics graph, Color clr, int koef, int y, int x) 
        {
            //определение
            //расположения и размера клетки:кооринаты клетки
            Rectangle rect = new Rectangle(new Point(1 + x, 1 + y), 
                new Size(koef * 10 - 1, koef * 10 - 1));

            // заливка новым цветом
            graph.FillRectangle(new SolidBrush(clr), rect);
        }
        
        //Рисование ромба
        public static void doDrawRhombus(Graphics graph, Pen pen, Brush brush, int koef, int y, int x)        
        {
            //Представляет упорядоченную пару целых чисел — координат Х и Y, 
            //определяющую точку на двумерной плоскости.
            Point[] points =
            {
                //Точки
               new Point(koef*5 + x, koef*2 + y),
               new Point(koef*2 + x, koef*5 + y),
               new Point(koef*5 + x, koef*8 + y),
               new Point(koef*8 + x, koef*5 + y)
            };
          //отчиска поля 
          doDrawEmpty(graph, Color.White, koef, y, x);
          //рисование заливки
          graph.FillPolygon(brush, points);
          //рисование контура
          graph.DrawPolygon(pen, points);
        }
        
        //Рисовние элипса
        public static void doDrawEllipse(Graphics graph, Pen pen, Brush brush, int koef, int y, int x)
        {
            //определение
            //расположения и размера клетки:кооринаты клетки
            Rectangle rect = new Rectangle
                (new Point(koef * 2 + x, koef * 3 + y), new Size(koef * 6, koef * 4));
            //отчиска поля 
            doDrawEmpty(graph, Color.White, koef, y, x);
            //рисование заливки
            graph.FillEllipse(brush, rect);
            //рисование контура
            graph.DrawEllipse(pen, rect);
        }
    }
}
