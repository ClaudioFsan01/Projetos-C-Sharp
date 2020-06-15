using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    class ManipularVetores
    {

        public void criarVetorInteiros()
        {
            /* Console.WriteLine(" Informe o tamanho do vetor de inteiros : \n");
             int n = int.Parse(Console.ReadLine());*/

            //int[] vetorInteiros = new int[n];
            //ou 

            int[] vetorInteiros = new int[] { 2, 4, 8, 60, 13, 24 };
            /*
            for (int i=0; i<n; i++)
            {
                Console.WriteLine(" Entre com um valor do tipo inteiro : \n");
                vetorInteiros[i] = int.Parse(Console.ReadLine());
            }
            */
            Console.WriteLine(" Dados no vetor de interios !\n");

            for (int i = 0; i < vetorInteiros.Length; i++)
            {
               
                Console.WriteLine(vetorInteiros[i]);
            }


        }

        public void criarVetorDouble()
        {
            Console.WriteLine(" Informe o tamanho do vetor de double : \n");
            int n = int.Parse(Console.ReadLine());

            double[] vetorDouble = new double[n];

            for (int i = 0; i < vetorDouble.Length; i++)
            {
                Console.WriteLine(" Entre com um valor do tipo double : \n");
                vetorDouble[i] = double.Parse(Console.ReadLine());
            }


            Console.WriteLine(" Dados no vetor de double !\n");


            for (int i = 0; i < vetorDouble.Length; i++)
            {
                Console.WriteLine(vetorDouble[i]);
            }

        }

        public void criarVetorString()
        {
            Console.WriteLine(" Informe o tamanho do vetor de String : \n");
            int n = int.Parse(Console.ReadLine());

            String[] vetorString = new String[n];

            for (int i = 0; i < vetorString.Length; i++)
            {
                Console.WriteLine(" Entre com um valor do tipo String : \n");
                vetorString[i] = Console.ReadLine();
            }
            Console.WriteLine(" Dados no vetor de String !\n");

            for (int i = 0; i < vetorString.Length; i++)
            {
                
                Console.WriteLine(vetorString[i]);
                Console.WriteLine("\n");

            }
        }



    }
}
