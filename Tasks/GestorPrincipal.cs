using System;

namespace GestorPrincipal{
    internal class Task
    {
        static void Main()
        {
            FunctionTask.Menu();
            int search = FunctionForValidate.ReadIntegers("Ingrese el numero del ejercicio: ");

            CoreFunction.CoreDictionary(search);

            
        }

    }

}