using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Player;
using Tile;
namespace terminalBR
{
    class Program
    {
        static void Main(string[] args)
        {
            int Qlinhas = 3;
            int Qcolunas = 3;
            int Pcont = 1;
            bool thereIsAPlayer = false;
            Console.Write("Define Number of Players: ");
            int MaxPlayers = Int32.Parse(Console.ReadLine());

            /*
            Console.Write("Tamanho das linhas = ");
            Qlinhas = Int32.Parse(Console.ReadLine());
            Console.Write("Tamanho das colunas = ");
            Qcolunas = Int32.Parse(Console.ReadLine());
            */

            Tile[,] Map = new Tile[Qlinhas, Qcolunas];
            Player[] PlayersInGame = new Player[MaxPlayers];

            for (int i = 0; i < Qcolunas; i++)
            {
                for (int i2 = 0; i2 < Qlinhas; i2++)
                {
                    Map[i, i2] = new Tile(i2, i);
                }
            }

            for (int i = 0; i < MaxPlayers; i++)
            {
                Console.Write("Insert Player ");
                Console.Write(Pcont);
                Console.Write("'s Name: ");
                String NewPlayerName = Console.ReadLine();
                PlayersInGame[Pcont-1] = new Player(NewPlayerName, Pcont, Qlinhas, Qcolunas);
                Pcont++;
            }

            ShowMap(Qcolunas,Qlinhas,thereIsAPlayer,MaxPlayers,Map,PlayersInGame);
            
            Console.ReadLine();

        }
        public static void ShowMap(int Qcolunas, int Qlinhas, bool thereIsAPlayer, int MaxPlayers, Tile[,]Map, Player[]PlayersInGame)
        {
            for (int i = 0; i < Qcolunas; i++)
            {
                for (int i2 = 0; i2 < Qlinhas; i2++)
                {
                    thereIsAPlayer = false;
                    for (int i3 = 0; i3 < MaxPlayers; i3++)
                    {
                        if (Map[i, i2].getPosX() == PlayersInGame[i3].getPosX() && Map[i, i2].getPosY() == PlayersInGame[i3].getPosY())
                        {
                            Console.Write(i3 + 1 + " | ");
                            thereIsAPlayer = true;
                        }

                    }
                    if (!thereIsAPlayer)
                    {
                        Console.Write("X | ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

        public int getPosX()
        {
            return PosX;
        }
        public int getPosY()
        {
            return PosY;
        }
        public static void informStatus(String PlayerName, int PosX, int PosY)
        {
            Console.Write("Player ");
            Console.Write(PlayerName);
            Console.Write("\nX = ");
            Console.Write(PosX);
            Console.Write("\nY= ");
            Console.WriteLine(PosY);

        }
    }
}
