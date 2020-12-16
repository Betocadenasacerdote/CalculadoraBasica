using System;

namespace Calculos
{
    public class Logica
    {

        public int Sumar(int primerNumero, int segundoNumero)
        {
            return primerNumero + segundoNumero;
        }

        public int Restar(int primerNumero, int segundoNumero)
        {
            return primerNumero - segundoNumero;
        }
        public int Multiplicar(int primerNumero, int segundoNumero)
        {
            return primerNumero * segundoNumero;
        }
        public int Dividir(int primerNumero, int segunNumero)
        {
            return primerNumero / segunNumero;
        }
        public double Inversa(double numero)
        {
            return 1 / numero;
        }
        public double Raiz(double numero)
        {
            return Math.Sqrt(numero);
        }
        public int Potencia(int numero)
        {

            return numero * numero;
        }
    }
}
