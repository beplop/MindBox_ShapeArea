using System;

namespace ShapeAreaLib
{
    public class Shape
    { /*Пишем перегрузку двух методов, которые срабатывают
        в зависимости от количества поступаемых переменных.
        Поэтому нам не обязательно знать тип фигуры*/

        /// <summary>
        /// Вычисляет площадь круга
        /// </summary>
        /// <param name="x">Радиус круга</param>
        /// <returns></returns>
        public double GetArea(double x)
        {
            double s;
            s = Math.PI * Math.Pow(x, 2);
            return s;
        }
        /// <summary>
        /// Вычисляет площадь треугольника
        /// </summary>
        /// <param name="x">Первая сторона треугольника</param>
        /// <param name="y">Вторая сторона треугольника</param>
        /// <param name="z">Третья сторона треугольника</param>
        /// <returns></returns>
        public double GetArea(double x, double y, double z)
        {
            double p;
            double s;
            p = (x + y + z) / 2;
            s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            if (Math.Pow(x, 2) == Math.Pow(y, 2) + Math.Pow(z, 2) ||
               Math.Pow(y, 2) == Math.Pow(x, 2) + Math.Pow(z, 2) ||
               Math.Pow(z, 2) == Math.Pow(y, 2) + Math.Pow(x, 2))
            {
                Console.WriteLine("Треугольник является прямоугольным");
            }
            return s;
        }

    }
}
