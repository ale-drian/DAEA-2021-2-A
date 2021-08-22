using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] División de dos números");
                Console.WriteLine("[6] Imprimir los 10 primeros primos");
                Console.WriteLine("[7] Convertir temperatura");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Suma(a, b);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Resta(a, b);
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Multiplicacion(a, b);
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Division(a, b);
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando...");
                        ImprimirPrimos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese los grados [C] para Celsius y [F] para Fahrenheit");
                        string escala = Console.ReadLine();
                        Console.WriteLine("Ingrese la temperatura");
                        int temperatura = Convert.ToInt32(Console.ReadLine());
                        convertirTemperatura(escala, temperatura);
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }
        //Función para calcular la suma de 2 números enteros
        static void Suma(int a, int b)
        {
            int suma = a + b;
            Console.WriteLine("La suma de {0} y {1} es {2}", a, b, suma);
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        //Función para calcular la resta de 2 números enteros
        static void Resta(int a, int b)
        {
            int resta = a + b;
            Console.WriteLine("La resta de {0} y {1} es {2}", a, b, resta);
        }

        //Función para calcular la multiplicacion de 2 números enteros
        static void Multiplicacion(int a, int b)
        {
            int multiplicacion = a * b;
            Console.WriteLine("La multiplicacion de {0} y {1} es {2}", a, b, multiplicacion);
        }

        //Función para calcular la division de 2 números enteros
        static void Division(int a, int b)
        {
            if (b != 0)
            {
                double division = a / b;
                Console.WriteLine("La division entre {0} y {1} es {2}", a, b, division);
            }
            else 
            {
                Console.WriteLine("La division entre 0 no es posible");
            }
        }

        //Funcion para validar si un numero es primo
        static bool esPrimo(int n)
        {
            if (n < 2) {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //Procedimiento que imprime los 10 primeros números primos
        static void ImprimirPrimos() 
        {
            int primo = 0;
            int contador = 0;
            while (contador < 10) {
                if (esPrimo(primo)) {
                    contador++;
                    Console.WriteLine($"El primo N° '{contador}' es '{primo}'");
                }
                primo++;
            }
        }

        //Procedimiento que imprime los 10 primeros números primos
        static void convertirTemperatura(String escala, int temperatura)
        {
            switch (escala)
            {
                case "C":
                    double gradosF = 9 * temperatura / 5 + 32;
                    Console.WriteLine($"'{temperatura}' °C equivale a '{gradosF}'°F");
                    break;
                case "F":
                    double gradosC = 5 * (temperatura - 32) / 9;
                    Console.WriteLine($"'{temperatura}' °F equivale a '{gradosC}'°F");
                    break;
            }
            
        }

    }
}
