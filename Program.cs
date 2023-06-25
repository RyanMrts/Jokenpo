using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        MSG("JOKENPÔ");
        Console.ResetColor();

        MSG("Como jogar?");
        MSG("0 = Pedra");
        MSG("1 = Papel");
        MSG("2 = Tesoura");

        Console.Write("Aperte ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("ENTER ");
        Console.ResetColor();
        Console.Write("Para jogar:");
        Console.ReadLine();
        MSG("Vamos ao game!");
        Thread.Sleep(500);

        int vitorias = 0;
        int rodadas = 0;
        MSG("Melhor de quantas?");
        rodadas = Convert.ToInt32(Console.ReadLine());

        MSG($"Melhor de {rodadas}...");
        Thread.Sleep(500);
        MSG("JO..");
        Thread.Sleep(1000);
        MSG("KEN..");
        Thread.Sleep(1000);
        MSG("PÔ !!");

        while (rodadas <= 5)
        {
            int escolha = int.Parse(Console.ReadLine()!);
            Random random = new Random();
            int EscolhaPC = random.Next(0, 3);

            if (escolha == 0 && EscolhaPC == 0)
            {
                MSG("Houve um empate.");
            }
            if (escolha == 0 && EscolhaPC == 1)
            {
                MSG("O papel cobre a pedra.");
            }
            if (escolha == 0 && EscolhaPC == 2)
            {
                MSG("A tesoura é quebrada pela pedra.");
            }

            if (escolha == 1 && EscolhaPC == 0)
            {
                MSG("A pedra é coberta pelo papel.");
            }
            if (escolha == 1 && EscolhaPC == 1)
            {
                MSG("Houve um empate.");
            }
            if (escolha == 1 && EscolhaPC == 2)
            {
                MSG("A tesoura corta o papel.");
            }

            if (escolha == 2 && EscolhaPC == 0)
            {
                MSG("A pedra quebra a tesoura.");
            }
            if (escolha == 2 && EscolhaPC == 1)
            {
                MSG("O papel é cortado pela tesoura.");
            }
            if (escolha == 2 && EscolhaPC == 2)
            {
                MSG("Houve um empate.");
            }
            rodadas++;
            if (escolha == EscolhaPC)
            {
                
            }
            else if ((escolha == 0 && EscolhaPC == 2) ||
                     (escolha == 1 && EscolhaPC == 0) ||
                     (escolha == 2 && EscolhaPC == 1))
            {
                MSG("Você venceu!");
                vitorias++;
            }
            else
            {
                MSG("Você perdeu!");
            }

            rodadas++;
        }

        MSG($"Número de vitórias: {vitorias}");
    }

    static void MSG(string mensagem)
    {
        Console.WriteLine(mensagem);
    }
        }
