using System;

namespace Porco
{
    class Program
    {
        static void Main(string[] args)
        {
            double poupanca = 0;
            bool quebrar = false;

            do {
                Console.WriteLine("Deseja adicionar dinheiro ao porquinho? (s/n)");
                bool depositar = Console.ReadLine() == "s";

                if (depositar) {
                    Console.WriteLine("Digite o tipo de dinheiro que deseja adicionar");
                    Console.WriteLine("[1] - Cédula\n[2] - Moeda");
                    int tipoDeposito = Convert.ToInt32(Console.ReadLine());

                    if (tipoDeposito == 1)
                    {
                        Console.WriteLine("Escolha a cédula e a quantidade");
                        Console.WriteLine("[1] - 2 Reais\n[2] - 5 Reais\n[3] - 10 Reais\n[4] - 20 Reais\n[5] - 50 Reais");
                        int tipoDepositoQuantia = Convert.ToInt32(Console.ReadLine());

                        if (tipoDepositoQuantia == 1)
                        {
                            poupanca += 2;
                        } else if (tipoDepositoQuantia == 2)
                        {
                            poupanca += 5;
                        } else if (tipoDepositoQuantia == 3)
                        {
                            poupanca += 10;
                        } else if (tipoDepositoQuantia == 4)
                        {
                            poupanca += 20;
                        } else if (tipoDepositoQuantia == 5)
                        {
                            poupanca += 50;
                        } else
                        {
                            Console.WriteLine("Cédula não suportada");
                            return;
                        }
                    } else if (tipoDeposito == 2)
                    {
                        Console.WriteLine("Escolha a cédula e a quantidade");
                        Console.WriteLine("[1] - 5 centavos\n[2] - 10 centavos\n[3] - 25 centavos\n[4] - 50 centavos\n[5] - 1 real");
                        int tipoDepositoQuantia = Convert.ToInt32(Console.ReadLine());

                        if (tipoDepositoQuantia == 1)
                        {
                            poupanca += 0.05;
                        }
                        else if (tipoDepositoQuantia == 2)
                        {
                            poupanca += 0.10;
                        }
                        else if (tipoDepositoQuantia == 3)
                        {
                            poupanca += 0.25;
                        }
                        else if (tipoDepositoQuantia == 4)
                        {
                            poupanca += 0.50;
                        }
                        else if (tipoDepositoQuantia == 5)
                        {
                            poupanca += 1;
                        }
                        else
                        {
                            Console.WriteLine("Moeda não suportada");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Não encontrei esse tipo de dinheiro");
                        return;
                    }
                } else {
                    quebrar = true;
                }
            } while (!quebrar);


            if (quebrar) {
                Console.WriteLine("Seu porquinho tem R$ " + poupanca);
            }
        }
    }
}
