using System;

namespace Application262E14
{
    public class Figura262E14
    {
        // Método estático para calcular el perímetro de la elipse
        // Recibe los dos semiejes (a y b)
        public static double Perimetro(double a, double b)
        {
            return Math.PI * (a + b);
        }

        // Método estático para calcular el área de la elipse
        public static double Area(double a, double b)
        {
            return Math.PI * a * b;
        }
    }
}