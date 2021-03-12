using System;
using library_IMC;

namespace IMCclasse
{
    class Program
    {
        public static float IMC(float altura, float peso)
        {
            return (peso/(altura*altura));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o Peso: ");
            float ps = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a altura: ");
            float al = float.Parse(Console.ReadLine());
            float resultado = IMC(al, ps);
            Console.WriteLine($"O seu IMC é: {resultado}");
            Console.WriteLine(libary_IMC.R_IMC(resultado));
        }
    }
}
