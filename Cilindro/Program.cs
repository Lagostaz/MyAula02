using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variáveis
            string alturaS, raioS;
            float alturaF, raioF;
            float volume, area;
            float pi = 3.1415926f;

            //pedir a altura
            Console.WriteLine("Introduza a altura");
            alturaS = Console.ReadLine();

            //converter a altura em float 
            alturaF = Convert.ToSingle(alturaS);

            //pedir o raio 
            Console.WriteLine("Introduza o raio");
            raioS = Console.ReadLine();

            //converter o raio em float
            raioF = Convert.ToSingle(raioS);

            //calcular o volume 
            volume = pi * raioF * raioF * alturaF;

            //carcular a area superficial 
            area = 2 * pi * raioF * (raioF + alturaF);

            //apresentar os resultados 
            Console.WriteLine($"Volume = {volume:f3}");
            Console.WriteLine("Área Sup. = {0:f3}",area);

        }
    }
}
