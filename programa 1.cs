using System;

namespace ProgramasAlgoritmos1
{
    internal class Program
    {
        int[] num = new int[5];
        static void Main(string[] args)           
        {
            int[] num = new int[5];

            num[0] = 1;
            num[1] = 3;
            num[2] = 3;
               

            //escribir el nombre de los codigos
            Console.WriteLine("Seleccione el codigo que prefieras ");
            Console.WriteLine("Intercambiar los elementos de un vector (1)");
            Console.WriteLine("Averiguar si la lista de numeros esta ordenada de mayor a menor (2)");
            Console.WriteLine("Averiguar si una lista de numeros esta ordenada de manera estrictamente creciente (3)");
            Console.WriteLine("Averigue si la lista contiene numeros repetidos (4)");
            Console.WriteLine("Ordenar de mayor a menor los elementos de una lista (5)");
            Console.WriteLine("averigue si el numero T esta en la lista (6)");
            Console.WriteLine("Halle el promedio de los elementos de un vector (7)");
            
            float selec = float.Parse(Console.ReadLine());
          //inicio del SWITCH 
            switch (selec)
            {
                
                case 1:  
                    Console.Clear();
                    Console.WriteLine("Seleccionaste Intercambiar los elementos de un vector ");
                    Console.WriteLine("Ingresa el vector");
                    string vec = Console.ReadLine();
                    int i = vec.Length - 1;
                    string help = "";
                    while (i >= 0)
                    {
                        help = help + "" + vec[i];
                        i = 1 - 1;
                    }
                    Console.WriteLine("el n umero al reves: " + help);
                    Console.ReadKey();
                    break;
                //segundo codigo
                case 2:
                    Console.Clear();
                    Console.WriteLine("Seleccionaste Averiguar si la lista de numeros esta ordenada de mayor a menor ");

                    if (num[0] < num[1] && num[0] < num[2])
                    {
                        if (num[1] < num[2])
                        {
                            Console.WriteLine(num[0]);
                            Console.WriteLine(num[1]);
                            Console.WriteLine(num[2]);

                        }
                        else
                        {
                            Console.WriteLine(num[0]);
                            Console.WriteLine(num[2]);
                            Console.WriteLine(num[1]);

                        }                                           
                    }
                    if (num[1] < num[0] && num[1] < num[2])
                    {
                        if (num[0] < num[2])
                        {
                            Console.WriteLine(num[1]);
                            Console.WriteLine(num[0]);
                            Console.WriteLine(num[2]);
                        }
                        else
                        {
                            Console.WriteLine(num[1]);
                            Console.WriteLine(num[2]);
                            Console.WriteLine(num[0]);
                        }
                    if (num[2] < num[0] && num[2] < num[1])
                        {
                            if (num[0] < num[1])
                            {
                                Console.WriteLine(num[2]);
                                Console.WriteLine(num[0]);
                                Console.WriteLine(num[1]);
                            }
                            else
                            {
                                Console.WriteLine(num[2]);
                                Console.WriteLine(num[1]);
                                Console.WriteLine(num[0]);

                            }
                            Console.ReadKey();

                            }
                        }
                    
            break;
                //tercer codigo
                case 3:
                    Console.Clear();
                    Console.WriteLine("Seleccionaste Averiguar si una lista de numeros esta ordenada de manera estrictamente creciente");
                    if (num[0] < num[1] && num[0] < num[2])
                    {
                        if (num[1] > num[2])
                        {
                            Console.WriteLine(num[0]);
                            Console.WriteLine(num[1]);
                            Console.WriteLine(num[2]);
                        }
                        else
                        {
                            Console.WriteLine(num[0]);
                            Console.WriteLine(num[2]);
                            Console.WriteLine(num[1]);
                        }
                    }
                    if (num[1] < num[0] && num[1] < num[2])
                    {
                        if (num[0] > num[2])
                        {
                            Console.WriteLine(num[1]);
                            Console.WriteLine(num[0]);
                            Console.WriteLine(num[2]);
                        }
                        else
                        {
                            Console.WriteLine(num[1]);
                            Console.WriteLine(num[2]);
                            Console.WriteLine(num[0]);
                        }
                    }
                    Console.ReadKey ();
                                         
                    break;
                //cuarto codigo
                case 4:
                    Console.Clear();
                    Console.WriteLine("Seleccionaste Averigue si la lista contiene numeros repetidos");
                    if (num[0] == num[1])
                    {
                        Console.WriteLine("la lista si contiene numeros repetidos y es: " + num[0]);
                    }    
                    if (num[1] == num[2])
                    {
                        Console.WriteLine("la lista si contiene numeros repetidos y es: " + num[1]);
                    }
                    if (num[2] == num[0])
                    {
                        Console.WriteLine("la lista so contiene numeros repetidos y es: " + num[2]);
                    }
                    else
                    {
                        Console.WriteLine("La lista no contiene nigun numero repetido");
                    }
                    break;
                //quinto codigo
                case 5:
                    Console.Clear();
                    Console.WriteLine("Seleccionaste Ordenar de mayor a menor los elementos de una lista ");
                    if (num[0] < num[1] && num[0] < num[2])
                    {
                        if (num[1] > num[2])
                        {
                            Console.WriteLine("El orden correcto de la lista es: ");
                            Console.WriteLine(num[0]);
                            Console.WriteLine(num[1]);
                            Console.WriteLine(num[2]);
                        }
                        else
                        {
                            Console.WriteLine("El orden correcto de la lista es: ");
                            Console.WriteLine(num[0]);
                            Console.WriteLine(num[2]);
                            Console.WriteLine(num[1]);
                        }
                    }
                    if (num[1] < num[0] && num[1] < num[2])
                    {
                        if (num[0] > num[2])
                        {
                            Console.WriteLine("El orden correcto de la lista es: ");
                            Console.WriteLine(num[1]);
                            Console.WriteLine(num[0]);
                            Console.WriteLine(num[2]);
                        }
                        else
                        {
                            Console.WriteLine("El orden correcto de la lista es: ");
                            Console.WriteLine(num[1]);
                            Console.WriteLine(num[2]);
                            Console.WriteLine(num[0]);
                        }
                        
                    }
                    if (num[2] < num[0] && num[2] < num[1])
                    {
                        if (num[0] < num[1])
                        {
                            Console.WriteLine("El orden correcto de la lista es: ");
                            Console.WriteLine(num[2]);
                            Console.WriteLine(num[0]);
                            Console.WriteLine(num[1]);
                        }
                    }
                    break;
                //sexto codigo
                case 6:
                    Console.Clear();
                    Console.WriteLine("seleccionaste Averigue si el numero T esta en la lista");
                    Console.WriteLine("Ingresa el numero que deseas buscar");
                    float n = float.Parse(Console.ReadLine());
                    if (num[0] == n)
                    {
                        Console.WriteLine("El numero si se encuentra en la lista: " + n);
                    }
                    if (num[1] == n)
                    {
                        Console.WriteLine("El numero si se encuentra en la lista" + n);
                    }
                    if (num[2] == n)
                    {
                        Console.WriteLine("El numero si se encuentra en la lista" + n);
                    }
                    else
                    {
                        Console.WriteLine("El numero que ingresaste no esta en la lista");
                    }
                    Console.ReadKey();
                    break;
                //Septimo codigo
                case 7:
                    Console.Clear();
                    Console.WriteLine("Seleccionaste Halle el promedio de los elementos de un vector ");
                    Console.WriteLine("El promedio es: " + (num[0] + num[1] + num[2])/3);

                    Console.ReadKey();
                    break;
                
                default:
                    Console.WriteLine("Opcion incorrecta");
                    Console.ReadKey();

                    break;               
            }
   
        }
          
    }
}
