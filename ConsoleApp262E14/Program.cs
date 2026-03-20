using System;

namespace CalculoElipse
{
    class Program
    {
        static void Main(string[] args)
        {
            // // 1. Declaración de variables
            double a = 10; // Semieje mayor
            double b = 5;  // Semieje menor

            // // 2. Cálculos de la Elipse
            // Usamos Math.PI para obtener el valor preciso de π
            double perimetro = Math.PI * (a + b);
            double area = Math.PI * a * b;

            // // 3. Salida en Consola
            
            Console.WriteLine($"El perímetro de una elipse con semiejes de {a}cm y {b}cm es: {perimetro}cm");
            Console.WriteLine($"El área de una elipse con semiejes de {a}cm y {b}cm es: {area}cm2");

            // Esperar a que el usuario presione una tecla para cerrar
            Console.ReadKey();
        }
    }
}
