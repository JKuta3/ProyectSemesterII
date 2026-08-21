using System;
using Microsoft.VisualBasic;

namespace GestorPrincipal
{
    public class FunctionForValidate()
    {
        public static double ReadDouble(string message)
        {
            double newValue;
            Console.Write(message);

            while (!double.TryParse(Console.ReadLine() , out newValue))
            {
                Console.WriteLine("Error: Solo se aceptan numeros decimales ");
                Console.Write(message);
            }
            return newValue;
        }

        public static int ReadIntegers(string message)
        {
            int newValue;
            Console.Write(message);

            while (!int.TryParse(Console.ReadLine() , out newValue))
            {
                Console.WriteLine("Error: Solo se aceptan numeros enteros ");
                Console.Write(message);
            }
            return newValue;
        }
    }


}