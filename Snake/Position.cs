using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    struct Position
    {
        public int row;
        public int col;

        public Position(int x, int y)
        {
            this.row = x;
            this.col = y;
        }
    }
}
