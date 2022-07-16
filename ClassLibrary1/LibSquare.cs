using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSquare
{

  
    public class Circle
    {

        public  static void InputValidation(double r)
        {
            if (r <= 0) throw new Exception("Радиус не может ,быть меньше или равен нулю!");
        }


        public static double GetArea(double r)
        {

            InputValidation(r);

            return Math.PI * Math.Pow(r, 2);

        }

    }
    public class Triangle
    {


        public static void InputValidation(double a, double b, double c)
        {
            if ((a <= 0) || (b <= 0) || (c <= 0)) throw new Exception("Ни одна из сторон треугольника не может быть меньше или равна нуля!");
        }

        public static double GetArea(double a, double b, double c)
        {

            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                return a * b / 2;

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));


        }

    }





}