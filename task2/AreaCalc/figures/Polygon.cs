using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaCalc.interfaces;

namespace AreaCalc.figures
{
    public class Polygon : IFigure
    {
        protected List<double> _sides;

        public Polygon(List<double> sides)
        {
            // Проверка валидности длин сторон
            foreach (var side in sides)
            {
                if (side < 0.0)
                {
                    throw new ArgumentException("Side can't be negative");
                }
            }
            _sides = sides;
        }

        public virtual double Area { get { throw new NotImplementedException(); } }
    }
}
