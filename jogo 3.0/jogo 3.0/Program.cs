using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] nomes = new string[5];
            nomes[0] = "Lorenzo";
            nomes[1] = "Ednei";
            nomes[2] = "Bernardo";
            nomes[3] = "Neymar";
            nomes[4] = "Lucas";
            int i = 0;
            
            int oc = random.Next(0, 101);
            int li = 1;
            int ls = 100;
            
            int palpite;
            int qnt = i;

            do
            {
                Console.Write("digite o numero de jogadores de 2 a 5: ");
                qnt = int.Parse(Console.ReadLine());



            }
            while (qnt < 2 || qnt > 5);
            {
                do
                {
                    do
                    {
                        Console.Write($"{ nomes[i]},digite seu palpite entre {li} e {ls}: ");
                        palpite = int.Parse(Console.ReadLine());
                        
                    }
                    while (palpite <= li || palpite >= ls);
                    {
                        if (palpite == oc)
                        {
                            Console.WriteLine(" Parabéns, vc perdeu kkkk");
                        }
                        else if (palpite < oc)
                        {
                            li = palpite;
                        }
                        else
                        {
                            ls = palpite;
                        }
                        
                        i = i + 1;

                        if (i == qnt)
                        {
                            i = 0;
                        }


                    }



                }
                while (palpite != oc);


            }


        }


    }


}

