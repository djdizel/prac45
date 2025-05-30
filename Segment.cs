using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac45
{
    class Segment<T>
    {
        public T x1 { get; set; }
        public T y1 { get; set; }
        public T x2 { get; set; }
        public T y2 { get; set; }

        public Segment(T x1, T y1, T x2, T y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public override string ToString()
        {
            return $"Отрезок: ({x1}, {y1}) до ({x2}, {y2})";
        }
        public double Length()
        {
            double dx = Convert.ToDouble(x2) - Convert.ToDouble(x1);
            double dy = Convert.ToDouble(y2) - Convert.ToDouble(y1);
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
