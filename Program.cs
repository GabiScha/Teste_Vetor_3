using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] vet = new int[10];
            int pos3 = 0;
            int ultpos = 0;
            int primas = 0;
            int segundo = 0;
            int soma = 0;
            int ver = 1;
            int var20 = 0;
            int pos4 = 0;
            int pos5 = 0;
            int pos6 = 0;
            int pos7 = 0;



            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Escreava o valor que corresponde a " + i +":");
                vet[i] = int.Parse(Console.ReadLine());

            }
            Console.Clear();
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Verificando...");
                

                if (i == 3)
                {
                    pos3 = vet[i];
                }
                 else if (i == 4)
                {
                    pos4 = vet[i];
                }
                 else if (i == 5)
                {
                    pos5 = vet[i];
                }
                 else if (i == 6)
                {
                    pos6 = vet[i];
                }
                 else if (i == 7)
                {
                    pos7 = vet[i];
                }
                else if (i == 9)
                {
                    ultpos = vet[9];
                }


                soma = vet[0] + vet[1] + vet[9];

               if (ver == 1)
                {

                    if (vet[i] == 20)
                    {
                        var20 = i;
                        ver = 0;
                    }
                }



            }
            Console.Clear();

            Console.WriteLine("O valor que está no indice 3 é: " + pos3);
            Console.WriteLine("O valor que está na ultima posição é: " + ultpos);
            Console.WriteLine("A soma do 1° 2° e 10° elemento é: " + soma);
            Console.WriteLine("O valor 20 ocorreu primeiro na posição: " + var20);
            Console.WriteLine("Os valores das posições são: 5°=" + pos4 + " 6°=" + pos5 + " 7°=" + pos6+ " 8°=" + pos7);





            Console.ReadKey();
        }
    }
}
