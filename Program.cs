using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Robotupiniquin
{
    internal class Program
    {
        static void Main(string[] args)
            
        {

            Console.WriteLine("informe o tamanho de y: ");
            int tamanhoY = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o tamanho de x: ");
            int tamanhoX = int.Parse(Console.ReadLine());


            while (true)
            {
                Console.Clear();
                Console.WriteLine("informe a posicao inical e a direcao do robo");
                string[] inicial = Console.ReadLine().ToUpper().Split(' ');
                int x = int.Parse(inicial[0]);
                int y = int.Parse(inicial[1]);
                char direcao = char.Parse(inicial[2]);
                Console.WriteLine("informe os comandos D= virar a direita E= virar a esquerda M= mover ");
                string[] Comando_Entrada = Console.ReadLine().ToUpper().Split(' ');
                string comando_Saida = Comando_Entrada[0];


                foreach (char comando  in comando_Saida)
                {
                    switch (comando)
                    {
                        case 'M':
                            switch (direcao)
                            {
                                case 'N':
                                    y++;
                                    break;
                                case 'S':
                                    y--;
                                    break;
                                case 'L':
                                    x++;
                                    break;
                                case 'O':
                                    x--;
                                    break;


                            }
                            break;

                        case 'E':
                            switch (direcao)
                            {
                                case 'N': direcao = 'O'; break;
                                case 'S': direcao = 'L'; break;
                                case 'L': direcao = 'N'; break;
                                case 'O': direcao = 'S'; break;

                            }
                            break;
                        case 'D':
                            switch (direcao)
                            {
                                case 'N': direcao = 'L'; break;
                                case 'S': direcao = 'O'; break;
                                case 'L': direcao = 'S'; break;
                                case 'O': direcao = 'N'; break;
                            }
                            break;
                    }
                }
                Console.WriteLine($"{x} {y} {direcao}");

                
                Console.Write("Deseja continuar? (S/N) ");
                string resposta = Console.ReadLine();
                if (resposta != "S" && resposta != "s") break;





            }


          
        }
    }
}
