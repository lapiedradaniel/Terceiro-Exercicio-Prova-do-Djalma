using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terceiro_Exercicio_Prova_do_Djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            string figura = null;
            Console.WriteLine("Digite o codigo referente a figura que deseje calcular !");
            Console.WriteLine("1-Triangulo" + "\t" + "2-Losangolo" + "\t" + "3-Trapézio");
            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    figura = "Triangulo";
                    break;
                case 2:
                    figura = "Losangolo";
                    break;
                case 3:
                    figura = "Trapézio";
                    break ;
            }
            if (figura == "Triangulo")
            {
                Console.WriteLine("Digite o valor da Altura do Triangulo");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor da Base do Triangulo");
                double b = Convert.ToDouble(Console.ReadLine());

                double area = (h * b) / 2;
                Console.WriteLine("A area do Triangulo é: " + area);    
            }
            if (figura == "Losangolo")
            {
                Console.WriteLine("Digite o valor da Diagonal Maior do Losangolo");
                double diagonalmaior = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor da Diagonal Menor do Losangolo");
                double diagonalmenor = Convert.ToDouble(Console.ReadLine());

                double area = (diagonalmaior * diagonalmenor) /2 ;
                Console.WriteLine("A area do Losangolo é: " + area);
            }
            else if (figura == "Trapézio")
            {
                Console.WriteLine("Digite o valor da Base Maior do Trapézio");
                double basemaior = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor da Base Menor do Trapézio");
                double basemenor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor da Altura do Trapézio");
                double altura = Convert.ToDouble(Console.ReadLine());   

                double area = ((basemaior + basemenor) * altura) / 2 ;
                Console.WriteLine("A area do trapezio é: " + area);

    
            }

            Console.ReadKey();
        }
    }
}
