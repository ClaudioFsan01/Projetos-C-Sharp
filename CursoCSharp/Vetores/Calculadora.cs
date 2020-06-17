//Modificador de Parametros params 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    class Calculadora
    {
        /*
       public static int Sum(int num1, int num2)
       {
            return num1 + num2;
       }

        public static int Sum(int num1, int num2, int num3) 
        {
            return num1 + num2 + num3;
        }*/

        //ou  Modificador de Parametros params usando vetor 
        //ex 

        /* utilizando o modificador de parametros (params) passa a não ser mais necessario criar uma instancia 
         do tipo vetor na hora de chamar a função conforme o exemplo na classe Principal.*/

        public static int Sum(params int [] vetor) 
        {
            int soma = 0;

            for (int i=0; i< vetor.Length; i++)
            {
                soma += vetor[i];
            }

            return soma;

        }

        public static float Sum(params float[] vetor)
        {
            float soma = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                soma *= vetor[i];
            }

            return soma;

        }

        public static double Sum(params double[] vetor)
        {
            double soma = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }

            return soma;

        }


        public static String Sum(params String [] vetor)
        {
            String soma = null;

            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }

            return soma;

        }







    }
}
