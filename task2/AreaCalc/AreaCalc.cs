using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaCalc.interfaces;

namespace AreaCalc
{
    public static class AreaCalc
    {
        // Получение площади абстрактной фигуры
        public static double GetArea(IFigure fig) => fig.Area;
    }
}
