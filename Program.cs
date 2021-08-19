using System;
//Elabore una aplicación que pida el nombre de una persona y evalué que sea
//mayor de edad, para continuar pidiendo los demás datos personales
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una conversion");
            Console.WriteLine("1. ºC  a  ºF");
            Console.WriteLine("2. ºF  a  ºC");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Ingresa grados centigrados");
                double c = Convert.ToDouble(Console.ReadLine());
                double f = (c * 9 / 5) + (32);
                Console.WriteLine(c + "ºC equivale a " + f + "ºF");
            }
            else
            {
                Console.WriteLine("Ingresa grados fahrenheit");
                double f = Convert.ToDouble(Console.ReadLine());
                double c = (f - 32) * 5 / 9;
                Console.WriteLine(f + "ºF equivale  a " + c + "ºC");
            }
            Console.ReadLine();
        }
    }
}
