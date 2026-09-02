using System;
using System.Xml.XPath;

namespace GestorPrincipal{
    internal class Task
    {
        static void Main()
        {
            FunctionTask.Menu();
            int search = FunctionForValidate.ReadIntegers("Ingrese el numero del ejercicio: ");
            int searchTask;
            switch (search){
                
                case 1:
                    CoreFunction.FilLevel(search);
                    searchTask = FunctionForValidate.ReadIntegers("Ingrese el numero del ejercicio: ");
                    CoreFunction.CoreDictionary(searchTask);
                    break;
                
                case 2:
                    CoreFunction.FilLevel(search);
                    searchTask = FunctionForValidate.ReadIntegers("Ingrese el numero del ejercicio: ");
                    CoreFunction.CoreDictionary(searchTask);
                    break;
                
                case 3:
                    CoreFunction.FilLevel(search);
                    searchTask = FunctionForValidate.ReadIntegers("Ingrese el numero del ejercicio: ");
                    CoreFunction.CoreDictionary(searchTask);
                    break;
                
                case 4:
                    CoreFunction.FilLevel(search);
                    searchTask = FunctionForValidate.ReadIntegers("Ingrese el numero del ejercicio: ");
                    CoreFunction.CoreDictionary(searchTask);
                    break;
                case 5:
                    CoreFunction.FilLevel(search);
                    searchTask = FunctionForValidate.ReadIntegers("Ingrese el numero del ejercicio: ");
                    CoreFunction.CoreDictionary(searchTask);
                    break;
                case 6:
                    CoreFunction.FilLevel(search);
                    searchTask = FunctionForValidate.ReadIntegers("Ingrese el numero del ejercicio: ");
                    CoreFunction.CoreDictionary(searchTask);
                    break;
            }
            

            
        }

    }

}