using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Random random = new Random();
                int oc = random.Next(0, 101);
                int li = 1;
                int ls = 100;
                int jog = 1;
                int palpite;
                int qnt = jog;

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
                            Console.Write($"jogador {jog},digite seu palpite entre {li} e {ls}:");
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
                            jog = jog + 1;

                            if (jog > qnt)
                            {
                                jog = 1;
                            }


                        }



                    }
                    while (palpite != oc);


                }


            }
        }
    }
}   