using System;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, \n1. Calculadora de operaciones basicas.\n" +
                "2. Utilidades de texto.\n3. Otras utilidades.");
            Console.Write("Elige una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa un numero: ");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.Write("Ingresa otro numero: ");
                    int n2 = int.Parse(Console.ReadLine());

                    Console.Write("¿Que deseas hacer? (+,-,*,/,%, exit): ");
                    string ope = Console.ReadLine();

                    switch (ope)
                    {
                        case "+":
                            int suma = n1 + n2;
                            Console.Write($"Suma: {n1}+{n2} = " + suma);
                            break;
                        case "-":
                            int resta = n1 - n2;
                            Console.Write($"Resta: {n1}-{n2} = " + resta);
                            break;
                        case "*":
                            int multi = n1 * n2;
                            Console.Write($"Multiplicacion: {n1}+{n2} = " + multi);
                            break;
                        case "/":
                            int divi = n1 + n2;
                            Console.Write($"Division: {n1}/{n2} = " + divi);
                            break;
                        case "%":
                            int resi = n1 + n2;
                            Console.Write($"Residual: {n1}%{n2} = " + resi);
                            break;
                        case "exit":
                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("1. Cambiar texto a mayusculas. \n" +
                        "2. Cambiar texto a minusculas. \n" +
                        "3. Reemplazar alguna palabra del texto. ");

                    Console.Write("Ingresa una opcion: ");
                    int texto = int.Parse(Console.ReadLine());

                    switch (texto)
                    {
                        case 1:
                            Console.Write("Ingresa tu texto: ");
                            string texto1 = Console.ReadLine();
                            Console.Write($"Tu texto: {texto1}-----> {texto1.ToUpper()}");
                            break;
                        case 2:
                            Console.Write("Ingresa tu texto: ");
                            string texto2 = Console.ReadLine();
                            Console.Write($"Tu texto: {texto2}-----> {texto2.ToLower()}");
                            break;
                        case 3:
                            Console.Write("Ingresa tu texto: ");
                            string texto3 = Console.ReadLine();
                            Console.Write("Que palabra deseas reemplazar: ");
                            string p1 = Console.ReadLine();
                            Console.Write("Nueva palabra para reemplazar: ");
                            string p2 = Console.ReadLine();

                            if (texto3.Contains(p1))
                            {
                                Console.WriteLine();

                                string textoMod = texto3.Replace(p1, p2);
                                Console.Write($"Texto modificado: {textoMod}");
                            }
                            else
                            {
                                Console.WriteLine($"El texto escrito anteriormente no contiente '{p1}' ");
                            }
                            break;

                    }
                    break;
                case 3:
                    
                    Console.WriteLine("1. Contar las veces de una palabra. ");
                    Console.WriteLine("2. Contar caracteres de una palabra. ");

                    Console.Write("elige una opcion: ");
                    int utilidad=int.Parse(Console.ReadLine());
                    switch (utilidad)
                    {
                        case 1:
                            Console.Write("Ingresa el texto: ");
                            string contador = Console.ReadLine();

                            Console.Write("Que palabra deseas encontrar: ");
                            string palabraBuscada = Console.ReadLine();
                      
                            int conteo = 0;

                            for (int j = 0; j < contador.Length - palabraBuscada.Length + 1; j++)
                            {
                                if (contador.Substring(j, palabraBuscada.Length).Equals(palabraBuscada, StringComparison.OrdinalIgnoreCase))
                                {
                                    conteo++;
                                }
                            }

                            Console.WriteLine($"La palabra '{palabraBuscada}' aparece {conteo} veces en el texto.");
                            break;
                        case 2:
                            Console.Write("Ingresa un texto: ");
                            string texto4 = Console.ReadLine();

                            int longitud = 0; 

                            int i = 0;

                            while (i < texto4.Length)
                            {
                                if (texto4[i] != ' ')
                                {
                                    longitud++; 
                                }

                                i++;
                            }

                            Console.WriteLine($"La longitud del texto sin contar espacios es: {longitud}");
                            break;
                    }
                    
                    break;
            }

        }
    }
}
