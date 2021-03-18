using System;
using System.Drawing;

namespace PointPerpendicularStraight
{
    // Дана прямая L и точка A. Найти точку пересечения прямой L с перпендикулярной ей прямой P, проходящей через точку A. 
    // Можете считать, что прямая задана либо двумя точками, либо коэффициентами уравнения прямой — как вам удобнее.
    // Ищем точку(x, y), которая лежит на прямой через точки(x1, y1) и(x2, y2), и прямая через точки(x, y) и(x3, y3) перпендикулярна прямой через точки(x1, y1) и(x2, y2).
    // Первое условие - (x - x1)/(y - y1) = (x2 - x1)/ (y2 - y1)
    // Ну, а второе - произведение наклонов должно давать -1 (Уравнение прямой - y = kx + b, и для перпендикулярных прямых k1* k2 = -1):
    // ((y1 - y2)/ (x1 - x2)) * ((y - y0)/ (x - x0)) = - 1
    // А дальше просто решаем эту систему уравнений...
    class Program
    {
          static void Main(string[] args)
        {
            Point p1 = new Point(100, 100);
            Point p2 = new Point(200, 200);
            Point p0 = new Point(100, 200);
            double x = (p1.X * p1.X * p0.X - 2 * p1.X * p2.X * p0.X + p2.X * p2.X * p0.X + p2.X * (p1.Y - p2.Y) * (p1.Y - p0.Y) - p1.X * (p1.Y - p2.Y) * (p2.Y - p0.Y)) / ((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
            double y = (p2.X * p2.X * p1.Y + p1.X * p1.X * p2.Y + p2.X * p0.X * (p2.Y - p1.Y) - p1.X * (p0.X * (p2.Y - p1.Y) + p2.X * (p1.Y + p2.Y)) + (p1.Y - p2.Y) * (p1.Y - p2.Y) * p0.Y) / ((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
            Point p3 = new Point((int)Math.Round(x), (int)Math.Round(y));
            Console.WriteLine(p3);
        }
    }
}
