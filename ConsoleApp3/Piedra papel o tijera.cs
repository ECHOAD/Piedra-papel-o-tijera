// Piedra papel o tijera
using System;

namespace PiedraPapelOTijera
{
    class PiedraPapelOTijera
    {
        // funcion de practica , no obligatoria 
        static void decision(int jugada_del_ordenador, int jugada_del_usuario)
        {
            if (jugada_del_ordenador == 1)
                Console.WriteLine("La jugada del ordenador es Piedra");
            if (jugada_del_ordenador == 2)
                Console.WriteLine("La jugada del ordenador es Papel");
            if (jugada_del_ordenador == 3)
                Console.WriteLine("La jugada del ordenador es Tijera");
            if (jugada_del_usuario == jugada_del_ordenador)
                Console.WriteLine("Empate");
            if ((jugada_del_usuario == 1 && jugada_del_ordenador == 3) || (jugada_del_usuario == 2 && jugada_del_ordenador == 1) || (jugada_del_usuario == 3 && jugada_del_ordenador == 2))
                Console.WriteLine("Gana usuario");
            if ((jugada_del_usuario == 3 && jugada_del_ordenador == 1) || (jugada_del_usuario == 1 && jugada_del_ordenador == 2) || (jugada_del_usuario == 2 && jugada_del_ordenador == 3))
                Console.WriteLine("Gana ordenador");
            
            Console.WriteLine("Valor de jugada del ordenador: " + jugada_del_ordenador);
            Console.WriteLine();
            Console.Write("Presione una tecla para terminar");
            Console.ReadKey();
        }


        // Se pudiera hacer una condicion para hacerlo jugador contra jugador || jugador contra ordenador ; al final agregando una condicion de salida para que no se un bucle infinito


        //recolectar datos del juego
        static void Main(string[] args)
        {
            int b, a;
            Random rand = new Random();
            Console.WriteLine("Seleccione el valor de jugada del usuario.");
            Console.WriteLine("\t1.- Piedra");
            Console.WriteLine("\t2.- Papel");
            Console.WriteLine("\t3.- Tijera");
            Console.Write("\t: ");
            do
            {
                a = int.Parse(Console.ReadLine());
                if (a<1||a>3)
                    Console.Write("Valor incorrecto. Ingreselo nuevamente.: ");
            } while (a<1|| a>3);
            b=1+rand.Next(3);

            //llamando a la funcion con los valore dados 
            decision(b,a);
           
          
        }
    }
}

