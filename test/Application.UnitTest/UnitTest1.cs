using Xunit;
// Esta línea es VITAL. Le dice a la prueba dónde buscar tu elipse.
using Application262E14; 

namespace Application.UnitTest
{
    public class UnitTestApplication
    {
        // ==========================================================
        // PRUEBA 1: ÁREA DE LA ELIPSE
        // Fórmula: PI * a * b
        // ==========================================================
        [Theory]
        // Caso 1: a=2, b=3 -> Área = PI * 6 ≈ 18.8495559...
        [InlineData(2, 3, 18.84955592153876)] 
        // Caso 2: a=5, b=5 (un círculo) -> Área = PI * 25 ≈ 78.5398163...
        [InlineData(5, 5, 78.53981633974483)] 
        // Caso 3: a=1, b=10 -> Área = PI * 10 ≈ 31.4159265...
        [InlineData(1, 10, 31.41592653589793)] 
        public void CalcularAreaElipse_SemiEjesValidos_ResultadoCorrecto(double semiEjeA, double semiEjeB, double esperado)
        {
            // Act: Llamamos al método estático Area de TU clase Figura262E14
            double actual = Figura262E14.Area(semiEjeA, semiEjeB);

            // Assert: Comparamos resultados. 
            // Usamos un 3er parámetro '10' para decirle a xUnit que ignore 
            // diferencias minúsculas a partir del décimo decimal (normal por usar PI).
            Assert.Equal(esperado, actual, 10);
        }

        // ==========================================================
        // PRUEBA 2: PERÍMETRO DE LA ELIPSE
        // Fórmula (aproximada de tu código): PI * (a + b)
        // ==========================================================
        [Theory]
        // Caso 1: a=2, b=3 -> Perímetro = PI * (2+3) = PI * 5 ≈ 15.7079632...
        [InlineData(2, 3, 15.707963267948966)] 
        // Caso 2: a=4, b=1 -> Perímetro = PI * (4+1) = PI * 5 ≈ 15.7079632...
        [InlineData(4, 1, 15.707963267948966)] 
        // Caso 3: a=10, b=10 -> Perímetro = PI * (10+10) = PI * 20 ≈ 62.8318530...
        [InlineData(10, 10, 62.83185307179586)] 
        public void CalcularPerimetroElipse_SemiEjesValidos_ResultadoCorrecto(double semiEjeA, double semiEjeB, double esperado)
        {
            // Act: Llamamos al método estático Perimetro de TU clase Figura262E14
            double actual = Figura262E14.Perimetro(semiEjeA, semiEjeB);

            // Assert
            Assert.Equal(esperado, actual, 10);
        }
    }
}