using System;

namespace Calculadora
{
    public class FuncionesMetodos
    {
        public static void Saludar()
        {
            Console.WriteLine("Bienvenido a la calculadora");
        }

        public static double SumaF(double a, double b)
        {
            return a + b;
        }

        public static double RestaF(double a, double b)
        {
            return a - b;
        }

        public static double MultiplicacionF(double a, double b)
        {
            return a * b;
        }

        public static double DivisionF(double a, double b)
        {
            return a / b;
        }

        public static double ResiduoF(double a, double b)
        {
            return a % b;
        }
    }
}