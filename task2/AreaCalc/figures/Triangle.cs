using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc.figures
{
    public class Triangle : Polygon
    {
        public Triangle(List<double> sides) : base(sides)
        {
            if (sides.Count != 3)
            {
                throw new ArgumentException("Incorrect sides count");
            }
            // Проверка неравенства тре-ка, стороны сортируются по возрастанию их длин
            _sides.Sort();
            if (_sides[0] + _sides[1] <= _sides[2])
            {
                throw new ArgumentException("Triangle not exists");
            }
        }

        public Triangle(double a, double b, double c) : this(new List<double> { a, b, c }) { }

        // Является ли тре-к прямоугольным
        private bool IsRight() => _sides[0] * _sides[0] + _sides[1] * _sides[1] == _sides[2] * _sides[2];

        public override double Area
        {
            get
            {
                // Если прямоугольный, полупроизведение катетов
                if (IsRight())
                {
                    return _sides[0] * _sides[1] / 2;
                }
                // Формула Герона
                var p = _sides.Sum() / 2;
                return Math.Sqrt(p * (p - _sides[0]) * (p - _sides[1]) * (p - _sides[2]));
            }
        }
    }
}
