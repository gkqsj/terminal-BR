using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalBR
{
    class Item
    {
        int Hbuff;
        int Dbuff;
        public Item(int ItemCod)
        {
            if (ItemCod == 0)
            {
                Hbuff = 10;
                Dbuff = 0;
            }
            else if (ItemCod == 1)
            {
                Hbuff = 0;
                Dbuff = 15;
            }
        }
    }
}