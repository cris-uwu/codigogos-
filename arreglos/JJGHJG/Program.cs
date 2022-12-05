using System;

namespace codigos
{
        class Program
    {
        static void Main(string[] args)
        {


          


            int opcion, X = 0, aux = 0;
float prom, Z;
int[] numeros = new int[5];
int[] arrayAux = new int[5];


numeros = llenarNumeros();

Console.Clear();

do
{

    opciones();
    opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcion)
    {

        case 1:

            numeros = regresarInv(numeros);

            mostrarArray(numeros);

            
            break;

        case 2:
            X = 0;
            for (int i = 1; i < 5; i++)
            {
                aux = numeros[i - 1];

                if (aux > numeros[i])
                {
                    X++;
                }

            }

            if (X > 0)
            {
                Console.WriteLine("no esta ordenada de menor a mayorr");
            }
            else
            {
                Console.WriteLine("si esta pordenada de menor a mayor");
            }
    
            
            break;


        case 3:
            X = 0;
            for (int i = 1; i < 5; i++)
            {
                aux = numeros[i - 1];

                if (aux > numeros[i])
                {
                    X++;
                }

            }

            if (X > 0)
            {
                Console.WriteLine("no esta ordenada la lista");
            }
            else
            {
                Console.WriteLine("si esta ordenada la lista");
            }
         
            
            break;

        case 4:
            X = 0;
            for (int i = 0; i < 5; i++)
            {
                aux = numeros[i];
                for (int j = 0; j < 5; j++)
                {

                    if (aux == numeros[j] && j != i)
                    {
                        X++;
                    }
                }
            }

            if (X != 0)
            {
                Console.WriteLine("si se repite");
            }
            else
            {
                Console.WriteLine("no esta el numero en la lista");
            }

            
            break;


        case 5:

            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    aux = numeros[j - 1];
                    if (aux > numeros[j])
                    {
                        aux = numeros[j];
                        numeros[j] = numeros[j - 1];
                        numeros[j - 1] = aux;
                    }
                }
            }


            mostrarArray(numeros);
            
            break;


        case 6:
            Console.Write("numero para comparar ");
            aux = int.Parse(Console.ReadLine());
            X = 0;
            for (int i = 0; i < 5; i++)
            {

                if (aux == numeros[i])
                {
                    X++;
                }
            }

            if (X > 0)
            {
                Console.WriteLine("el numero si esta");
            }
            else
            {
                Console.WriteLine("el numero no esta");
            }

            
            break;

        case 7:
            Z = 0;
            for (int i = 0; i < 5; i++)
            {

                Z = Z + numeros[i];

            }
            prom = Z / 5;

            Console.WriteLine("el promedio es " + prom);

           
            break;


        default:
            Console.WriteLine("no esta");

            break;

    }
    Console.ReadKey();
} while (opcion != 9);


        }

        public static void opciones()
{
    Console.Clear();
    Console.WriteLine("elegir opcion");

    Console.WriteLine("1 intercambiar");

    Console.WriteLine("2 mayor a menor");

    Console.WriteLine("3 mayor a menor");

    Console.WriteLine("4 numeros repetidos");

    Console.WriteLine("5 ordenar de mayor a menor");

    Console.WriteLine("6 el numero esta en la lista?");

    Console.WriteLine("7 promedio de los elementos");


}

public static void mostrarArray(int[] array)
{

    for (int i = 0; i < 5; i++)
    {
        Console.Write(" " + array[i]);
    }

}

public static int[] llenarNumeros()
{
    int[] numero = new int[5];
    Console.WriteLine("Ingrese 5 numeros: \n");

    for (int i = 1; i < 6; i++)
    {

        Console.Write("Ingrese el " + i + " numero: ");
        numero[i - 1] = int.Parse(Console.ReadLine());

    }

    return numero;
}





public static int[] regresarInv(int[] array)
{
    int[] auxArray = new int[10];
    int Y = 0;
    for (int i = 9; i > -1; i--)
    {
     
        Y++;
    }
    return auxArray;


}

    }
}
