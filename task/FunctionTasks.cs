using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using System.Timers;
using System.Xml.XPath;
using Microsoft.VisualBasic;
using System.Threading;

namespace GestorPrincipal
{
    public class CoreFunction()
    {   
        public static void CoreDictionary(int search)
        {
            var tasks = new Dictionary <int, Action> {
            { 1, FunctionTask.Task1},{2, FunctionTask.Task2},{3, FunctionTask.Task3},{4, FunctionTask.Task4},{5,FunctionTask.Task5},
            { 6, FunctionTask.Task6},{7, FunctionTask.Task7},{8, FunctionTask.Task8},{9,FunctionTask.Task9} ,{10,FunctionTask.Task10},
            {11,FunctionTask.Task11} ,{12,FunctionTask.Task12} ,{13,FunctionTask.Task13} ,{14,FunctionTask.Task14} ,{15,FunctionTask.Task15},
            {16,FunctionTask.Task16} ,{17,FunctionTask.Task17} ,{18,FunctionTask.Task18} ,{19,FunctionTask.Task19} ,{20,FunctionTask.Task20},
            {21,FunctionTask.Task21} ,{22,FunctionTask.Task22} ,{23,FunctionTask.Task23} ,{24,FunctionTask.Task24} ,{25,FunctionTask.Task25},
            {26,FunctionTask.Task26} ,{27,FunctionTask.Task27} ,{28,FunctionTask.Task28} ,{29,FunctionTask.Task29} ,{30,FunctionTask.Task30},
            {31,FunctionTask.Task31} ,{32,FunctionTask.Task32} ,{33,FunctionTask.Task33} ,{34,FunctionTask.Task34} ,{35,FunctionTask.Task35},
            {36,FunctionTask.Task36} ,{37,FunctionTask.Task37} ,{38,FunctionTask.Task38} ,{39,FunctionTask.Task39},{40,FunctionTask.Task40},
            {41, FunctionTask.Task41},{42, FunctionTask.Task42},{43, FunctionTask.Task43},{44, FunctionTask.Task44},{45, FunctionTask.Task45},
            {90 , FunctionTask.InClass0},{91 , FunctionTask.InClass1},{92 , FunctionTask.InClass2},{93 , FunctionTask.InClass3},
            {55,FunctionTask.Task55} ,{56,FunctionTask.Task56} ,{57,FunctionTask.Task57} ,{58,FunctionTask.Task58},{59,FunctionTask.Task59},
            {60, FunctionTask.Task61},{62, FunctionTask.Task62},{63, FunctionTask.Task63},{64, FunctionTask.Task64},{65, FunctionTask.Task65},
            {66,FunctionTask.Task66} ,{67,FunctionTask.Task67} ,{68,FunctionTask.Task68} ,{69,FunctionTask.Task39},{70,FunctionTask.Task70},
            {71, FunctionTask.Task71},{72, FunctionTask.Task72},{73, FunctionTask.Task73},{74, FunctionTask.Task74}, {75, FunctionTask.Task75},
            {76, FunctionTask.Task76}, {77, FunctionTask.Task77}
            };
            if (tasks.TryGetValue(search, out Action selectionTask))//No usar solo Contains
            {
                selectionTask();
            }
            else
            {
                Console.WriteLine("No se encontro la tarea que esta buscando");
            }
        
        }
        public static void FilLevel(int search)
        {
            var level = new Dictionary<int, Action>
            {
                {1 , FunctionTask.MenuL1},
                {2 , FunctionTask.MenuL2},
                {3 , FunctionTask.MenuL3},
                {4 , FunctionTask.MenuL4},
                {5 , FunctionTask.MenuL5},
                {6 , FunctionTask.MenuL6},
                {7 , FunctionTask.MenuL7}
            };
            if (level.TryGetValue(search, out Action selectionMenu))
            {
                selectionMenu();
            }
            else
            {
                Console.WriteLine("No se encontro la tarea que esta buscando");
            }
        }
        
    }
    public class FunctionTask
    {
        //Menu principal 
        public static void Menu()
        {
            Console.WriteLine("===== BIENVENIDO A MI TAREA =====");
            Console.WriteLine(">> Nivel 1: Variables, Constantes y Operaciones Básicas (1 - 10)");
            Console.WriteLine(">> Nivel 2: Condicionales Simples (if / else) (11 - 20)");
            Console.WriteLine(">> Nivel 3: Condicionales Múltiples (if / else if / else) (21 - 30)");
            Console.WriteLine(">> Nivel 4: Modularización, Funciones y Tuplas (31 - 40)");
            Console.WriteLine(">> Nivel 5: Ciclos y Loops (41 - 45)");
            Console.WriteLine(">> Nivel 7: Loops: for, while y do while (55-74)");
            Console.WriteLine(">> Nivel 6: Ver ejercicios de clases (90 - 94)");
            Console.Write(">> Seleccione el ejercicio que quiere ver: ");
            
        }

        //Menu level 1
        public static void MenuL1()
        {
            Console.WriteLine("=== NIVEL 1: Variables, Constantes y Operaciones Básicas ===");
            Console.WriteLine("Ejercicio 01: Mostrar en consola el mensaje \"Bienvenido a Programación II\" junto con tu nombre almacenado en una variable.");
            Console.WriteLine("Ejercicio 02: Declarar una constante `PI = 3.14159` y calcular el área de un círculo pidiendo el radio al usuario.");
            Console.WriteLine("Ejercicio 03: Pedir al usuario su año de nacimiento y calcular su edad aproximada restándolo del año actual.");
            Console.WriteLine("Ejercicio 04: Crear un programa que solicite un precio de producto y le aplique el IVA (13%) usando una constante.");
            Console.WriteLine("Ejercicio 05: Solicitar dos números decimales (`double`) y mostrar la suma, resta, multiplicación y división.");
            Console.WriteLine("Ejercicio 06: Pedir al usuario 3 notas de exámenes y calcular el promedio final");
            Console.WriteLine("Ejercicio 07: Intercambiar los valores de dos variables. (Ejemplo: si `a = 5` y `b = 10`, al final `a` debe valer 10 y `b` valer 5).");
            Console.WriteLine("Ejercicio 08: Convertir una temperatura dada en grados Celsius a Fahrenheit usando la fórmula: `(C * 9/5) + 32`.");
            Console.WriteLine("Ejercicio 09: Pedir una cantidad de minutos al usuario y calcular a cuántas horas y minutos equivalen");
            Console.WriteLine("Ejercicio 10: Calcular el residuo (módulo `%`) de dividir dos números ingresados por el usuario.");
            Console.Write(">> Seleccione el ejercicio que quiere ver: ");
        }

