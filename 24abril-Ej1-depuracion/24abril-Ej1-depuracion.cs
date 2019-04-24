using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero
            int num1 = 0; int num2 = 0;

            // Display title as the C# console calculator app
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number
            Console.WriteLine("Introduce un número");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the second number
            Console.WriteLine("Introduce otro número");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option
            Console.WriteLine("Elige la operación a realizar: ");
            Console.WriteLine("\ta - Sumar");
            Console.WriteLine("\ts - Restar");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.WriteLine("\te - Cuadrado del número mayor");
            {
                Boolean ok = false;
                do
                {
                    Console.Write("¿Cuál es tu opción? ");
                    // Use a switch statement to do the math
                    switch (Console.ReadLine())
                    {
                        case "a":
                            Console.WriteLine("El resultado es = " + (num1 + num2));
                            ok = true;
                            break;
                        case "s":
                            Console.WriteLine($"El resultado de: {num1} - {num2} = " + (num1 - num2));
                            ok = true;
                            break;
                        case "m":
                            Console.WriteLine($"El resultado de: {num1} * {num2} = " + (num1 * num2));
                            ok = true;
                            break;
                        case "d":
                            Console.WriteLine($"El resultado de: {num1} / {num2} = " + (num1 / num2));
                            ok = true;
                            break;
                        case "e":
                            if (num1 >= num2)
                            {
                            Console.WriteLine($"El cuadrado del número mayor es = " + (num1 * num1));
                            }
                            else { Console.WriteLine("El cuadrado del número mayor es = " + (num2 * num2));}
                            ok = true;
                            break;
                    }
                } while (ok == false);

            }
            // Wait for the user to respond before closing
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}



