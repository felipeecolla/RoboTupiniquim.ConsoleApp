using System;

namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comando = "MMDMMDMDDM";
            char sentido = 'L';
            int localizacaoX = 3;
            int localizacaoY = 3;

            char[] instrucoes = comando.ToCharArray();

            for (int posicao = 0; posicao < instrucoes.Length; posicao++)
            {
                if (instrucoes[posicao] == 'M')
                {
                    if (sentido == 'N')
                        localizacaoY = localizacaoY + 1;
                    else if (sentido == 'S')
                        localizacaoY = localizacaoY - 1;
                    else if (sentido == 'L')
                        localizacaoX = localizacaoX + 1;
                    else if (sentido == 'O')
                        localizacaoX = localizacaoX - 1;

                }
                if (instrucoes[posicao] == 'E')
                {
                    if (sentido == 'N')
                        sentido = 'O';
                    else if (sentido == 'O')
                        sentido = 'S';
                    else if (sentido == 'S')
                        sentido = 'L';
                    else if (sentido == 'L')
                        sentido = 'N';


                }
                if ((instrucoes[posicao] == 'D'))
                {
                    if (sentido == 'N')
                        sentido = 'L';
                    else if (sentido == 'O')
                        sentido = 'N';
                    else if (sentido == 'S')
                        sentido = 'O';
                    else if (sentido == 'L')
                        sentido = 'S';
                }
            }

            Console.WriteLine(localizacaoX + " " +  localizacaoY + " " + sentido);
            Console.ReadLine();




        }
    }
}





        
    