        public static void MenuL2()
        {
            Console.WriteLine("=== Nivel 2: Condicionales Simples (if / else) (11 - 20) ===");
            Console.WriteLine("Ejercicio 11: Solicitar la edad del usuario e indicar si es mayor de edad (18 años o más) o menor de edad.");
            Console.WriteLine("Ejercicio 12: Pedir un número entero y determinar si es **par** o **impar** usando el operador `%`.");
            Console.WriteLine("Ejercicio 13: Solicitar dos números e imprimir cuál de los dos es el mayor.");
            Console.WriteLine("Ejercicio 14: Pedir un número e indicar si es positivo o negativo.");
            Console.WriteLine("Ejercicio 15: Verificar si la nota final de un estudiante (1 al 100) es suficiente para aprobar (mínimo 51)");
            Console.WriteLine("Ejercicio 16: Pedir una clave/contraseña. Si coincide con la constante `CLAVE_CORRECTA = \"1234\"`, mostrar \"Acceso permitido\", de lo contrario \"Acceso denegado\".");
            Console.WriteLine("Ejercicio 17: Pedir un año e indicar si es un año bisiesto o no (un año es bisiesto si es divisible entre 4).");
            Console.WriteLine("Ejercicio 18: Pedir el monto de una compra. Si supera los 100$, aplicar un descuento del 10%, de lo contrario mostrar el precio original.");
            Console.WriteLine("Ejercicio 19: Solicitar dos números enteros. Verificar si el primero es divisible exactamente entre el segundo.");
            Console.WriteLine("Ejercicio 20: Crear un programa que pida las horas trabajadas en la semana. Si superan las 40 horas, mostrar \"Tiene horas extra\", sino \"Jornada normal\".");
            Console.Write(">> Seleccione el ejercicio que quiere ver: ");
        }
        public static void MenuL3()
        {
            Console.WriteLine("=== Nivel 3: Condicionales Múltiples (if / else if / else) (21 - 30) ===");
            Console.WriteLine("Ejercicio 21: Pedir un número entero e indicar si es **positivo**, **negativo** o **cero**.");
            Console.WriteLine("Ejercicio 22: Solicitar 3 números distintos e imprimir cuál de los tres es el mayor de todos.");
            Console.WriteLine("Ejercicio 23: Convertir una nota numérica (0-100) a letra: 90-100: 'A', 80-89: 'B', 70-79: 'C', 60-69: 'D', Menor a 60: 'F'.");
            Console.WriteLine("Ejercicio 24: Pedir la edad de una persona e indicar su etapa de vida: Niño (0-12), Adolescente (13-17), Adulto (18-64), Adulto mayor (65+).");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

public static void MenuL4()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void MenuL5()
        {
            Console.WriteLine("Ejercicio 41 Loop: Tabla de multiplicar Pide un número al usuario y muestra su tabla de multiplicar del 1 al 12 usando un ciclo for. El formato de cada línea debe ser 7 x 3 = 21.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void MenuL6()
        {
            Console.WriteLine("Ejercicio 90: Validacion con Parse y switch");
            Console.WriteLine("Ejercicio 91: Loop con While <= 5");
            Console.WriteLine("Ejercicio 92: do-while ");
            Console.WriteLine("Ejercicio 93: do-while para validad edades");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void MenuL7()
        {
            Console.WriteLine("=== Nivel 5: Ciclos y Loops (41 - 45) ===");
            Console.WriteLine("Ejercicio 55: Registro secuencial de sensores de suelo");
            Console.WriteLine("Ejercicio 56: Acumulador de segundos de espera promedio");
            Console.WriteLine("Ejercicio 57: Validacion del dato de litros de agua ahorrados en la semana");
            Console.WriteLine("Ejercicio 58: Menu de consultas de la Agencia de Gobierno Electronico y TIC (AGETIC)");
            Console.WriteLine("Ejercicio 59: Conteo de documentos coloniales que cumplen el umbral");
            Console.WriteLine("Ejercicio 60: Agotamiento de la reserva de objetos");
            Console.WriteLine("Ejercicio 61: Semaforo de clasificacion de registros de la epoca");
            Console.WriteLine("Ejercicio 62: Turnos pares e impares en el control de tramos de via");
            Console.WriteLine("Ejercicio 63: Maximo y minimo de articulos analizados en el estudio");
            Console.WriteLine("Ejercicio 64: Promedio de dolares vendidos en la jornada frente a la meta");
            Console.WriteLine("Ejercicio 65: Sistema de gestion con submenu de la Autoridad de Fiscalizacion de Bosques y Tierra (ABT)");
            Console.WriteLine("Ejercicio 66: Clasificacion con verificacion en dos niveles");
            Console.WriteLine("Ejercicio 67: Cuantos periodos faltan para llegar a la meta");
            Console.WriteLine("Ejercicio 68: Matriz de reporte por zonas y dias");
            Console.WriteLine("Ejercicio 69: Acceso al sistema con 3 intentos");
            Console.WriteLine("Ejercicio 70: Calculo por tramos del aporte de cada esquina");
            Console.WriteLine("Ejercicio 71: Carga abierta de datos con valor centinela");
            Console.WriteLine("Ejercicio 72: Linea de tiempo desde 2019");
            Console.WriteLine("Ejercicio 73: Simulador de campana de el Ministerio de Salud y Deportes");
            Console.WriteLine("Ejercicio 74: Proyecto integrador: sistema completo de la Autoridad de Fiscalizacion de Bosques y Tierra (ABT)");

        }
        //Task 1
        public static void Task1()
        {
            Console.WriteLine("Ejercicio 01: Mostrar en consola el mensaje \"Bienvenido a Programación II\" junto con tu nombre almacenado en una variable.");
            string myname = "Jhon Kevin Reyes Marca";
            Console.WriteLine($"Bienvenido a Programación II {myname}");

        }

        //Task 2
        public static void Task2()
        {
            Console.WriteLine("Ejercicio 02: Declarar una constante `PI = 3.14159` y calcular el área de un círculo pidiendo el radio al usuario.");
            double radio;
            Console.Write("Ingresa el radio de la circunferencia: ");
            if (double.TryParse(Console.ReadLine(), out radio))
            {
                Console.WriteLine("Cargando...");
            }
            else
            {
                Console.WriteLine("Error: Tiene que ingrsar un valor numerico");
            }
            const double PI = 3.14159;//Podemos usar Math.PI pero el ejercicio pide declarar un constante 
            double area = PI * (radio * radio);
            Console.Write($"El resultado del área de un círculo de radio {radio}: {area} ");
        }

        //Task3
        public static void Task3()
        {
            Console.WriteLine("Ejercicio 03: Pedir al usuario su año de nacimiento y calcular su edad aproximada restándolo del año actual.");
            int year;
            Console.Write("Ingrese su año de nacimiento: ");
            if (int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("Cargando...");
            }
            int youryears = DateTime.Now.Year - year ; 
            Console.WriteLine($"Tu edad es de {youryears} ya que el año actual es {DateTime.Now.Year}");
        }

        //Task4
        public static void Task4()
        {
            Console.WriteLine("Ejercicio 04: Crear un programa que solicite un precio de producto y le aplique el IVA (13%) usando una constante.");
            const double IVA = 0.13;
            int precio;
            Console.Write("Ingrese su año de nacimiento: ");
            if (int.TryParse(Console.ReadLine(), out precio))
            {
                Console.WriteLine("Cargando...");
            }
            double result = precio * IVA ; 
            Console.WriteLine($"El IVA bruto es de {result}");
        }

        //Task5
        public static void Task5()
        {
            Console.WriteLine("Ejercicio 05: Solicitar dos números decimales (`double`) y mostrar la suma, resta, multiplicación y división.");
            double number1 = FunctionForValidate.ReadDouble("Ingresa el primer numero: ");
            double number2 = FunctionForValidate.ReadDouble("Ingresa el segundo numero: ");

            if (number1 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre 0");
            }
            else
            {
                Console.WriteLine($"Suma = {number1 + number2}");
                Console.WriteLine($"Resta = {number1 - number2}");
                Console.WriteLine($"Multiplicacion= {number1 * number2}");
                Console.WriteLine($"Division = {number1 / number2}");
            }
        
        }

        //Task6
        public static void Task6()
        {
            Console.WriteLine("Ejercicio 06: Pedir al usuario 3 notas de exámenes y calcular el promedio final.");
            double number1 = FunctionForValidate.ReadDouble("Ingresa el primer notas: ");
            double number2 = FunctionForValidate.ReadDouble("Ingresa el segundo notas: ");
            double number3 = FunctionForValidate.ReadDouble("Ingresa el tercer notas: ");
            
            double promedio =(number1 + number2 + number3) / 3 ;
            Console.WriteLine($"El promedio es de = {promedio}");
        }

        //Task7
        
        public static void Task7()
        {
            Console.WriteLine("Ejercicio 07: Intercambiar los valores de dos variables. (Ejemplo: si `a = 5` y `b = 10`, al final `a` debe valer 10 y `b` valer 5).");
            int a = 5;
            int b = 10;
            Console.WriteLine($"{a}: {b}");
            int c = a;

            a = b;
            b = c;

            Console.WriteLine($"{a}: {b}");
        }

        //Task8

        public static void Task8()
        {
            Console.WriteLine("Ejercicio 08: Convertir una temperatura dada en grados Celsius a Fahrenheit usando la fórmula: `(C * 9/5) + 32`.");
            double firstTemperature = FunctionForValidate.ReadDouble("Ingrese la Temperatura: ");
            Console.WriteLine($"La temperatura de {firstTemperature}°C en Fahrenheits es {(firstTemperature*9/5)+32}°F");
        }

        //Task9

        public static void Task9()
        {
            Console.WriteLine("Ejercicio 09: Pedir una cantidad de minutos al usuario y calcular a cuántas horas y minutos equivalen");
            double number1 = FunctionForValidate.ReadDouble("Ingresa el primer notas: ");
            double result = number1* 60;
            if (!(result % 1 == 0) )
            {
                double minute = (result % 1)*60;
                double newhora = result - (result %1);
                Console.WriteLine($"Resultado: {newhora} hora y {minute} minutos "); 
            }
            else
            {
                Console.WriteLine($"Resultado = {number1}");
            }
            
        }
    
        //Task10

        public static void Task10()
        {
            Console.WriteLine("Ejercicio 10: Calcular el residuo (módulo `%`) de dividir dos números ingresados por el usuario.");
            double number1 = FunctionForValidate.ReadDouble("Ingresa el primer notas: ");
            double number2 = FunctionForValidate.ReadDouble("Ingresa el segundo notas: ");
            Console.WriteLine($"El reciduo es de {number1 % number2}");
        }
    
        //Task11

        public static void Task11()
        {
            Console.WriteLine("Ejercicio 11: Solicitar la edad del usuario e indicar si es mayor de edad (18 años o más) o menor de edad.");
            int years = FunctionForValidate.ReadIntegers("Ingresa su edad: ");
            if ( years <= 17  && years >= 1 )
            {
                Console.WriteLine("Eres menor de edad");
            }
            else if (years > 17 && years < 117 )
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Error: No se aceptan numeros negativos ni 0 ");
            }
        }

        //Task12
        public static void Task12()
        {
            Console.WriteLine("Ejercicio 12: Pedir un número entero y determinar si es **par** o **impar** usando el operador `%`.");
            int number = FunctionForValidate.ReadIntegers("Ingresa el numero: ");

            if (number % 2 == 0)
            {
                Console.WriteLine($"El numero: {number} es par");
            }
            else
            {
                Console.WriteLine($"El numero: {number} es impar");
            }
        }
        //Task13
        public static void Task13()
        {
            Console.WriteLine("Ejercicio 13: Solicitar dos números e imprimir cuál de los dos es el mayor.");
            int firstNumber = FunctionForValidate.ReadIntegers("Ingresa el numero: ");
            int secondNumber = FunctionForValidate.ReadIntegers("Ingresa el numero: ");
            if (firstNumber == secondNumber )
            {
                Console.WriteLine($"Son del mismo valor {firstNumber} = {secondNumber}");
            }else if (firstNumber > secondNumber)
            {
                Console.WriteLine($"El numero mayor es: {firstNumber}");
            }
            else
            {
                Console.WriteLine($"El numero mayor es: {secondNumber}");
            }
        }
        //Task14
        public static void Task14()
        {
            Console.WriteLine("Ejercicio 14: Pedir un número e indicar si es positivo o negativo.");
            int number = FunctionForValidate.ReadIntegers("Ingresa el numero: ");
            if (number == 0 )
            {
                Console.WriteLine("El numero es 0 un numero neutro");
            }else if (number > 0)
            {
                Console.WriteLine($"El numero es positivo");
            }
            else
            {
                Console.WriteLine($"El numero es negativo");
            }
        }
        
        //Task15
        public static void Task15()
        {
            Console.WriteLine("Ejercicio 15: Verificar si la nota final de un estudiante (1 al 100) es suficiente para aprobar (mínimo 51).");
            int number = FunctionForValidate.ReadIntegers("Ingresa el numero: ");
            if (number == 0 )
            {
                Console.WriteLine("El numero es 0");
            }else if (number > 0 && number <51)
            {
                Console.WriteLine($"Reprobo");
            }
            else if (number >=51 && number <= 100)
            {
                Console.WriteLine($"Aprobo");
            }
            else
            {
                Console.WriteLine("Solo se aceptan numeros del rango de 1 al 100");
            }
        }
        //Task16
        public static void Task16()
        {
            Console.WriteLine("Ejercicio 16: Pedir una clave/contraseña. Si coincide con la constante `CLAVE_CORRECTA = \"1234\"`, mostrar \"Acceso permitido\", de lo contrario \"Acceso denegado\".");
            Console.Write("Ingresa tu contraseña: ");
            string password = Console.ReadLine();
            const string claveCorrecta = "1234";
            if ( password == claveCorrecta )
            {
                Console.WriteLine("Acceso permitido");
            }else 
            {
                Console.WriteLine($"Acceso Denegado");
            }
        }
        //Task17
        public static void Task17()
        {
            Console.WriteLine("Ejercicio 17: Pedir un año e indicar si es un año bisiesto o no (un año es bisiesto si es divisible entre 4).");
            int year = FunctionForValidate.ReadIntegers("Ingresa el año: ");
            if (year == 0)
            {
                Console.WriteLine("No se acpeta el 0");

            }else if ( year % 4 == 0 || year % 400 == 0 )
            {
                Console.WriteLine("Es un año bisiesto");

            }
            else
            {
                Console.WriteLine("No se aceptan números negativos");
            }
        }
        //Task18
        public static void Task18()
        {
            Console.WriteLine("Ejercicio 18: Pedir el monto de una compra. Si supera los 100$, aplicar un descuento del 10%, de lo contrario mostrar el precio original.");
            double priceBuy = FunctionForValidate.ReadDouble("Ingresa el monto de compra: ");
            if (priceBuy < 0)
            {
                Console.WriteLine("No se acpeta negativos");

            }else if ( priceBuy >= 100 )
            {
                Console.WriteLine($"Descuento del 10% {priceBuy * 0.10} $");

            }
            else if(priceBuy < 100 || priceBuy>0)
            {
                Console.WriteLine($"Precio original: {priceBuy} $");
            }
        }
        //Task19
        public static void Task19()
        {
            Console.WriteLine("Ejercicio 19: Solicitar dos números enteros. Verificar si el primero es divisible exactamente entre el segundo.");
            int firstNumber = FunctionForValidate.ReadIntegers("Ingresa el numero: ");
            int secondNumber = FunctionForValidate.ReadIntegers("Ingresa el numero: ");

            if (firstNumber % secondNumber == 0)
            {
                Console.WriteLine($"Si son divisibles");
            }
            else
            {
                Console.WriteLine($"No son divisiblesr");
            }
        }
        //Task20
        public static void Task20()
        {
            Console.WriteLine("Ejercicio 20: Crear un programa que pida las horas trabajadas en la semana. Si superan las 40 horas, mostrar \"Tiene horas extra\", sino \"Jornada normal\".");
            int timeOfWork = FunctionForValidate.ReadIntegers("Ingresa el numero de horas trabajadas: ");

            if (timeOfWork == 0)
            {
                Console.WriteLine($"No se acepta 0");
            }
            else if (timeOfWork > 40 && timeOfWork < 80)
            {
                Console.WriteLine($"Tienes horas extras");
            }
            else if (timeOfWork <= 40 && timeOfWork>=30)
            {
                Console.WriteLine("Jornada normal");
            }
            else
            {
                Console.WriteLine("No se aceptan numeros negativos");
            }
        }
        //Tasl21
        public static void Task21()
        {
            Console.WriteLine("Ejercicio 21: Pedir un número entero e indicar si es **positivo**, **negativo** o **cero**.");
            int number = FunctionForValidate.ReadIntegers("Ingresa el numero: ");
            if(number < 0 )
            {
                Console.WriteLine("negativo");
            }else if (number > 0 )
            {
                Console.WriteLine("positivo");
            }
            else
            {
                Console.WriteLine("cero");
            }


        }
        //Task22
        public static void Task22()
        {
            Console.WriteLine("Ejercicio 22: Solicitar 3 números distintos e imprimir cuál de los tres es el mayor de todos.");
            int number1 = FunctionForValidate.ReadIntegers("Ingresa el numero 1: ");
            int number2 = FunctionForValidate.ReadIntegers("Ingresa el numero 2: ");
            int number3 = FunctionForValidate.ReadIntegers("Ingresa el numero 3: ");

            while (number1 == number2 || number1 == number3 || number2 == number3 )
            {
                Console.WriteLine("SIguen suendo iguales ");
                number1 = FunctionForValidate.ReadIntegers("Ingresa el numero 1: ");
                number2 = FunctionForValidate.ReadIntegers("Ingresa el numero 2: ");
                number3 = FunctionForValidate.ReadIntegers("Ingresa el numero 3: ");
            }
            int mayor = Math.Max(number1, Math.Max(number2, number3));
            Console.WriteLine($"\nEl número mayor de los tres es: {mayor}");
        }
        //Task23
        public static void Task23()
        {
            Console.WriteLine("Ejercicio 23: Convertir una nota numérica (0-100) a letra: 90-100: 'A', 80-89: 'B', 70-79: 'C', 60-69: 'D', Menor a 60: 'F'.");
            int number = FunctionForValidate.ReadIntegers("Ingresa el numero: ");
            if(number < 0 )
            {
                Console.WriteLine("Error el numero es negativo");
            }else if (number > 0 && number < 60 )
            {
                Console.WriteLine("F");
            }
            else if (number >= 60 && number <= 69)
            {
                Console.WriteLine("D");
            }
            else if (number >= 70 && number <= 79)
            {
                Console.WriteLine("C");
            }
            else if (number >= 80 && number <= 89)
            {
                Console.WriteLine("B");
            }
            else if (number >= 90 && number <= 100)
            {
                Console.WriteLine("A");
            }
        }
        //Task24
        public static void Task24()
        {
            Console.WriteLine("Ejercicio 24: Pedir la edad de una persona e indicar su etapa de vida: Niño (0-12), Adolescente (13-17), Adulto (18-64), Adulto mayor (65+).");
            int years = FunctionForValidate.ReadIntegers("Ingresa su edad: ");
            if ( years <= 12  && years >= 0 )
            {
                Console.WriteLine("Eres niño");
            }
            else if (years >= 17 && years <=13 )
            {
                Console.WriteLine("Eres adolecente");
            }
            else if (years >= 18 && years <=64 )
            {
                Console.WriteLine("Eres adulto");
            }else if (years > 64 && years < 114)
            {
                Console.WriteLine("Eres adulto mayor");
            }
            else
            {
                Console.WriteLine("Error: No se aceptan numeros negativos ni 0 ");
            }
        }
        
        //Task25
        public static void Task25()
        {
            Console.WriteLine("Ejercicio 25: Crear una calculadora que pida dos números y luego un número del 1 al 4 para elegir la operación (1:Suma, 2:Resta, 3:Multiplicación, 4:División).");
            double a = FunctionForValidate.ReadDouble("Ingresa el primer número: ");
            double b = FunctionForValidate.ReadDouble("Ingresa el segundo número: ");;
            Console.WriteLine("1: Suma");
            Console.WriteLine("2: Resta");
            Console.WriteLine("3: Multiplicación");
            Console.WriteLine("4: División");
            int option = FunctionForValidate.ReadIntegers("Ingrese una opción: ");
            double result;
            if (option == 1)
            {
                result = Operate.sum(a,b);
                Console.WriteLine(result);
            }
            else if (option == 2)
            {
                result = Operate.rest(a,b);
                Console.WriteLine(result);
            }
            else if (option == 3)
            {
                result = Operate.mult(a,b);
                Console.WriteLine(result);
            }
            else if (option == 4)
            {
                result = Operate.div(a,b);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error: Opción no válida.");
            }
        }
        //Task26
        public static void Task26()
        {
            Console.WriteLine("Ejercicio 26: Pedir un número del 1 al 7 y mostrar el día de la semana correspondiente (1 = Lunes, ..., 7 = Domingo). Si pone otro número, mostrar error.");
            var days = new Dictionary <int,string>
            {
                {1, "Lunes"},{2, "Martes"},
                {3, "Miercoles"},{4,"Jueves"},
                {5,"Viernes"},{6,"Sabado"},{7,"Domingo"}
            };
            Console.WriteLine("1, Lunes");
            Console.WriteLine("2. Martes");
            Console.WriteLine("3. Miercoles");
            Console.WriteLine("4. Jueves");
            Console.WriteLine("5. Viernes");
            Console.WriteLine("6. Sabado");
            Console.WriteLine("7. Domingo");

            int option = FunctionForValidate.ReadIntegers("Ingresa el numero del dia: ");
            if (option == 1)
            {
                Console.WriteLine($"El día es: {days[1]}");
            }
            else if (option == 2)
            {
                Console.WriteLine($"El día es: {days[2]}");
            }
            else if (option == 3)
            {
                Console.WriteLine($"El día es: {days[3]}");
            }
            else if (option == 4)
            {
                Console.WriteLine($"El día es: {days[4]}");
            }
            else if (option == 5)
            {
                Console.WriteLine($"El día es: {days[5]}");
            }
            else if (option == 6)
            {
                Console.WriteLine($"El día es: {days[6]}");
            }
            else if (option == 7)
            {
                Console.WriteLine($"El día es: {days[7]}");
            }
            else
            {
                Console.WriteLine("Error: Debe ingresar un número del 1 al 7.");
            }
        }
        //Task27
        public static void Task27()
        {
            Console.WriteLine("Ejercicio 27: Calcular el Índice de Masa Corporal (IMC) `peso / (estatura * estatura)` y categorizarlo: Bajo peso (< 18.5), Normal (18.5 - 24.9), Sobrepeso (25 - 29.9), Obesidad (30+).");
            double peso = FunctionForValidate.ReadDouble("Ingresa su peso: ");
            double estatura = FunctionForValidate.ReadDouble("Ingresa su estatura: ");;
            double imc = peso / (estatura * estatura);
            if ( imc < 128.5 )
            {
                Console.WriteLine("Bajo peso");
            }
            else if (imc >= 18.5 && imc < 24.9 )
            {
                Console.WriteLine("Normal");
            }
            else if (imc >= 25 && imc <= 29.9 )
            {
                Console.WriteLine("Sobrepeso");
            }else if (imc >= 30 )
            {
                Console.WriteLine("Obesidad");
            }
            else
            {
                Console.WriteLine("Error: No se aceptan numeros negativos ni 0 ");
            }
        }
        //Task28
        public static void Task28()
        {
            Console.WriteLine("Ejercicio 28: Crear un sistema de peaje que cobre según el vehículo: Moto (2$), Auto (5$), Autobús (10$), Camión (15$).");
            
            Console.WriteLine("1. Moto");
            Console.WriteLine("2. Auto");
            Console.WriteLine("3. Autobús");
            Console.WriteLine("4. Camión");
            int vehiculo = FunctionForValidate.ReadIntegers("Ingrese el tipo de vehículo: ");

            if (vehiculo == 1)
            {
                Console.WriteLine("Moto: $2");
            }
            else if (vehiculo == 2)
            {
                Console.WriteLine("Auto: $5");
            }
            else if (vehiculo == 3)
            {
                Console.WriteLine("Autobús: $10");
            }
            else if (vehiculo == 4)
            {
                Console.WriteLine("Camión: $15");
            }
            else
            {
                Console.WriteLine("Error: Vehículo no válido.");
            }
        }
        
        //Task29
        public static void Task29()
        {
            Console.WriteLine("Ejercicio 29: Pedir los 3 lados de un triángulo y determinar si es **Equilátero** (3 lados iguales), **Isósceles** (2 iguales) o **Escaleno** (3 diferentes).");
            double lado1 = FunctionForValidate.ReadDouble("Ingrese el lado 1: ");
            double lado2 = FunctionForValidate.ReadDouble("Ingrese el lado 2: ");
            double lado3 = FunctionForValidate.ReadDouble("Ingrese el lado 3: ");

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es Equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es Isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es Escaleno.");
            }
        }

        //Task30
        public static void Task30()
        {
            Console.WriteLine("Ejercicio 30: Simular el estado de un semáforo: si ingresa \"rojo\" $\rightarrow$ \"Detenerse\", \"amarillo\" $\rightarrow$ \"Precaución\", \"verde\" $\rightarrow$ \"Avanzar\".");
            string color = Console.ReadLine()!.ToLower();

            if (color == "rojo")
            {
                Console.WriteLine("Detenerse");
            }
            else if (color == "amarillo")
            {
                Console.WriteLine("Precaución");
            }
            else if (color == "verde")
            {
                Console.WriteLine("Avanzar");
            }
            else
            {
                Console.WriteLine("Error: Color no válido.");
            }
        }
        //Task31
        public static void Task31()
        {
            Console.WriteLine("Ejercicio 31: Método void Crear una función `Saludar(string nombre)` que imprima \"Hola [nombre], bienvenido a C#\".");
            string name = Console.ReadLine();
            Saludar(name);
        }

        public static void Saludar(string name)
        {
            Console.WriteLine($"Hola {name}");
        }
        //Task32
        public static void Task32()
        {
            Console.WriteLine("Ejercicio 32: Función Crear una función `EsPar(int numero)` que retorne `true` si el número es par o `false` si es impar.");
            int number = FunctionForValidate.ReadIntegers("Ingrese el numero: ");
            Boolean result = EsPar(number);
            Console.WriteLine($"{result}");
        }

        public static Boolean EsPar(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Task33
        public static void Task33()
        {
            Console.WriteLine("Ejercicio 33: Función Crear una función `CalcularMayor(double n1, double n2)` que retorne el número más alto.");
            double number1 = FunctionForValidate.ReadDouble("Ingresa el primer numero: ");
            double number2 = FunctionForValidate.ReadDouble("Ingresa el segundo numero: ");
            double result = CalcularMayor(number1, number2);
            Console.WriteLine($"El numero mayor es: {result}");
        }

        public static double CalcularMayor(double number1, double number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else 
            {
                return number2;
            }
        }
        //Task34
        public static void Task34()
        {
            Console.WriteLine("Ejercicio 34: Validación Crear una función para dividir dos números que valide mediante un `if` que el divisor no sea 0 antes de operar.");
            double number1 = FunctionForValidate.ReadDouble("Ingresa el primer numero: ");
            double number2 = FunctionForValidate.ReadDouble("Ingresa el segundo numero: ");
            
        }

        //Task35
        public static void Task35()
        {
            Console.WriteLine("Ejercicio 35: Tuplas Crear una función `PedirCoordenadas()` que solicite las posiciones `X` e `Y` en consola y las retorne usando una tupla `(double x, double y)`.");
            
        }
        //Task36
        public static void Task36()
        {
            Console.WriteLine("Ejercicio 36: Tuplas Crear una función `ObtenerDatosUsuario()` que pida Nombre, Edad y Cargo, y los retorne usando una tupla `(string, int, string)`.");
            
        }
        //Task37
        public static void Task37()
        {
            Console.WriteLine("Ejercicio 37: Clases Mover todas las funciones de operaciones matemáticas a una nueva clase llamada `Calculadora` e invocarlas desde el `Main` de `Program.cs`.");
            
        }
        //Task38
        public static void Task38()
        {
            Console.WriteLine("Ejercicio 38: TryParse Crear un método que pida un número por consola y use `double.TryParse` para asegurar que el usuario no escriba letras.");
            
        }
        //Task39
        public static void Task39()
        {
            Console.WriteLine("Ejercicio 39: Integración Crear un programa que solicite un salario bruto y cree un método que retorne una tupla con: `(SalarioBruto, DescuentoSeguro, SalarioNeto)`.");
            
        }
        //Task40
        public static void Task40()
        {
            Console.WriteLine("Ejercicio 40: Proyecto Corto Crear un menú completo interactivo en consola con un método `MostrarMenu()`, que permita elegir entre calcular área de triángulo, evaluar si un número es par o determinar el mayor de 3 números.");
            
        }

        //Task loop

        //Task 1-loop
        public static void Task41()
        {
            Console.WriteLine("Ejercicio 1 Loop: Tabla de multiplicar Pide un número al usuario y muestra su tabla de multiplicar del 1 al 12 usando un ciclo for. El formato de cada línea debe ser 7 x 3 = 21.");
            int numbermult = FunctionForValidate.ReadIntegers("Ingrese su numero: ");
            for (int i = 1; i<=12 ; i++)
            {
                Console.WriteLine($"{numbermult} x {i} = {numbermult * i}");
            }
        }

        //Task 2-Loop
        public static void Task42()
        {
            Console.WriteLine("Ejercicio 2 Loop: Contador y acumulador Con un while, pide números al usuario hasta que ingrese un cero. Al terminar, muestra cuántos números ingresó, la suma total y el promedio.");
            while (true)
            {
                int number = FunctionForValidate.ReadIntegers("Ingrese el numero: ");
                
            }
        }
        //Task 3-Loop
        public static void Task43()
        {
            Console.WriteLine("Ejercicio 2 Loop: Contador y acumulador Con un while, pide números al usuario hasta que ingrese un cero. Al terminar, muestra cuántos números ingresó, la suma total y el promedio.");
            while (true)
            {
                int number = FunctionForValidate.ReadIntegers("Ingrese el numero: ");
                
            }
        }
        //Task 4-Loop
        public static void Task44()
        {
            Console.WriteLine("Ejercicio 2 Loop: Contador y acumulador Con un while, pide números al usuario hasta que ingrese un cero. Al terminar, muestra cuántos números ingresó, la suma total y el promedio.");
            while (true)
            {
                int number = FunctionForValidate.ReadIntegers("Ingrese el numero: ");
                
            }
        }
        //Task 5-Loop
        public static void Task45()
        {
            Console.WriteLine("Ejercicio 2 Loop: Contador y acumulador Con un while, pide números al usuario hasta que ingrese un cero. Al terminar, muestra cuántos números ingresó, la suma total y el promedio.");
            while (true)
            {
                int number = FunctionForValidate.ReadIntegers("Ingrese el numero: ");
                
            }
        }

        //In class loop
        public static void InClass0()
        {
            Console.WriteLine("Ingrese un numero del 1 al 7:");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Fin de semana");
                    break;

                default:
                    Console.WriteLine("Numero invalido");
                    break;
            }
        }

        //In class loop
        public static void InClass1()
        {
            int contador = 1;
            while (contador <= 5)          
            {
                Console.WriteLine("Vuelta numero " + contador);
                contador++;                  
            }

            Console.WriteLine("El ciclo termino.");
        }

        //In class loop
        public static void InClass2()
        {
            int opcion;
            do
            {
                Console.WriteLine("1. Jugar");
                Console.WriteLine("2. Salir");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
            }
            while (opcion != 2);
        }

        //In class loop
        public static void InClass3()
        {
            int edad;
            do
            {
                Console.Write("Ingrese su edad (1 a 120): ");
                edad = int.Parse(Console.ReadLine());

                if (edad < 1 || edad > 120)
                {
                    Console.WriteLine("Edad invalida. Intente de nuevo.");
                }
            }
            while (edad < 1 || edad > 120);

            Console.WriteLine("Edad registrada: " + edad);
        }
        /// <summary>
        /// /=====================
        /// =====================
        /// ====================
        /// =====================
        /// /=====================
        /// </summary>
        public static void task46()
        {
            Console.WriteLine("""
            Las filas de camiones y minibuses en los surtidores se volvieron parte del paisaje urbano. La ANH necesita saber, dia por dia, cuanto combustible logro despachar cada surtidor para decidir donde enviar las cisternas primero.

            La Agencia Nacional de Hidrocarburos (ANH) necesita un programa que registre de forma automatica 4 surtidores de El Alto. El programa debe numerarlos uno por uno, desde el 1 hasta el 4, mostrando en pantalla una linea por cada surtidor registrado y, al terminar, un mensaje con el total procesado.

            Requisitos obligatorios
            Usar un ciclo while con sus tres partes: inicializacion, condicion y actualizacion.
            La cantidad total debe estar declarada como const int.
            Mostrar el numero de cada surtidor dentro del ciclo.
            Mostrar el total registrado despues de que el ciclo termina.

            """);
            const int NUMERO_SURTIDORES = 4;

            int contador = 1;

            while (contador <= NUMERO_SURTIDORES)
            {
                Console.WriteLine($"Surtidor {contador} registrado");
                contador++;
            }
        }

        public static void task47()
        {
            Console.WriteLine("""
            El Chaco boliviano atraviesa temporadas cada vez mas secas. Las estaciones meteorologicas comunales reportan la lluvia acumulada para declarar o levantar la emergencia.

            Escriba un programa que pida al operador de la Gobernacion de Tarija el dato de milimetros de lluvia registrados para cada uno de los 6 comunidades chaquenas de Yacuiba, vaya sumando esos valores y muestre el total acumulado. Al final el programa debe indicar si el total alcanzo la meta de 600 milimetros.

            Requisitos obligatorios
            Usar un ciclo while para pedir los 6 valores.
            Acumular en una variable suma (la suma parte de cero).
            La meta debe ser una constante.
            Al terminar el ciclo, comparar con if / else el total contra la meta.

            """);

            const int META = 600 ;
            int contador = 1;
            int total = 0;

            while (contador <= 6)
            {
                Console.Write($"Ingrese los datos de la comunidad {contador}: ");
                int dato_milimetrico = int.Parse(Console.ReadLine());
                total += dato_milimetrico;
                contador++;
            }
            if (total >= META)
            {
                Console.WriteLine($"Se logro la meta de {META}");
                Console.WriteLine(total);
            }
            else
            {
                Console.WriteLine($"No se logro la meta de {META}");
                Console.WriteLine(total);
            }
        }

        public static void task48()
        {
            Console.WriteLine("""
            El crecimiento del parque automotor superó al de las vias. Los sensores de los anillos miden cuantos minutos pierde un vehiculo en cada tramo en hora pico.

            El sistema de la Direccion de Trafico y Transporte recibe datos mal digitados y eso arruina los reportes. Elabore un programa que pida el valor de minutos de retraso promedio y lo vuelva a pedir una y otra vez hasta que el usuario escriba un numero valido dentro del rango permitido: de 1 a 180 minutos. Cada vez que el dato sea invalido debe mostrarse un mensaje de error explicando el rango.

            Requisitos obligatorios
            Usar do while: el dato se pide al menos una vez.
            La condicion del ciclo debe repetir mientras el valor este fuera del rango.
            Usar un if dentro del ciclo para mostrar el mensaje de error.
            Los limites minimo y maximo deben ser constantes.

            """);

            const int NUMBER_MINIMAL = 1;
            const int NUMBER_MAYOR = 180;
            int minut;
            do
            {
                Console.Write("Ingrese sus minutos de retraso: ");
                minut = int.Parse(Console.ReadLine());

                if (!(minut>=NUMBER_MINIMAL && minut<=NUMBER_MAYOR))
                {
                    Console.WriteLine($"El rango es de {NUMBER_MINIMAL} a {NUMBER_MAYOR}");
                }
                

            }while(!(minut>=NUMBER_MINIMAL && minut<=NUMBER_MAYOR));

        }

        public static void task49()
        {
            Console.WriteLine("""
            Las comunidades del rio Beni denuncian contaminacion por mercurio usado en la mineria del oro. Cada punto de muestreo entrega un valor que debe compararse con el limite sanitario.

            Construya el menu de consulta que usara el personal de el Servicio Nacional de Sanidad Agropecuaria (SENASAG). El menu debe mostrarse una y otra vez hasta que el usuario elija la opcion 4 (Salir). Las opciones son: 1) Ver el registro de puntos de muestreo, 2) Ver la meta del periodo, 3) Ver el rango valido de nivel de mercurio medido y 4) Salir. Si el usuario escribe cualquier otro numero, el programa debe avisar que la opcion no existe.

            Requisitos obligatorios
            Usar do while para repetir el menu hasta que la opcion sea 4.
            Usar una escalera if / else if / else para atender cada opcion.
            El else final atiende las opciones invalidas.
            Los textos fijos del menu deben salir de constantes.

            """);

            const int NUMBER_MINIMAL = 1;
            const int NUMBER_MAYOR = 4;
            int opcion;
            do
            {
                Console.WriteLine("""
                1) Ver el registro de puntos de muestreo
                2) Ver la meta del periodo
                3) Ver el rango valido de nivel de mercurio medido 
                4) Salir
                """);
                Console.Write("Ingrese su opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (!(opcion>=NUMBER_MINIMAL && opcion<=NUMBER_MAYOR))
                {
                    Console.WriteLine($"El rango es de {NUMBER_MINIMAL} a {NUMBER_MAYOR}");
                }
                

            }while(!(opcion>=NUMBER_MINIMAL && opcion<=NUMBER_MAYOR));
        }

        public static void task50()
        {
            Console.WriteLine("""
            El Chacaltaya desaparecio y el Illimani pierde masa cada ano. Las mediciones anuales alimentan el modelo de disponibilidad futura de agua para La Paz y El Alto.

            El Instituto de Hidraulica e Hidrologia de la UMSA debe saber cuantos de sus 6 mediciones glaciologicas alcanzan el umbral de 30 metros de metros de retroceso del glaciar. Elabore un programa que recorra los 6 mediciones glaciologicas con un ciclo for, pida el dato de cada uno, indique en el momento si CUMPLE o NO CUMPLE, y al final informe cuantos cumplieron y cuantos no.

            Requisitos obligatorios
            Usar un ciclo for que vaya de 1 hasta 6.
            Usar if / else dentro del ciclo para decidir si cumple.
            Llevar dos contadores independientes: los que cumplen y los que no.
            Mostrar el resumen recien cuando el ciclo termine.

            """);

            const int MEDIDOR_GLACIAL = 6;
            int contador = 0;
            int contador_no_cumplen = 0;

            for (int i = 1 ; i<= MEDIDOR_GLACIAL ; i++) 
            {
                while (true)
                {
                    
                Console.Write($"Glacial {i}: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 1)
                {
                    Console.WriteLine("Error: No se aceptan numero negativos");
                }
                else if (number <=30 && number >=1)
                {
                    Console.WriteLine("CUMPLE");
                    contador ++;
                    break;
                }
                else
                {
                    Console.WriteLine("NO CUMPLE");
                    contador_no_cumplen ++;
                    break;
                }
                }

            }Console.WriteLine($"""
            Cumplieron : {contador}
            No cumplieron: {contador_no_cumplen}
            """);
        }

        public static void task51()
        {
            Console.WriteLine("""
            En epoca de cosecha muchos estudiantes dejan las aulas. La direccion distrital necesita ubicar rapido en que unidades educativas se concentra el abandono.

            El Ministerio de Educacion dispone de una reserva de 300 estudiantes y cada jornada entrega una cantidad fija a Charagua. Escriba un programa que descuente esa entrega jornada tras jornada mientras quede reserva, mostrando en cada vuelta cuanto queda, y que avise con un mensaje especial cuando la reserva baje del 20 por ciento del total.

            Requisitos obligatorios
            Usar un ciclo while que se repita mientras la reserva sea mayor que cero.
            Descontar la entrega dentro del ciclo (la reserva debe disminuir).
            Usar un if para la alerta de reserva baja.
            Contar y mostrar cuantas jornadas duro la reserva.

            """);

            int reservas = 300;
            int entrega = 0;
            int jornadas = 0;

            while (0 < reservas)
            {
                if (reservas <= 20)
                {
                    Console.WriteLine("Las reservas llegaron a menos de 20");
                    
                }
                Console.WriteLine($"Nos quedan {reservas} estudiantes");
                Console.Write("Ingrese el numero de estudiantes que quiere designar: ");
                int num_estudiantes = int.Parse(Console.ReadLine());

                if (num_estudiantes <1)
                {
                    Console.WriteLine("No se acepta numeros negativos");
                }
                else if (num_estudiantes > reservas)
                {
                    Console.WriteLine("El numero supera a el numero de estudiantes disponibles");
                }
                else
                {
                    Console.WriteLine($"Se designo el numero de {num_estudiantes} estudiantes");
                    jornadas++;
                    reservas -= num_estudiantes;
                    entrega+=num_estudiantes;
                }
                
                
                
            }

            Console.WriteLine($"""
            El numero de jornadas es: {jornadas}
            """);

        }

        public static void task52()
        {
            Console.WriteLine("""
            Muchos adultos mayores no pueden cobrar la Renta Dignidad por cajero ni usar la banca movil. El municipio abrio talleres gratuitos y mide cuantos logran certificarse.

            Elabore el semaforo de control de el Centro Municipal de Formacion Continua. Para cada uno de los 4 talleres el programa pide el valor de participantes que aprobaron el taller y lo clasifica con una escalera de decisiones: PARTICIPACION ALTA si es 40 o mas, PARTICIPACION MEDIA si llega a 20, y PARTICIPACION BAJA en cualquier otro caso. Al final debe mostrar cuantos talleres cayeron en cada categoria.

            Requisitos obligatorios
            Usar un ciclo for para los 4 talleres.
            Usar la escalera if / else if / else ordenada de mayor a menor.
            Llevar un contador por cada una de las tres categorias.
            Los umbrales deben ser constantes, no numeros sueltos en el codigo.

            """);

            const int NUM_TALLERES = 4;
            const int PARTICIPACION_ALTA = 40;
            const int PARTICIPACION_MEDIA = 20;

            int contador_alta = 0;
            int contador_media = 0;
            int contador_baja = 0;
            

            for (int i = 1 ; i <= NUM_TALLERES ; i++ )
            {
                while (true)
                {
                    Console.Write($"Ingrese el valor de integrantes del taller numero {i}: ");
                    int valueInte = int.Parse(Console.ReadLine());

                    if (valueInte >= PARTICIPACION_ALTA )
                    {
                        Console.WriteLine("Se registro la participacion alta");
                        contador_alta++;
                        break;
                    }
                    else if (valueInte < PARTICIPACION_ALTA && valueInte >= PARTICIPACION_MEDIA)
                    {
                        Console.WriteLine("Se registro la participacion media");
                        contador_media++;
                        break;
                    }
                    else if (valueInte < PARTICIPACION_MEDIA && valueInte > 1)
                    {
                        Console.WriteLine("Se registro la participacion baja");
                        contador_baja++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: No se adimiten numeros negativos");
                    }
                }
            }

            Console.WriteLine($"""
            Numero de participaciones altas: {contador_alta}
            Numero de participaciones media: {contador_media}
            Numero de participaciones baja: {contador_media}
            """);
        }

        /// <summary>
        /// Arreglar las opciones de numemros 0 y negativos en division
        /// </summary>
        public static void task53()
        {
            Console.WriteLine("""
            Miles de jovenes egresan cada ano sin encontrar su primer empleo formal. Las ferias municipales registran cuantos postulantes terminan contratados.

            El Ministerio de Trabajo, Empleo y Prevision Social organiza la inspeccion de El Alto por turnos: los ferias de empleo con numero par se inspeccionan por la manana y los impares por la tarde. Escriba un programa que recorra los 6 ferias de empleo con un ciclo while, indique a que turno va cada uno y cuente cuantos quedaron en cada turno.

            Requisitos obligatorios
            Usar while con un contador que llegue hasta 6.
            Usar if / else con la condicion numero % 2 == 0.
            Llevar un contador de pares y otro de impares.
            Mostrar el resumen de ambos turnos al final.

            """);
            int contador = 1;
            int contadorPares = 0;
            int contadorImpares= 0;
            int number;

            while (contador <= 6)
            {
                Console.Write($"Ingrese los datos de la feria {contador} de empleados: ");
                number = int.Parse(Console.ReadLine());
                if ( number % 2 == 0 )
                {
                    Console.WriteLine("Turno manana");
                    contador ++;
                    contadorPares ++;
                }
                else if (!(number % 2 == 0))
                {
                    Console.WriteLine("Turno tarde");
                    contador ++;
                    contadorImpares++;
                }
                else
                {
                    Console.WriteLine("No se aceptan numeros negativos");
                }
            }
            Console.WriteLine($"""
            Ferias del turno de la manana: {contadorPares}
            Ferias del turno de la tarde: {contadorImpares}
            """);
            
        }

        public static void task54()
        {
            Console.WriteLine("""
            Las familias recicladoras separan plastico, carton y vidrio antes de que llegue al relleno sanitario. El acopio por barrio define la ruta de recoleccion.

            Para decidir donde intervenir primero, la Cooperativa de Recicladores de Base necesita conocer el barrio con el valor mas alto y el mas bajo de kilogramos de material reciclable acopiados. Elabore un programa que lea el dato de los 8 barrios y determine el valor maximo, el minimo y el numero de barrio al que corresponde cada uno.

            Requisitos obligatorios
            Usar un ciclo for de 1 a 8.
            Guardar el primer valor leido como maximo y minimo iniciales.
            Usar if para actualizar el maximo y otro if para el minimo.
            Mostrar tambien el numero de barrio donde ocurrio cada extremo.

            """);

            int firstMaximo ;
            int firstMinimo ;
            int newMax;
            int numBarrio = 0;
            for (int i = 1; i <=8 ; i++)
            {
                while (true)
                {
                    Console.Write($"Ingrese los datos de la feria {i} de empleados: ");
                    int newNumber = int.Parse(Console.ReadLine());
                    if (i == 1)
                    {
                        firstMaximo = newNumber;
                    }
                    if (newNumber < 1)
                    {
                        Console.WriteLine("No se aceptan numeros negativos");
                    }
                    else if (newNumber == numBarrio)
                    {
                        Console.WriteLine("Son el mismo numero");
                    }
                    else if (newNumber > numBarrio && i == 2)
                    {
                        Console.WriteLine("Se remplazo el nuevo valor maximo");
                        newMax = newNumber ;
                        firstMinimo = newNumber;
                        numBarrio = i;
                        break;
                    }
                    else if (newNumber > numBarrio)
                    {
                        newMax = newNumber ;
                    }
                }
            }
            Console.WriteLine("""
            El nuevo maximo
            """);
        }
        /// <summary>
        /// /=====================
        /// =====================
        /// ====================
        /// =====================
        /// /=====================
        /// </summary>

        public static void Task55()
        {
            Console.WriteLine("""
            Regar de mas desperdicia agua escasa; regar de menos pierde la cosecha. Sensores enterrados en la parcela envian la humedad del suelo cada hora.

            El Instituto Nacional de Innovacion Agropecuaria y Forestal (INIAF) 
            necesita un programa que registre 
            de forma automatica 6 sensores de suelo de Punata (Cochabamba). 
            El programa debe numerarlos uno por uno, desde el 1 hasta el 6, 
            mostrando en pantalla una linea por cada sensor registrado y, al terminar, 
            un mensaje con el total procesado.

            Requisitos obligatorios
            Usar un ciclo while con sus tres partes: inicializacion, condicion y actualizacion.
            La cantidad total debe estar declarada como const int.
            Mostrar el numero de cada sensor dentro del ciclo.
            Mostrar el total registrado despues de que el ciclo termina.

            """);

            const int SENSORES = 6;
            int contador = 1;

            while (contador <= 6)
            {
                Console.WriteLine($"Sensor numero {contador} registrado");
                contador++;
            }
            Console.WriteLine($"Se registraron los {SENSORES} sensores");
        }

        public static void Task56()
        {
            Console.WriteLine("""
            Un semaforo que se adapta al flujo real puede ahorrar horas de vida a la ciudad. 
            Los sensores de cada cruce reportan el tiempo de espera promedio.

            Escriba un programa que pida al operador de el Gobierno Autonomo Municipal de Cochabamba
            el dato de segundos de espera promedio para cada uno de los 8 cruces semaforizados 
            de Cochabamba, vaya sumando esos valores y muestre el total acumulado. 
            Al final el programa debe indicar si el total alcanzo la meta de 800 segundos.

            Requisitos obligatorios
            Usar un ciclo while para pedir los 8 valores.
            Acumular en una variable suma (la suma parte de cero).
            La meta debe ser una constante.
            Al terminar el ciclo, comparar con if / else el total contra la meta.

            """);

            const int META = 800;
            const int CRUCES = 8;
            int contador = 1;
            int sum = 0;

            while (contador <= CRUCES)
            {
                while (true)
                {
                    Console.Write($"Ingrese los datos por segundo del cruce numero {contador}: ");
                    int segundos = int.Parse(Console.ReadLine());
                    if (segundos < 0)
                    {
                        Console.WriteLine("No se aceptan numeros negativos");
                    }
                    else if(segundos == 0)
                    {
                        Console.WriteLine("No se aceptan 0");
                    }
                    else
                    {
                        Console.WriteLine("Se registro");
                        sum += segundos;
                        contador++;
                        break;
                    }
                    
                }
                
            }
            if (sum >= META)
            {
                Console.WriteLine("Se alcanzo la meta");
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No se alcanzo la meta");
                Console.WriteLine(sum);
            }
        }

        public static void Task57()
        {
            Console.WriteLine("""
            El riego por inundacion pierde la mitad del agua. Un controlador abre las valvulas 
            solo cuando el sensor lo pide y registra el ahorro.

            El sistema de la Gobernacion de Santa Cruz recibe datos mal digitados 
            y eso arruina los reportes. Elabore un programa que pida el valor de litros de agua 
            ahorrados en la semana y lo vuelva a pedir una y otra vez hasta que el usuario 
            escriba un numero valido dentro del rango permitido: de 10 a 2000 litros. 
            Cada vez que el dato sea invalido debe mostrarse un mensaje de error explicando el rango.

            Requisitos obligatorios
            Usar do while: el dato se pide al menos una vez.
            La condicion del ciclo debe repetir mientras el valor este fuera del rango.
            Usar un if dentro del ciclo para mostrar el mensaje de error.
            Los limites minimo y maximo deben ser constantes.


            """);

            const int RANGO_MINIMO = 10;
            const int RANGO_MAXIMO = 2000;
            int litros;
            do
            {
                while(true)
                {
                Console.Write($"Ingrese los litros de agua: ");
                    litros = int.Parse(Console.ReadLine());
                    if (litros < 0)
                    {
                        Console.WriteLine("No se aceptan numeros negativos");
                    }
                    else if(litros == 0)
                    {
                        Console.WriteLine("No se aceptan 0");
                    }
                    else if(litros <= RANGO_MINIMO || litros>=RANGO_MAXIMO)
                    {
                        Console.WriteLine($"El rango es de {RANGO_MINIMO} - {RANGO_MAXIMO}");
                    }
                    else if(litros >= RANGO_MINIMO && litros<=RANGO_MAXIMO)
                    {
                        Console.WriteLine("Se registro");
                        break;
                    }
                    
                }
            }while(litros <= RANGO_MINIMO && litros>=RANGO_MAXIMO);
            
        }

        public static void Task58()
        {
            Console.WriteLine("""
            Publicar datos publicos permite que estudiantes y periodistas construyan sus propios 
            analisis. El portal mide que conjuntos realmente se usan.

            Construya el menu de consulta que usara el personal de la Agencia de Gobierno Electronico 
            y TIC (AGETIC). El menu debe mostrarse una y otra vez hasta que el usuario elija 
            la opcion 4 (Salir). Las opciones son: 1) Ver el registro de conjuntos de datos publicados, 2) Ver la meta del periodo, 3) Ver el rango valido de descargas registradas en el mes y 4) Salir. Si el usuario escribe cualquier otro numero, el programa debe avisar que la opcion no existe.

            Requisitos obligatorios
            Usar do while para repetir el menu hasta que la opcion sea 4.
            Usar una escalera if / else if / else para atender cada opcion.
            El else final atiende las opciones invalidas.
            Los textos fijos del menu deben salir de constantes.

            """);

            int opcion;
            do
            {
                while(true)
                {
                    Console.WriteLine("""

                    1) Ver el registro de conjuntos de datos publicados 
                    2) Ver la meta del periodo, 
                    3) Ver el rango valido de descargas registradas en el mes 
                    4) Salir.

                    """);
                    Console.Write($"Ingrese su opcion: ");
                    opcion = int.Parse(Console.ReadLine());
                    if (opcion < 0)
                    {
                        Console.WriteLine("No se aceptan numeros negativos");
                    }
                    else if(opcion == 0)
                    {
                        Console.WriteLine("No se aceptan 0");
                    }
                    else if(opcion < 1 || opcion > 4)
                    {
                        Console.WriteLine($"El rango es de {1} - {4}");
                    }
                    else if(opcion >= 1 && opcion <= 4)
                    {
                        Console.WriteLine("Se registro");
                        break;
                    }
                    
                }
                
            }while(opcion != 4);
            
        }

        public static void Task59()
        {
            Console.WriteLine("""
            En 1781 Tupac Katari y Bartolina Sisa sitiaron La Paz durante meses. 
            Los expedientes del cerco se transcriben folio por folio para ponerlos en linea.

            El Archivo y Biblioteca Nacionales de Bolivia debe saber cuantos de sus 
            8 documentos coloniales alcanzan el umbral de 250 documentos de folios transcritos 
            del expediente. Elabore un programa que recorra los 8 documentos coloniales con 
            un ciclo for, pida el dato de cada uno, indique en el momento si CUMPLE o NO CUMPLE, 
            y al final informe cuantos cumplieron y cuantos no.

            Requisitos obligatorios
            Usar un ciclo for que vaya de 1 hasta 8.
            Usar if / else dentro del ciclo para decidir si cumple.
            Llevar dos contadores independientes: los que cumplen y los que no.
            Mostrar el resumen recien cuando el ciclo termine.

            """);

            const int UMBRAL = 250;
            int contadorCumple = 0;
            int contadorNCumple = 0;
            int paginas;
            for(int i = 1 ; i <= 8; i++)
            {
                while(true)
                {
                    Console.Write($"Ingrese el numero de paginas del documento {i}: ");
                    paginas = int.Parse(Console.ReadLine());
                    if (paginas < 0)
                    {
                        Console.WriteLine("No se aceptan numeros negativos");
                    }
                    else if(paginas == 0)
                    {
                        Console.WriteLine("No se aceptan 0");
                    }
                    else if(paginas >= UMBRAL)
                    {
                        Console.WriteLine("Cumple");
                        contadorCumple++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No cumple");
                        contadorNCumple++;
                        break;
                    }
                    
                }
                
            }
            Console.WriteLine($"""
            Numero de documentos que superan o cumplen el Umbral de {UMBRAL}: {contadorCumple}
            Numero de documentos que no cumplen el Umbral de {UMBRAL}: {contadorNCumple}
            """);
        }

        public static void Task60()
        {
            Console.WriteLine("""
            En Ingavi, el 18 de noviembre de 1841, Bolivia consolido su existencia como 
            Estado frente a la invasion peruana. El museo inventaria el material de la campana.

            El Museo Militar dispone de una reserva de 1500 objetos y cada jornada entrega 
            una cantidad fija a Viacha (La Paz). Escriba un programa que descuente 
            esa entrega jornada tras jornada mientras quede reserva, mostrando en cada 
            vuelta cuanto queda, y que avise con un mensaje especial cuando la reserva 
            baje del 20 por ciento del total.

            Requisitos obligatorios
            Usar un ciclo while que se repita mientras la reserva sea mayor que cero.
            Descontar la entrega dentro del ciclo (la reserva debe disminuir).
            Usar un if para la alerta de reserva baja.
            Contar y mostrar cuantas jornadas duro la reserva.

            """);

            int reservas = 1500;
            int envio;
            int jornadas = 0;

            while (0 < reservas)
            {
                
                while(true)
                {
                    Console.WriteLine($"Reservas existentes: {reservas}");
                    Console.Write($"Ingrese el numero envios: ");
                    envio = int.Parse(Console.ReadLine());
                    
                    if (reservas <= 20)
                    {
                        Console.WriteLine("Las reservas ya son menores o iguales a 20");
                    }
                    if (envio < 0)
                    {
                        Console.WriteLine("No se aceptan numeros negativos");
                    }
                    else if(envio == 0)
                    {
                        Console.WriteLine("No se aceptan 0");
                    }
                    else if (envio > reservas)
                    {
                        Console.WriteLine("No se pueden enviar reservas superiores a las existentes");
                    }
                    else if (envio <= reservas)
                    {
                        Console.WriteLine($"Se registro el envio de {envio}");
                        reservas -= envio;
                        jornadas ++;
                        break;
                    }

                }
            }
            Console.WriteLine($"El numero de jornadas es: {jornadas}");
        }

        public static void Task61()
        {
            Console.WriteLine("""
            La Revolucion de 1952 trajo el voto universal, la nacionalizacion de 
            las minas y una nueva forma de entender la ciudadania. Sus archivos siguen 
            siendo consultados.

            Elabore el semaforo de control de la Central Obrera Boliviana (COB). 
            Para cada uno de los 6 registros de la epoca el programa pide el valor de registros 
            historicos digitalizados y lo clasifica con una escalera de 
            decisiones: DIGITALIZACION ALTA si es 300 o mas, DIGITALIZACION MEDIA si llega a 120, 
            y DIGITALIZACION BAJA en cualquier otro caso. Al final debe mostrar cuantos registros 
            de la epoca cayeron en cada categoria.

            Requisitos obligatorios
            Usar un ciclo for para los 6 registros de la epoca.
            Usar la escalera if / else if / else ordenada de mayor a menor.
            Llevar un contador por cada una de las tres categorias.
            Los umbrales deben ser constantes, no numeros sueltos en el codigo.

            """);

            const int DIGITALIZACION_ALTA = 300;
            int contadorAlta = 0;
            const int DIGITALIZACION_MEDIA = 120;
            int contadorMedia = 0;
            const int DIGITALIZACION_BAJA = 1;
            int contadorBaja = 0;
            int numregistro;
            for(int i = 1 ; i <= 6; i++)
            {
                while(true)
                {
                    Console.Write($"Ingrese el numero del registro numero {i}: ");
                    numregistro = int.Parse(Console.ReadLine());
                    if (numregistro < 0)
                    {
                        Console.WriteLine("No se aceptan numeros negativos");
                    }
                    else if(numregistro == 0)
                    {
                        Console.WriteLine("No se aceptan 0");
                    }
                    else if (numregistro >= DIGITALIZACION_ALTA)
                    {
                        Console.WriteLine("Digitalizacion Alta registrada");
                        contadorAlta++;
                        break;
                    }
                    else if (numregistro >= DIGITALIZACION_MEDIA && numregistro < DIGITALIZACION_ALTA)
                    {
                        Console.WriteLine("Digitalizacion Media registrada");
                        contadorMedia++;
                        break;
                    }
                    else if (numregistro < DIGITALIZACION_MEDIA && numregistro >= DIGITALIZACION_BAJA)
                    {
                        Console.WriteLine("Digitalizacion Baja registrada");
                        contadorBaja++;
                        break;
                    }
                    
                }
                
            }
            Console.WriteLine($"""
            Catregoria Digitalizacion Alta: {contadorAlta}
            Catregoria Digitalizacion Media: {contadorMedia}
            Catregoria Digitalizacion Baja: {contadorBaja}
            """);
        }

        public static void Task62()
        {
            Console.WriteLine("""
            El ferrocarril Guaqui - La Paz cambio el comercio del altiplano a inicios del 
            siglo XX. Parte de esa via historica todavia se inspecciona y conserva.

            La Empresa Ferroviaria Andina organiza la inspeccion de Guaqui por turnos: 
            los tramos de via con numero par se inspeccionan por la manana y 
            los impares por la tarde. Escriba un programa que recorra los 
            8 tramos de via con un ciclo while, indique a que turno va cada uno y 
            cuente cuantos quedaron en cada turno.

            Requisitos obligatorios
            Usar while con un contador que llegue hasta 8.
            Usar if / else con la condicion numero % 2 == 0.
            Llevar un contador de pares y otro de impares.
            Mostrar el resumen de ambos turnos al final.

            """);

            const int TRAMOS = 8;
            int contador = 1;
            int turnoTarde = 0;
            int turnoManana = 0;
            

            while (contador <= TRAMOS)
            {
                while (true)
                {
                    Console.Write($"Ingrese los datos del tramo numero {contador}: ");
                    int segundos = int.Parse(Console.ReadLine());
                    if (segundos < 0)
                    {
                        Console.WriteLine("No se aceptan numeros negativos");
                    }
                    else if(segundos == 0)
                    {
                        Console.WriteLine("No se aceptan 0");
                    }
                    else if (segundos % 2 == 0)
                    {
                        Console.WriteLine("Turno de manana");
                        
                        turnoManana++;
                        contador++;
                        break;
                    }
                    else if (segundos % 2 != 0)
                    {
                        Console.WriteLine("Turno de Tarde");
                        contador++;
                        turnoTarde ++;
                        break;
                    }
                    
                }
                
            }
            Console.WriteLine($"""
            Numero de turnos manana = {turnoManana}
            Numero de turnos tarde = {turnoTarde}
            """);
        }

        public static void Task63()
        {
            Console.WriteLine("""
            La Constitucion aprobada en 2009 declaro a Bolivia un Estado Plurinacional.
            Sus 411 articulos se estudian por bloques en las carreras de derecho e ingenieria.

            Para decidir donde intervenir primero, la Asamblea Constituyente 
            necesita conocer el articulo con el valor mas alto y el mas bajo de 
            articulos analizados en el estudio. Elabore un programa que lea el dato de 
            los 4 articulos de la Constitucion y determine el valor maximo, el minimo 
            y el numero de articulo al que corresponde cada uno.

            Requisitos obligatorios
            Usar un ciclo for de 1 a 4.
            Guardar el primer valor leido como maximo y minimo iniciales.
            Usar if para actualizar el maximo y otro if para el minimo.
            Mostrar tambien el numero de articulo donde ocurrio cada extremo.

            """);
            int articulo ;
            int valorMayor  = 0;
            int numArticuloMenor = 0;
            int valorMenor = 0;
            int numArticuloMayor = 0;
            
            for(int i = 1 ; i <= 4; i++)
            {
                while(true)
                {
                    Console.Write($"Ingrese el numero del Articulo numero {i}: ");
                    articulo= int.Parse(Console.ReadLine());

                    if (articulo < 0)
                    {
                        Console.WriteLine("No se aceptan numeros negativos");
                    }
                    else
                    {
                        
                        if(articulo== 0)
                        {
                            Console.WriteLine("No se aceptan 0");
                        }
                        else if (valorMayor == articulo || valorMenor == articulo)
                        {
                            break;
                        }
                        else if (i == 1)
                        {
                            valorMayor += articulo;
                            valorMenor += articulo;
                            Console.WriteLine(valorMayor);
                            Console.WriteLine(valorMenor);
                            numArticuloMayor = i;
                            break;
                        }
                        else if (valorMayor < articulo )
                        {
                            valorMayor = articulo;
                            Console.WriteLine(valorMayor);
                            Console.WriteLine(valorMenor);
                            numArticuloMayor = i;
                            break;
                        }
                        
                        if (valorMenor > articulo)
                        {
                            
                            valorMenor = articulo;
                            numArticuloMenor = i;
                            break;
                        }
                        
                        else if (articulo > valorMenor)
                        {
                            break;
                        }
                    }
                }         
            }
            Console.WriteLine($"""
            Numero de articulo del valor mayor {valorMayor}:{numArticuloMayor}
            Numero de articulo del valor menor {valorMenor}:{numArticuloMenor}
            """);
                
        }

        

        public static void Task64()
        {
            Console.WriteLine("""
            La brecha entre el tipo de cambio oficial y el paralelo obliga a 
            monitorear cuantos dolares realmente vende cada casa de cambio 
            autorizada durante el dia.

            Elabore un programa que calcule el promedio de dolares vendidos en la jornada 
            de los 6 operaciones de cambio de Santa Cruz de la Sierra. 
            El programa debe acumular los valores dentro de un ciclo while, 
            calcular el promedio al salir y compararlo con el umbral de 1200 dolares 
            para informar si la situacion de Santa Cruz de la Sierra es aceptable o 
            requiere intervencion.

            Requisitos obligatorios
            Usar while para leer los 6 valores.
            Acumular la suma y despues dividir entre 6 para el promedio.
            Usar variables double para el promedio.
            Usar if / else para el diagnostico final.

            """);


            const int META = 1200;
            const int OPERACIONES = 6;
            int contador = 1;
            int sum = 0;

            while (contador <= OPERACIONES)
            {
                while (true)
                {
                    Console.Write($"Ingrese los datos de la operacion numero {contador} en $: ");
                    int segundos = int.Parse(Console.ReadLine());
                    if (segundos < 0)
                    {
                        Console.WriteLine("No se aceptan numeros negativos");
                    }
                    else if(segundos == 0)
                    {
                        Console.WriteLine("No se aceptan 0");
                    }
                    else
                    {
                        Console.WriteLine("Se registro");
                        sum += segundos;
                        contador++;
                        break;
                    }
                    
                }
                
            }
            double promedio = sum / OPERACIONES;
            if (promedio >= META)
            {
                Console.WriteLine("Se alcanzo la meta");
                Console.WriteLine(promedio);
            }
            else
            {
                Console.WriteLine("No se alcanzo la meta");
                Console.WriteLine(promedio);
            }
        
        }

        public static void Task65()
        {
            Console.WriteLine("""
            Los incendios de la Chiquitania consumen cada ano millones de hectareas de 
            bosque seco. El monitoreo satelital reporta focos de calor que deben clasificarse 
            por gravedad.

            Desarrolle el sistema de gestion de la Autoridad de Fiscalizacion de 
            Bosques y Tierra (ABT). El menu principal se repite hasta que 
            el usuario elija 3) Salir. La opcion 1) Registrar foco de calor 
            abre un submenu donde se elige la zona (1 zona norte, 2 zona sur);
            dentro de cada zona se pregunta ademas si el registro es urgente (1 si, 2 no), 
            lo que cambia el mensaje final. La opcion 2) Consultar meta muestra la meta 
            del periodo. Cualquier otra entrada debe rechazarse.

            Requisitos obligatorios
            Menu principal controlado con do while.
            Dentro de la opcion 1 debe existir un if anidado dentro de otro if (zona y urgencia).
            Cada nivel del anidamiento debe estar indentado correctamente.
            Contar cuantos registros urgentes se hicieron y mostrarlos al salir.

            """);

            int registrosUrgentes = 0;
            int registrosNoUrgentes = 0;
            int opcion;
            int opcionSubmenu ;
            do
            {   while (true)
                {
                    Console.WriteLine("""
                    ==== MENU PRINCIPAL ====
                    1) Registrar foco de calor
                    2) Consultar meta
                    3) Salir

                    """);
                    Console.Write("Ingrese su opcion: ");
                    opcion = int.Parse(Console.ReadLine());
                    if (opcion < 0)
                    {
                        Console.WriteLine("No se aceptan numeros negativos");
                    }
                    else if(opcion == 0)
                    {
                        Console.WriteLine("No se aceptan 0");
                    }
                    else if(opcion == 1  )
                    {
                        Console.WriteLine("""
                        === Registrar foco de calor ===
                        1) Zona Norte
                        2) Zona Sur
            
                        """);Console.Write("Ingrese su opcion: ");
                        opcionSubmenu = int.Parse(Console.ReadLine());
                        if (opcionSubmenu < 0)
                        {   
                            Console.WriteLine("No se aceptan numeros negativos");
                        }
                        else if(opcionSubmenu == 0)
                        {   
                            Console.WriteLine("No se aceptan 0");
                        }
                        else if (opcionSubmenu == 1)
                        {
                            Console.WriteLine("""
                            Indique la gravedad en la Zona Norte
                            1) Si
                            2) No
                            """);
                            opcionSubmenu = int.Parse(Console.ReadLine());
                            if (opcionSubmenu == 1)
                            {
                                Console.WriteLine("Se envio el efectivo de manera urgente a la Zona Norte");
                                registrosUrgentes ++;
                                break;
                            }
                            else if (opcionSubmenu == 2)
                            {
                                Console.WriteLine("Se envio el efectivo a la Zona Norte");
                                registrosNoUrgentes ++;
                                break;
                            }
                        }
                        else if (opcionSubmenu == 2)
                        {
                            Console.WriteLine("""
                            Indique la gravedad en la Zona Sur
                            1) Si
                            2) No
                            """);
                            opcionSubmenu = int.Parse(Console.ReadLine());
                            if (opcionSubmenu == 1)
                            {
                                Console.WriteLine("Se envio el efectivo de manera urgente a la Zona Sur");
                                registrosUrgentes ++;
                                break;
                            }
                            else if (opcionSubmenu == 2)
                            {
                                Console.WriteLine("Se envio el efectivo a la Zona Sur");
                                registrosNoUrgentes ++;
                                break;
                            }
                        }

                        
                    }
                    else if(opcion == 2 )
                    {
                        Console.WriteLine("""
                        La Meta es de :
                        """);
                        
                    }
                    else if (opcion == 3)
                    {
                        Console.WriteLine("Saliendo...");
                        
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Solo se aceptan los numeros del menu");
                    }
                }


            }while(opcion != 3);
            Console.WriteLine($"""
            Reportes urgentes: {registrosUrgentes}
            Reportes no urgentes: {registrosNoUrgentes}
            """);

        }
        

        public static void Task66()
        {
            Console.WriteLine("""
            Cuando bajan las represas, el servicio se corta por horas y por zonas. 
            El sistema registra cuantas horas de agua recibio realmente cada barrio.

            La Empresa Publica Social de Agua y Saneamiento (EPSAS) ya no se conforma con 
            clasificar: ahora tambien quiere saber si el dato fue verificado en campo. 
            Para cada uno de los 4 barrios el programa pide el valor de horas de servicio 
            de agua al dia y, solo si el valor es 18 o mayor, pregunta si fue verificado 
            en campo (1 = si, 2 = no). Un dato alto verificado se reporta 
            como SERVICIO BUENO CONFIRMADO; uno alto sin verificar se reporta 
            como SERVICIO BUENO PENDIENTE DE VERIFICACION. Los valores desde 10 
            se reportan como RACIONADO y el resto como CRITICO.

            Requisitos obligatorios
            Ciclo for para recorrer los 4 barrios.
            Escalera if / else if / else para las tres categorias.
            if anidado dentro de la rama alta para la verificacion en campo.
            Contar por separado los confirmados y los pendientes.

            """);
            const int VERIFICACION = 18;
            const int RACIONADO = 10;
            int contadorPendiente = 0;
            int contadorConfirmados = 0;
            int racionados = 0;
            int criticos = 0;
            int horasAgua;
            int verificacion;

            for (int i = 1; i <= 4; i++)
            {
                while (true)
                {
                    Console.Write($"Ingrese su hora de servicio de agua al dia del barrio {i}: ");
                    horasAgua = int.Parse(Console.ReadLine());
                    if (horasAgua < 0)
                    {
                        Console.WriteLine("No se aceptan numeros negativos");
                    }
                    else if(horasAgua == 0)
                    {
                        Console.WriteLine("No se aceptan 0");
                    }
                    else if(horasAgua >= VERIFICACION )
                    {
                        Console.WriteLine("""
                        Fue verificado
                        1) Si
                        2) No
                        """);
                        Console.Write("Ingrese su opcion: ");
                        verificacion = int.Parse(Console.ReadLine());
                        if (verificacion < 0)
                        {   
                            Console.WriteLine("No se aceptan numeros negativos");
                        }
                        else if(verificacion == 0)
                        {   
                            Console.WriteLine("No se aceptan 0");
                        }
                        else if (verificacion == 1)
                        {
                            Console.WriteLine("Registrando...");
                            contadorConfirmados++;
                            break;
                        }
                        else if (verificacion == 2)
                            {
                                Console.WriteLine("Registrando...");
                                contadorPendiente ++;
                                break;
                            }
                    }
                    else if (horasAgua >= RACIONADO && horasAgua < VERIFICACION)
                    {
                        Console.WriteLine("Registrando Racionado");
                        racionados++;
                        break;
                    }else if (horasAgua < RACIONADO)
                    {
                        Console.WriteLine("Registrando critico");
                        criticos++;
                        break;
                    }
                }
                    
            }
            Console.WriteLine($"""
            SERVICIO BUENO PENDIENTE DE VERIFICACION = {contadorPendiente}
            SERVICIO BUENO CONFIRMADO = {contadorConfirmados}
            Racionados = {racionados}
            Criticos = {criticos}
            """);
        }
        

        public static void Task67()
        {
            Console.WriteLine("""
            Las imagenes satelitales muestran chaqueos ilegales. 
            Cada parcela inspeccionada reporta cuantas hectareas fueron desmontadas 
            sin autorizacion.

            La Autoridad de Fiscalizacion de Bosques y Tierra (ABT) quiere saber en cuantos 
            periodos alcanzara la meta de 3000 hectareas si cada periodo suma una cantidad 
            que el usuario informa. Escriba un programa que siga pidiendo 
            el avance de cada periodo mientras el acumulado no llegue a la meta, 
            contando los periodos transcurridos y mostrando el saldo pendiente en cada vuelta. 
            Si en algun periodo el usuario informa 0, el programa debe advertir que 
            el periodo fue improductivo.

            Requisitos obligatorios
            Ciclo while cuya condicion sea que el acumulado siga por debajo de la meta.
            Contador de periodos que aumenta en cada vuelta.
            if / else dentro del ciclo para el aviso de periodo improductivo.
            Al final informar el total acumulado, el excedente y la cantidad de periodos usados.

            """);
            const int META = 3000;
            int productivo = 0;
            int periodos = 0;

            while (productivo <= META)
            {
                while (true)
                {
                    Console.Write($"Ingrese los avances: ");
                    int avances = int.Parse(Console.ReadLine());
                    if (avances < 0)
                    {
                        Console.WriteLine("No se aceptan numeros negativos");
                    }
                    else if(avances == 0)
                    {
                        Console.WriteLine("Dia improductivo");
                        periodos++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Se registro de {avances}");
                        productivo += avances;
                        periodos++;
                        break;
                    }
                    
                }
                
            }
            Console.WriteLine($"""
            
            Total de periodos usados: {periodos}
            Total de productividad: {productivo}
            Excedente: {productivo - META}

            """);

        }

        public static void Task68()
        {
            Console.WriteLine("""
            El pan de batalla es el termometro social del pais. 
            Cada panaderia reporta su produccion diaria para detectar donde 
            falta harina subvencionada.

            La Empresa de Apoyo a la Produccion de Alimentos (EMAPA) levanta informacion en 
            2 zonas de Potosi durante 4 dias. Elabore un programa con ciclos anidados 
            que recorra zona por zona y, dentro de cada zona, dia por dia, pidiendo 
            el valor de unidades de pan producidas. El programa debe mostrar el subtotal 
            de cada zona, marcar la zona como ABASTECIDA o EN RIESGO segun supere 
            o no el umbral de 2500 unidades, y al final entregar el total general de Potosi.

            Requisitos obligatorios
            Un ciclo for exterior para las zonas y otro interior para los dias.
            Reiniciar el subtotal de la zona al comenzar cada zona (dentro del ciclo exterior).
            Usar if / else para clasificar cada zona.
            Acumular el total general fuera del ciclo interior.
            """);

            const int ABASTECIDA = 2500;
            const int ZONAS = 2;
            const int DIAS = 4;
            int contAbastecidas = 0;
            int contEnRiesgoTotal = 0;
            int contAbastecidasTotal = 0;
            int total = 0;
            int contEnRiesgo = 0;
            int panesProducidas;

            for (int zonas = 1 ; zonas <= ZONAS ; zonas++)
            {
                for (int dias = 1; dias<= DIAS ; dias++)
                {
                    while (true)
                    {
                        Console.Write($"Ingrese el numero de panes producidas de la zona {zonas} el dia {dias}: ");
                        panesProducidas = int.Parse(Console.ReadLine());

                        if (panesProducidas < 0)
                        {   
                            Console.WriteLine("No se aceptan numeros negativos");
                        }
                        else if(panesProducidas == 0)
                        {   
                            Console.WriteLine("No se aceptan 0");
                        }
                        else if (panesProducidas >= ABASTECIDA)
                        {
                            Console.WriteLine("Registrando... A");
                            contAbastecidas++;
                            contAbastecidasTotal ++;
                            total += panesProducidas;
                            break;
                        }
                        else if (panesProducidas < ABASTECIDA)
                        {
                            Console.WriteLine("Registrando... R");
                            contEnRiesgo++;
                            contEnRiesgoTotal++;
                            total += panesProducidas;
                            break;
                        }
                    
                    }
                }
                Console.WriteLine($"""
                En la zona: {zonas} 
                Abastecidas: {contAbastecidas}
                Riesgo: {contEnRiesgo}

                """);
                contAbastecidas = 0;
                contEnRiesgo = 0;
            }
            Console.WriteLine($"""

            ===== REPORTE GENERAL =====
            Total de zonas contabilizadas: {ZONAS} 
            Abastecidas: {contAbastecidasTotal}
            Riesgo: {contEnRiesgoTotal}
            Total de panes producidas: {total}

            """);
        }

        public static void Task69()
        {
            Console.WriteLine("""
            Las brigadas moviles recorren comunidades del Beni durante la campana de vacunacion.
            Cada centro reporta cuantas dosis aplico para saber donde falta refuerzo.

            El sistema de el Servicio Departamental de Salud (SEDES Beni) guarda informacion 
            sensible de Trinidad. Elabore el control de acceso: el usuario tiene 3 intentos 
            para ingresar el codigo correcto (use el numero 2018 como codigo, que corresponde 
            a un dato del caso). Si acierta, el programa pregunta ademas el nivel de permiso 
            (1 = consulta, 2 = edicion) y muestra un mensaje distinto para cada uno. 
            Si agota los intentos, la cuenta se bloquea.

            Requisitos obligatorios
            Usar do while que se repita mientras queden intentos y no se haya acertado.
            Descontar un intento en cada vuelta fallida.
            Usar if anidado: dentro del acierto, decidir el nivel de permiso.
            Mostrar cuantos intentos quedan despues de cada error.

            """);

            const int CODIGO = 2018;
            const int INTENTOS = 3;
            int intentosRealizados = 0;

            while (intentosRealizados < INTENTOS)
            {
                    Console.Write("Ingrese el codigo de verificacion: ");
                    int intento = int.Parse(Console.ReadLine());

                    if (intento != CODIGO)
                    {
                        intentosRealizados++;
                        Console.WriteLine($"Error no es el codigo correcto te quedan {INTENTOS - intentosRealizados}");
                    }
                    else
                    {
                        Console.WriteLine("""

                        ==== Nivel de Permisos ===
                        1 = consulta
                        2 = edicion

                        """);
                        Console.Write("Ingrese el nivel de permisos: ");
                        int permiso = int.Parse(Console.ReadLine());

                        switch (permiso)
                        {
                            case 1:
                            Console.WriteLine("Se dio los permisos de consulta");
                            break;

                            case 2:
                            Console.WriteLine("Se dio los permisos de edicion");
                            break;

                            default:
                            Console.WriteLine("Numero invalido");
                            break;
                        }
                    
                    }
                
            }if (intentosRealizados == 3)
                {
                    Console.WriteLine("Se bloqueo la cuenta");
                    
                }
        }

        public static void Task70()
        {
            Console.WriteLine("""
            Las aceras empinadas de La Paz son una barrera diaria. 
            Una brigada recorre esquina por esquina y anota el estado real de las rampas.

            El Gobierno Autonomo Municipal de La Paz aplica un incentivo escalonado sobre 
            el resultado de cada esquina: quien alcanza 25 rampas o mas recibe un incentivo 
            del 20 por ciento del valor reportado; quien llega a 12 recibe el 10 por ciento; 
            y por debajo de eso no recibe incentivo pero se registra una observacion. 
            Elabore un programa que procese los 6 esquinas evaluadas, calcule el incentivo 
            de cada uno y acumule el incentivo total del periodo.

            Requisitos obligatorios
            Ciclo for para los 6 esquinas evaluadas.
            Escalera if / else if / else ordenada de mayor a menor.
            Calcular el incentivo con variables double.
            Acumular y mostrar el incentivo total y la cantidad de observaciones.

            """);
            double incentivo = 0;
            int observaciones = 0;
            for (int i = 1; i<=6 ; i++)
            {
                while (true)
                {
                    Console.Write($"Ingrese el numero de rampas de la esquina {i}: ");
                    double numrampas = double.Parse(Console.ReadLine());
                    
                    if (numrampas < 1)
                    {
                        Console.WriteLine("Error no se acepta 0 ni numeros negativos");
                    }else
                    {
                        if (numrampas >= 25)
                        {
                            incentivo += numrampas * 0.20;
                            Console.WriteLine($"El incentivo es del 20% de {numrampas}: {numrampas * 0.20}");
                            break;
                        }
                        else if (numrampas >= 12 && numrampas < 25)
                        {
                            incentivo += numrampas * 0.10;
                            Console.WriteLine($"El incentivo es del 10% de {numrampas}: {numrampas * 0.10}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No existe insentivo para registros menores a 10");
                            Console.WriteLine("Pero se registra la observacion");
                            observaciones++;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"""
            Incentivos total = {incentivo}
            Observaciones = {observaciones}
            """);
        }

        public static void Task71()
        {
            Console.WriteLine("""
            La carretera a Oruro concentra curvas, neblina y transporte pesado. 
            Cada tramo acumula un historial de siniestros que define donde poner senalizacion 
            y radares.

            El brigadista de la Administradora Boliviana de Carreteras (ABC) no sabe de 
            antemano cuantos tramos de carretera va a relevar en carretera La Paz - Oruro. 
            Elabore un programa que reciba valores de siniestros de transito registrados 
            uno tras otro y solo se detenga cuando el usuario escriba -1 (valor centinela). 
            Al terminar debe informar cuantos tramos de carretera se cargaron, la suma, 
            el promedio y la clasificacion general del promedio segun los umbrales 15 y 6. 
            Si el usuario escribe -1 en el primer intento, el programa debe avisar que 
            no hubo datos y no intentar dividir entre cero.

            Requisitos obligatorios
            Ciclo while controlado por el valor centinela -1.
            Contador y acumulador que solo se actualizan con datos validos.
            Proteger la division con un if (no dividir entre cero).
            Escalera if / else if / else para clasificar el promedio.

            """);
            int valorCentinela = -1;
            double contador = 0;
            double acumulador = 0;

            while (true)
            {
                Console.Write("Ingrese los tramos de carretera: ");
                int tramoCarretera = int.Parse(Console.ReadLine());

                if (tramoCarretera == valorCentinela && contador == 0)
                {
                    Console.WriteLine("No hubo datos ");
                    break;
                }
                if (tramoCarretera == valorCentinela )
                {
                    break;
                }
                else if (tramoCarretera <= 0)
                {
                    Console.WriteLine("No se aceptan numeros negativos ni 0");
                }
                else 
                {
                    Console.WriteLine("Valor registrado");
                    contador ++;
                    acumulador += tramoCarretera;
                    
                }
            }
            if (contador == 0)
            {
                Console.WriteLine("No se puede dividir entre cero");
            }
            else
            {
            Console.WriteLine($"""
            
            Se cargaron un total de: {acumulador} tramos
            El promedio es de: {acumulador / contador}
            El promedio es de con el umbral de 15: {acumulador / 15}
            El promedio es de con el umbral de 6: {acumulador / 6}

            """);
            }
        }

        public static void Task72()
        {
            Console.WriteLine("""
            Desde la creacion del SUS la demanda de consultas crecio mas rapido que la 
            infraestructura. Cada hospital reporta sus atenciones para redistribuir personal.

            El Servicio Departamental de Salud (SEDES Potosi) prepara una linea de tiempo que 
            arranca en el ano 2019 y avanza 9 anos. Elabore un programa que recorra ano 
            por ano y, para cada uno, pida cuantos hospitales de segundo nivel se registraron. 
            Cada quinto ano de la serie es un ano de hito: en esos anos el programa debe 
            preguntar ademas si hubo un acto conmemorativo (1 = si, 2 = no) y mostrar 
            un mensaje distinto en cada caso. Al final debe mostrar el total de hospitales 
            de segundo nivel y cuantos hitos se conmemoraron.

            Requisitos obligatorios
            Ciclo for que recorra los anos desde 2019.
            Detectar el ano de hito con el operador % sobre el numero de ano de la serie.
            if anidado dentro del ano de hito para la conmemoracion.
            Acumular el total de hospitales de segundo nivel y contar los hitos conmemorados.

            """);

            int contHitos = 0;
            int contHospitales = 0;

            for (int year = 2019 ; year <2028 ; year++)
            {
                if (year % 5 == 0)
                {
                    Console.WriteLine("Ano hito detectado");
                    Console.Write("""

                    Se realizo alguna conmemoracion (Si: s / No : n)
                    """);
                    string conmemoracion = Console.ReadLine();
                    if (conmemoracion == "s" || conmemoracion == "S")
                    {
                        Console.WriteLine("Se registro el ano hito");
                        contHitos++;
                    }else if (conmemoracion == "n" || conmemoracion == "N")
                    {
                        Console.WriteLine("No se registro el ano hito");
                        
                    }
                }
                Console.Write($"Cuantos Hospitales de segunfo nivel se registraron el ano {year}: ");
                int hospitales = int.Parse(Console.ReadLine());

                if (hospitales >= 1)
                {
                    contHospitales+= hospitales;
                }
            }
            Console.WriteLine($"""

            Total de hospitales de segundo nivel que se registraron es de: {contHospitales}
            Total de anos hitos conmemorados: {contHitos}

            """);
        }

        public static void Task73()
        {
            Console.WriteLine("""
            Llegar al hospital mas cercano toma ocho horas de camino. 
            Una plataforma de telemedicina conecta al auxiliar de enfermeria con un 
            especialista y registra cada consulta.

            Desarrolle un simulador de la campana que el Ministerio de Salud y Deportes 
            ejecuta en Apolo (La Paz). La brigada empieza con 3 recursos y 0 puntos. 
            En cada ronda se pregunta la estrategia: 1) intervencion intensiva, 2) 
            intervencion preventiva, 3) retirarse. La intensiva suma 20 puntos pero 
            consume un recurso; la preventiva suma la mitad de esos puntos y no consume recursos;
            retirarse termina la campana. La campana tambien termina si se agotan los recursos 
            o si se alcanzan los 900 puntos. Al final se clasifica el resultado 
            en CONSULTA COMPLETA, CONSULTA BREVE o CONSULTA INCOMPLETA.

            Requisitos obligatorios
            Ciclo do while que se repita mientras queden recursos, no se retire y 
            no se llegue a la meta.
            Escalera if / else if / else para las tres estrategias.
            Al menos un if anidado (por ejemplo, avisar cuando queda un solo recurso).
            Clasificacion final del puntaje con una escalera de rangos.

            """);
            int consultaCompleta = 0;
            int consultaBreve= 0;
            int consultaIncompleta = 0;
            const int META = 900;
            int recursos = 3;
            int puntos = 0;
            int ronda = 1;

            do
            {
                if (recursos == 1)
                {
                    Console.WriteLine("Te queda solo 1 recurso mas");
                }
                Console.WriteLine($"""
                === Ronda {ronda} ===
                1) Intervencion intensiva
                2) Intervencion preventiva
                3) Retirarse
                """);
                Console.Write("Ingrese su opcion: ");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 3)
                {
                    Console.WriteLine("Retirandose... ");
                    consultaIncompleta++;
                    break;
    
                }else if (opcion <=2 || opcion >=1)
                {
                    if (opcion == 1)
                    {
                        Console.WriteLine("Intervencio intensiva transcurriendo...");
                        Console.WriteLine(puntos);
                        consultaCompleta ++;
                        puntos += 20;
                        recursos -= 1;
                        ronda ++;
                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine("Intervencion preventiva transcurriendo...");
                        consultaBreve++;
                        puntos += 10;
                        ronda ++;
                    }
                    
                }
                else
                {
                    Console.WriteLine("No existe esa opcion");
                }


            }while((recursos > 0) && puntos <= META);
            Console.WriteLine($"""

            ==== Tabla de Calificacion ====
            Puntaje: {puntos}
            Consultas completas: {consultaCompleta}
            Consultas breves: {consultaBreve}

            """);
        }   

        public static void Task74()
        {
            Console.WriteLine("""
            Un dron cubre en una hora lo que un guardaparque recorre en tres dias. 
            Cada mision de vuelo reporta la superficie efectivamente inspeccionada.

            Integre todo lo aprendido en un solo programa para la Autoridad de Fiscalizacion 
            de Bosques y Tierra (ABT). El sistema muestra un menu que se repite hasta elegir 4) 
            Salir e incluye: 1) Carga de vuelos de dron, que pide 5 valores con un ciclo for, 
            valida cada uno en el rango 10 a 600 con un do while y acumula el total; 2) 
            Reporte de clasificacion, que muestra el promedio y lo clasifica en COBERTURA AMPLIA,
            COBERTURA MEDIA o COBERTURA LIMITADA solo si ya se cargaron datos; 3) 
            Simulacion de cobertura, que descuenta con un while el total cargado en entregas de 
            150 hectareas e informa cuantas jornadas cubre; 4) Salir, que muestra el resumen 
            general de la sesion.

            Requisitos obligatorios
            Menu principal con do while y escalera if / else if / else.
            La opcion 1 combina un for con un do while de validacion anidado dentro.
            La opcion 2 debe protegerse con un if: no clasificar si no hay datos cargados.
            La opcion 3 usa un ciclo while de descuento.
            Todos los umbrales y limites deben ser constantes.

            """);
            const int COBERTURA_AMPLIA = 100;
            const int COBERTURA_MEDIA = 50;
            const int RANGO_MINIMO = 10;
            const int RANGO_MAXIMO = 600;
            int hectareas = 150;
            int jornadas = 0;
            int opcion;
            int acumuladorValor = 0;
            int contador = 0;
            do
            {
                int valor;
                Console.WriteLine("""
                ==== MENU PRINCIPAL ====
                1) Carga de vuelos de dron
                2) Reporte de clasificacion
                3) Simulacion de cobertura
                4) Salir
                """);
                Console.Write("Ingrese su opcio de operacion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        for (int i = 1 ; i <= 5 ; i++)
                        {
                            
                                do
                                {
                                    Console.Write($"Ingrese el valor numero {i}; ");
                                    valor = int.Parse(Console.ReadLine());

                                }while((valor < RANGO_MINIMO && valor < RANGO_MAXIMO ) || (valor > RANGO_MINIMO && valor > RANGO_MAXIMO) );
                                acumuladorValor+= valor;
                                contador++;
                                Console.WriteLine($"Total: {acumuladorValor} ");

                        }
                        break;
                    case 2:
                        if (contador == 0)
                        {
                            Console.WriteLine("No se ingreso ningun valor preexistente");
                            break;
                        }
                        else 
                        {
                            int promedio = acumuladorValor / contador;
                            if (promedio >= COBERTURA_AMPLIA)
                            {
                                Console.WriteLine($"De los {contador} datos ingresados el promedio es de {promedio}");
                                Console.WriteLine("Se clasificara como cobertura amplia");
                            }
                            else if (promedio <= COBERTURA_AMPLIA && promedio > COBERTURA_MEDIA)
                            {
                                Console.WriteLine($"De los {contador} datos ingresados el promedio es de {promedio}");
                                Console.WriteLine("Se clasificara como cobertura media");
                            }
                            else if (promedio > 1 && promedio > COBERTURA_MEDIA)
                            {
                                Console.WriteLine($"De los {contador} datos ingresados el promedio es de {promedio}");
                                Console.WriteLine("Se clasificara como cobertura media");
                            }
                        }
                        break;
                    case 3:
                        while (0 <= hectareas)
                        {
                            Console.WriteLine($"Recorrido de {hectareas}");
                            jornadas ++;
                            hectareas -= 3;
                        }
                        Console.WriteLine($"La cobertura duro: {jornadas}");
                        break;
                    case 4:
                        Console.WriteLine("Saliendo... ");
                        break;
                    default:
                        Console.WriteLine("No se acepta una opcion que no este en el menu");
                        break;
                }

            }while(opcion != 4);
        }

        ///Task of Guerra del chaco
        public static void Task75()
        {
                // Lista de diálogos que se mostrarán en orden
            string[] dialogos = new string[]
            {
                "Hola, viajero... Bienvenido al sistema de la terminal.",
                
                "Este es un texto que se escribe letra por letra, simulando un teclado.",
                "Presiona ENTER para avanzar al siguiente mensaje...",
                "¡Perfecto! Has aprendido a controlar el flujo del diálogo."
            };

            // Recorremos cada diálogo
            foreach (string dialogo in dialogos)
            {
                EscribirTexto(dialogo, velocidadMs: 40);
                
                // Pausa hasta que el usuario presione ENTER
                EsperarEnter();
            }

            Console.WriteLine("\n[Fin de la conversación]");
        }
        /// <summary>
        /// Escribe un texto caracter por caracter simulando mecanografía.
        /// </summary>
        /// <param name="texto">Cadena de texto a imprimir.</param>
        /// <param name="velocidadMs">Milisegundos de espera entre cada letra.</param>
        static void EscribirTexto(string texto, int velocidadMs = 30)
        {
            foreach (char caracter in texto)
            {
                Console.Write(caracter);
                Thread.Sleep(velocidadMs); // Detiene la ejecución por N milisegundos
            }
            Console.WriteLine(); // Salto de línea al terminar la frase
        }

        /// <summary>
        /// Muestra un indicador visual y espera la tecla ENTER.
        /// </summary>
        static void EsperarEnter()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n[Presiona ENTER para continuar...]");
            Console.ResetColor();

            // Espera explícitamente a que presione ENTER
            Console.ReadLine();
            
            // OPCIONAL: Limpia la pantalla para el siguiente diálogo
            // Console.Clear(); 
        }

        public static void Task76()
        {
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }

        public static void Task77()
        {
            
            int distanciaObjetivo = 40;
            int metrosAvanzado = 0;
            int dias = 1;
            int fehchActual = 7;
            bool asaltoRealizado = false;
            int desgasteZapatador = 100;
            int sospechaP = 25;

            do
            {
                if (dias == 1)
                {
                    Console.WriteLine($"""
                    =================================================
                        DIA {dias} - {fehchActual += 1} JUNIO DE 1933
                    =================================================

                    El general Hans Kundt nos dio la orden de realizar 
                    un tunel con un 1.5 m de altura paroximadamente un 
                    ancho de 1m y una distancia calculada de 40 m

                    """);
                }
                else
                {
                    Console.WriteLine($"""
                    =================================================
                                PARTE DEL DIA {dias}
                    =================================================

                    Los metros avanzados son de {metrosAvanzado} m
                    """);
                }
                if (desgasteZapatador <= 33)
                {
                    Console.WriteLine("- El desgaste del efectivo se acumula");
                }
                if (sospechaP >= 75)
                {
                    Console.WriteLine("Guarden mas silencio las sospechas estan aumentando del lado paraguayo");
                }

                Console.WriteLine("""
                
                1) Cavar rapido --> se avanzan mas metros pero las sospechas aumentan
                2) Cavar lento --> se avanza poco pero las sospechas no aumentan mucho 
                3) Detenerse --> No se avanza pero puedes ver las sospechas
                4) Descanzar --> No se avanza pero el efectivo (zapatadores) descansa y se recuperan

                """);

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    
                    case 1:
                        metrosAvanzado +=5;
                        sospechaP += 8;
                        desgasteZapatador -=8;

                        break;
                    case 2:

                        metrosAvanzado +=3;
                        sospechaP += 4;
                        desgasteZapatador -=4;

                        break;
                
                    case 3:
                        Console.WriteLine($"Detenerse: Las sospechas paraguayas son de {sospechaP}");
                        break;
                    case 4:
                        desgasteZapatador +=4;
                        break;

                    default:
                        Console.WriteLine("No se dio la orden perdite un dia");
                        break;
                }
                dias++;
                if (metrosAvanzado >= distanciaObjetivo)
                {
                    asaltoRealizado = true;
                }

            }while(metrosAvanzado < distanciaObjetivo && desgasteZapatador > 0 && sospechaP < 100 && dias < 30);

            if (asaltoRealizado == true)
            {
                Console.WriteLine($"""
                
                =======================================
                MISION CUMPLIDA - SE REALIZO EL ASALTO
                =======================================

                Dias = {dias}
                """);
            }
            else
            {
                Console.WriteLine($"""
                
                =====================================================
                MISION FALLIDA - PASATE LA FECHA HISTORICA DEL ASALTO
                =====================================================

                Dias = {dias}
                """);
            }
            if (desgasteZapatador <= 0)
            {
                Console.WriteLine($"""
                
                ==============================================
                MISION FALLIDA: DESGASTE CORPORAL DEL EFECTIVO
                ==============================================

                Dias = {dias}
                """);
            }  
            if(sospechaP >= 100)
            {
                Console.WriteLine($"""
                
                ==========================================================
                MISION FALLIDA - LOS PARAGUAOS REALIZARON UN CONTRA ATAQUE
                ==========================================================

                Dias = {dias}
                """);
            }
        }
    
    }   
}
