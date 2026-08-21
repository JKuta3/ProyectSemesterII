using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata;
using System.Timers;
using System.Xml.XPath;
using Microsoft.VisualBasic;

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
            {36,FunctionTask.Task36} ,{37,FunctionTask.Task37} ,{38,FunctionTask.Task38} ,{39,FunctionTask.Task39},{40,FunctionTask.Task40}
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
            Console.Write(">> Seleccione el ejercicio que quiere ver: ");
            
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
            Console.WriteLine("Ejercicio 21: Pedir un número entero e indicar si es **positivo**, **negativo** o **cero**.");
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
            if (option == 1)
            {
                Operate.sum(a,b);
            }
            else if (option == 2)
            {
                Operate.rest(a,b);
            }
            else if (option == 3)
            {
                Operate.mult(a,b);
            }
            else if (option == 4)
            {
                Operate.div(a,b);
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
            Console.WriteLine("Ejercicio 24: Pedir la edad de una persona e indicar su etapa de vida: Niño (0-12), Adolescente (13-17), Adulto (18-64), Adulto mayor (65+).");
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
            
        }
        //Task32
        public static void Task32()
        {
            Console.WriteLine("Ejercicio 32: Función Crear una función `EsPar(int numero)` que retorne `true` si el número es par o `false` si es impar.");
            
        }
        //Task33
        public static void Task33()
        {
            Console.WriteLine("Ejercicio 33: Función Crear una función `CalcularMayor(double n1, double n2)` que retorne el número más alto.");
            
        }
        //Task34
        public static void Task34()
        {
            Console.WriteLine("Ejercicio 34: Validación Crear una función para dividir dos números que valide mediante un `if` que el divisor no sea 0 antes de operar.");
            
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
    
    }   
}
