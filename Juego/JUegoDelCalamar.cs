using System;

class JuegoDelCalamar
{
    static void Game()
    {
        const string NAME_GAME = "EL JUEGO DEL CALAMAR";
        const int TOTAL_CUPOS = 3;
        const int MINIMUM_AGE = 18;
        const double PREMIO_TOTAL = 45600000000;
        const string PRUEBA_1 = "Luz roja, luz verde";
        const string PRUEBA_2 = "Dalgona";
        const string PRUEBA_3 = "Tira y afloja";
        const string ESTADO_VIVO = "SOBREVIVE";
        const string ESTADO_FUERA = "ELIMINADO";

        
        string jugador1;
        string jugador2;
        string jugador3;
        string jugadorElegido = "";
        int numeroJugador = 0;
        int edad;
        int opcionPrueba;
        int decision;
        int puntaje = 0;
        string estadoFinal = ESTADO_FUERA;
        string clasificacion = "";

        Console.WriteLine("=================================");
        Console.WriteLine("======= "+ NAME_GAME+ " =========");
        Console.WriteLine("=================================");

        
        Console.Write("Nombre del jugador 001: ");
        jugador1 = Console.ReadLine();

        Console.Write("Nombre del jugador 002: ");
        jugador2 = Console.ReadLine();

        Console.Write("Nombre del jugador 003: ");
        jugador3 = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("JUGADORES REGISTRADOS");
        Console.WriteLine("001: " + jugador1);
        Console.WriteLine("002: " + jugador2);
        Console.WriteLine("003: " + jugador3);

        
        Console.WriteLine();
        Console.Write("Que jugador entra a la arena (1-3): ");
        numeroJugador = int.Parse(Console.ReadLine());

        if (numeroJugador == 1)
        {
            jugadorElegido = jugador1;
        }
        else if (numeroJugador == 2)
        {
            jugadorElegido = jugador2;
        }
        else if (numeroJugador == 3)
        {
            jugadorElegido = jugador3;
        }
        else
        {
            jugadorElegido = "SIN JUGADOR";
            numeroJugador = 0;
        }


        if (numeroJugador == 0)
        {
            Console.WriteLine("Opción inválida.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Jugador elegido: " + jugadorElegido);

            
            Console.Write("Ingresa la edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= MINIMUM_AGE)
            {
                Console.WriteLine("Edad permitida.");
                puntaje = puntaje + 20;

                
                Console.WriteLine();
                Console.WriteLine("ELIGE UNA PRUEBA");
                Console.WriteLine("1. " + PRUEBA_1);
                Console.WriteLine("2. " + PRUEBA_2);
                Console.WriteLine("3. " + PRUEBA_3);

                Console.Write("Opción: ");
                opcionPrueba = int.Parse(Console.ReadLine());

                
                if (opcionPrueba == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("PRUEBA: " + PRUEBA_1);
                    Console.WriteLine("1. Seguir corriendo");
                    Console.WriteLine("2. Quedarse inmóvil");
                    Console.WriteLine("3. Esconderse");

                    Console.Write("¿Qué haces?: ");
                    decision = int.Parse(Console.ReadLine());

                    if (decision == 2)
                    {
                        Console.WriteLine("¡Correcto! Te quedaste inmóvil.");
                        puntaje = puntaje + 40;
                        estadoFinal = ESTADO_VIVO;
                    }
                    else
                    {
                        Console.WriteLine("Movimiento detectado.");
                        estadoFinal = ESTADO_FUERA;
                    }
                }

                
                else if (opcionPrueba == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("PRUEBA: " + PRUEBA_2);
                    Console.WriteLine("1. Triángulo");
                    Console.WriteLine("2. Estrella");
                    Console.WriteLine("3. Sombrilla");

                    Console.Write("Elige una figura: ");
                    decision = int.Parse(Console.ReadLine());

                    if (decision == 1)
                    {
                        Console.WriteLine("Figura fácil.");
                        puntaje = puntaje + 40;
                        estadoFinal = ESTADO_VIVO;
                    }
                    else if (decision == 2)
                    {
                        Console.WriteLine("Figura difícil.");
                        
                        
                        Console.Write("¿Usas la aguja calentada? (1 = Si / 2 = No): ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            Console.WriteLine("Buena decisión.");
                            puntaje = puntaje + 80;
                            estadoFinal = ESTADO_VIVO;
                        }
                        else
                        {
                            Console.WriteLine("No superaste la prueba.");
                            estadoFinal = ESTADO_FUERA;
                        }
                    }
                    else if (decision == 3)
                    {
                        Console.WriteLine("La sombrilla es muy difícil.");
                        puntaje = puntaje + 40;
                        estadoFinal = ESTADO_VIVO;
                    }
                    else
                    {
                        Console.WriteLine("Figura inválida.");
                        estadoFinal = ESTADO_FUERA;
                    }
                }


                else if (opcionPrueba == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("PRUEBA: " + PRUEBA_3);
                    Console.WriteLine("1. Tirar todos al mismo tiempo");
                    Console.WriteLine("2. Tirar cuando el equipo contrario se distraiga");
                    Console.WriteLine("3. No hacer nada");

                    Console.Write("Elige una estrategia: ");
                    decision = int.Parse(Console.ReadLine());

                    if (decision == 2)
                    {
                        Console.WriteLine("¡Buena estrategia!");
                        puntaje = puntaje + 60;
                        estadoFinal = ESTADO_VIVO;
                    }
                    else
                    {
                        Console.WriteLine("Estrategia incorrecta.");
                        estadoFinal = ESTADO_FUERA;
                    }
                }

                else
                {
                    Console.WriteLine("Prueba inválida.");
                    estadoFinal = ESTADO_FUERA;
                }
            }
            else
            {
                Console.WriteLine("No tienes la edad mínima.");
                estadoFinal = ESTADO_FUERA;
            }

            
            if (puntaje >= 90)
            {
                clasificacion = "EXCELENTE";
            }
            else if (puntaje >= 60)
            {
                clasificacion = "BUENO";
            }
            else if (puntaje >= 30)
            {
                clasificacion = "REGULAR";
            }
            else
            {
                clasificacion = "BAJO";
            }

            
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("       REPORTE FINAL");
            Console.WriteLine("=================================");
            Console.WriteLine("Nombre: " + jugadorElegido);
            Console.WriteLine("Número: 00" + numeroJugador);
            Console.WriteLine("Puntaje: " + puntaje);
            Console.WriteLine("Estado: " + estadoFinal);
            Console.WriteLine("Clasificación: " + clasificacion);

            if (estadoFinal == ESTADO_VIVO)
            {
                Console.WriteLine("Premio: Bs " + PREMIO_TOTAL);
            }
            else
            {
                Console.WriteLine("Premio: Bs 0");
            }

            Console.WriteLine("=================================");
        }
    }
}
