using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalBR
{
    class Item
    {
        int HPbuff;
        int DMGbuff;
        public Item(int ItemCod)
        {
            if (ItemCod == 0)
            {
                HPbuff = 11;
                DMGbuff = 0;
            }
            else if (ItemCod == 1)
            {
                HPbuff = 0;
                DMGbuff = 15;
            }
        }
    }
}