using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac45
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Segment<int> segment1 = new Segment<int>(1, 1, 3, 3);
        Segment<double> segment2 = new Segment<double>(1.5, 2.5, 3.5, 4.5);
        Segment<uint> segment3 = new Segment<uint>(1, 2, 3, 4);

        int intLength = (int)segment1.Length();
        double doubleLength = segment2.Length();
        uint uintLength = (uint)segment3.Length();

        Console.WriteLine(segment1.ToString() + " Длина: " + intLength);
        Console.WriteLine(segment2.ToString() + " Длина: " + doubleLength);
        Console.WriteLine(segment3.ToString() + " Длина: " + uintLength);
        }
    }
}
