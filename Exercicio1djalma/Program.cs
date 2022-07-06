using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double media, trabalho, prova1,prova2;
            string nome;


            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();


            Console.Write("Digite a nota do seu trabalho: ");
            trabalho = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota da sua prova 1: ");
            prova1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota da sua prova 2: ");
            prova2 = Convert.ToDouble(Console.ReadLine());

            media = (trabalho + prova1 + prova2) / 3;



            Console.WriteLine("\n\nA sua nota final é: " + media);

         
            if (media >= 8.5)

            {

                Console.WriteLine("O seu conceito é: A");

            }

            else if (media >= 7)

            {

                Console.WriteLine("O seu conceito é: B");
                    
            }

            else if(media >= 6)

            {

                Console.WriteLine("O seu conceito é: C");

            }


            else if (media >= 0.1)

            {

                Console.WriteLine("O seu conceito é: D");

            }

            else

            {

                Console.WriteLine("O seu conceito é: E");

            }



            Console.Write("\n\n--------------------- PRESSIONE QUALQUER TECLA PARA SAIR --------------------");

            Console.ReadKey();
        }
    }
}
