using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuncionesMetodos.Saludar();

            Console.Write("Ingrese el primer número: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("La suma es: " +
                FuncionesMetodos.SumaF(a, b));

            Console.WriteLine("La resta es: " +
                FuncionesMetodos.RestaF(a, b));

            Console.WriteLine("La multiplicación es: " +
                FuncionesMetodos.MultiplicacionF(a, b));

            if (b != 0)
            {
                Console.WriteLine("La división es: " +
                    FuncionesMetodos.DivisionF(a, b));

                Console.WriteLine("El residuo es: " +
                    FuncionesMetodos.ResiduoF(a, b));
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }
        }
    }
}