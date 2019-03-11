using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalBR
{
    class Tile
    {
        int PosX;
        int PosY;
        Random random = new Random();
        Item[] itensInTile = new Item[50];
        public Tile(int i, int i2)
        {
            this.PosX = i;
            this.PosY = i2;
        }
        public int lastAdded()
        {
            for (int i = 0; i < 50; i++)
            {
                if (this.itensInTile[i] == null)
                {
                    return i;
                }   
            }
            return 0;
        }
        public void receivePresent()
        { 
            itensInTile[lastAdded()] = new Item(random.Next(2));
        }
        public int getPosX() => PosX;
        public int getPosY() => PosY;

    }
}