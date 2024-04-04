using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioTEC2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("***MENU***\nDentre as opções abaixo escolha as que você deseja realizar:\n1-Saber mais sobre a Mirabel\n2-Saber mais sobre a Casita Madrigal\n3-O quê a Mirabel faz na Casita\n4-Visualizar a quantidades de pessoas que ela ajudou");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Mirabel Madrigal é a única pessoa da linhagem direta dos madrigal que não possuí poderes, porém isso não a impede de ajudar a todos os necessitados que chegam na Casita Madrigal.");
                        break;
                    case 2:
                        Console.WriteLine(" A Casita Madrigal é uma casa de acolimento que recebe diariamente pessoas da própria comunidade em que se situa, contando com a participação da família Madrigal como trabalhadores e dirigentes.");
                        break;
                    case 3:
                        Console.WriteLine("Mirabel busca sempre aconselhar as pessoas sobre serem persistentes e correrem atras de seus sonhos, serem felizes, pensarem positivamente e serem compreensiveis com seus familiares.");
                        break;
                    case 4:
                        for(int quantP = 1; quantP <= 10; quantP++)
                        {
                            do
                            {
                                Console.WriteLine("Aqui você visualizara se a quantidade de pessoas que você acha que Mirabel atende, é realmente essa. Para isso entre com número de pessoas suposto: ");
                                quantP = int.Parse(Console.ReadLine());
                                if (quantP >= 1 && quantP <= 5)
                                {
                                    Console.WriteLine("Foram poucas pessoas.");
                                }
                                else if (quantP <= 6 && quantP >= 10)
                                {
                                    Console.WriteLine("Foi a quantidade media de pessoas que ela atende");

                                }
                                else
                                {
                                    Console.WriteLine("Foram muitas pessoas");
                                }
                                quantP++;
                            }
                            while (quantP >= 1 && quantP <= 10);
                        }
                        break;
                }
            }
        }
    }
}