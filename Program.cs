using System;

namespace codigo_arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int vec;
            Console.WriteLine("tamaño de el arreglo");
            vec = int.Parse(Console.ReadLine();
            int[] arr = new int[vec];

            Console.WriteLine("selecciona una opcion");
            float opc = float.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("intercambiar");
                    break;
                case 2:
                    Console.WriteLine("mayor a menor");
                    break;
                case 3:
                    Console.WriteLine("creciente");
                    break;
                case 4:
                    Console.WriteLine("numeros repetidos");
                    break;
                case 5:
                    Console.WriteLine("ordenar de mayor a menor");
                    break;
                case 6:
                    Console.WriteLine("el numero esta en la lista?");
                    break;
                case 7:
                    Console.WriteLine("promedio de los elementos");
                    break;
                Default:
                    Console.WriteLine("no");

            }
            Console.ReadKey();
        }
    }
}