using System;

namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero naturale: ");
            int n=Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine($"{n} non è un numero naturale!");
            }
            else
            {
                Console.WriteLine($"{n} è un numero naturale\n");
            }
            //Esercizio1();
            //Esercizio2();
            //Esercizio3();
            Esercizio4();
        }
        private static void Esercizio1()
        {
            for (int i = 2; i <= 200; i+=2)
            {               
                    Console.WriteLine(i);                
            }
        }

        private static void Esercizio2()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Inserisci un numero naturale: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine($"\n{n} non è un numero naturale!");
                }
            } while (n < 0);

            int n_ingr = n;
            if (n > 0)
            {
                Console.Write($"{n}! = {n}");
                for (int i = (n - 1); i > 0; i--)
                {
                    Console.Write($"*{i}");
                    n *= i;
                }
                Console.WriteLine($"\nIl numero fattoriale di {n_ingr} è {n}");
            }
            else if (n == 0)
            {
                Console.WriteLine("\nIl numero fattoriale di 0 è 1");
            }
        }


        private static void Esercizio3()
        {
            Console.WriteLine("Inserisci un numero naturale: ");
            string binario= Console.ReadLine()!;
            double decimale=0;
            double pos = binario.Length - 1;
            int n = 0;
            for(int i=0; i<binario.Length; i++)
            {
                n = Convert.ToInt32(binario[i] - '0');
                decimale += n* Math.Pow(2, pos);
                pos -= 1;
            }
            Console.WriteLine($"{binario} = {decimale} ");
        }
        private static void Esercizio4()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Inserisci un numero naturale: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine($"\n{n} non è un numero naturale!");
                }
            } while (n < 0);

            //vettore fiboacci
            int[] fibonacci = new int[n+1];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i <= n; i++) 
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            for(int i = 0; i<=n ; i++)
            {
                Console.Write($"{fibonacci[i]} - ");
            }
            Console.WriteLine($"\nfibonacci({n})--->{fibonacci[n]}");
            




        }
    }
    
}
