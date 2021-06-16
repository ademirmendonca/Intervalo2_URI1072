using System;

namespace Intervalo2_URI1072
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leitura inicial da quantidade de numeros informados
            int n = int.Parse(Console.ReadLine());
            
            int contIn = 0, contOut = 0;

            for (int i = 0; i < n; i++)
            {
                //Efetua a leitura conforme o valor ja informado no inicio
                int x = int.Parse(Console.ReadLine());

                //Efetua a contagem dos valores entre 10 e 20
                if (x >= 10 && x <= 20)
                {
                    contIn = contIn + 1;
                }

                //Efetua a contagem dos valores fora de 10 e 20
                else
                {
                    contOut = contOut + 1;
                }
                
            }

            //Informa quantos valores ha entre 10 e 20
            Console.WriteLine(contIn + " in");

            //Informa quantos valores ha fora de 10 e 20
            Console.WriteLine(contOut + " out");

        }
    }
}
