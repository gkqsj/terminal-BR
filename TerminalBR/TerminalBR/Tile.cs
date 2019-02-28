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
        public Tile(int i, int i2)
        {
            this.PosX = i;
            this.PosY = i2;
        }

        public int getPosX()
        {
            return PosX;
        }
        public int getPosY()
        {
            return PosY;
        }

    }
}