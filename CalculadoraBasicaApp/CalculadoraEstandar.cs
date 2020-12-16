using System;
using Calculos;

namespace CalculadoraEstandarApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CALCULADORA PERSONAL");
            Console.WriteLine("Presiona  ENTER para continuar");


            var reintentar = Console.ReadLine();

            while (reintentar != "no")
            {
                Console.WriteLine("Que operacion desea realizar");
                Console.WriteLine("+");
                Console.WriteLine("-");
                Console.WriteLine("*");
                Console.WriteLine("/");
                Console.WriteLine("Inversa");
                Console.WriteLine("Raiz");
                Console.WriteLine("Potencia");

                var operacion = Console.ReadLine();


                if (operacion == "+")
                {
                    Console.WriteLine("Ingrese primer número");
                    var primerNumero1 = Console.ReadLine();
                    Console.WriteLine("Ingrese segundo número");
                    var segundoNumero2 = Console.ReadLine();
                    var calculadora = new Logica();
                    var resultado = calculadora.Sumar(int.Parse(primerNumero1), int.Parse(segundoNumero2));

                    Console.WriteLine("El resultado es: " + resultado);
                }

                if (operacion == "-")
                {
                    Console.WriteLine("Ingrese primer número");
                    var primerNumero1 = Console.ReadLine();
                    Console.WriteLine("Ingrese segundo número");
                    var segundoNumero2 = Console.ReadLine();
                    var calculadora = new Logica();
                    var resultado = calculadora.Restar(int.Parse(primerNumero1), int.Parse(segundoNumero2));
                    Console.WriteLine("El resultado es: " + resultado);

                }

                if (operacion == "*")
                {
                    Console.WriteLine("Ingrese primer número");
                    var primerNumero = Console.ReadLine();
                    Console.WriteLine("Ingrese segundo número");
                    var segundoNumero = Console.ReadLine();
                    var calculadora = new Logica();
                    var resultado = calculadora.Multiplicar(int.Parse(primerNumero), int.Parse(segundoNumero));
                    Console.WriteLine("El resultado es: " + resultado);
                }

                if (operacion == "/")
                {
                    Console.WriteLine("Ingrese primer número");
                    var primerNumero = Console.ReadLine();
                    Console.WriteLine("Ingrese segundo número");
                    var segundoNumero = Console.ReadLine();
                    var calculadora = new Logica();
                    var resultado = calculadora.Dividir(int.Parse(primerNumero), int.Parse(segundoNumero));
                    Console.WriteLine("El resultado es: " + resultado);

                }


                if (operacion == "Inversa")
                {
                    Console.WriteLine("Ingresa el número que deseas");
                    var numero = Console.ReadLine();
                    var calculadora = new Logica();
                    var resultado = calculadora.Inversa(double.Parse(numero));
                    Console.WriteLine("El resultado de la operación es: " + resultado);

                }


                if (operacion == "Raiz")
                {
                    Console.WriteLine("Ingrese el número que deseas");
                    var numero = Console.ReadLine();
                    var calculadora = new Logica();
                    var resultado = calculadora.Raiz(double.Parse(numero));
                    Console.WriteLine("El resultado de la operación es: " + resultado);

                }


                if (operacion == "Potencia")
                {
                    Console.WriteLine("Ingrese el número que quieres");
                    var numero = Console.ReadLine();
                    var calculadora = new Logica();
                    var resultado = calculadora.Potencia(int.Parse(numero));
                    Console.WriteLine("El resultado de la operación es: " + resultado);

                }


                Console.WriteLine("Desea realizar otra operación");
                reintentar = Console.ReadLine();
                Console.Clear();
            }



        }
    }
}





