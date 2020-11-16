using System;

namespace atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do salário ");
            int salário = int.Parse(Console.ReadLine());

           
            if(salário<500){
                Console.WriteLine("Você tem o direito de reajuste no salário de 30%!");

                
            }
            else{
                Console.WriteLine("Você não tem direito ao aumento!");
            }

            }
        }
    }
}
