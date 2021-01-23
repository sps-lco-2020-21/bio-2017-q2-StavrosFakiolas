using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIO2.App
{
    class Square
    {
        public bool top = false;
        public bool left = false;
        public int owner = 0;
    }
}
// each time an edge is claimed - if top edge (direction left or right) check current square and square above
//                              - if left edge (direction up or down) check current square and square to the left
//
// bear in mind that puppet squares exist on the bottom and right of the grid - dont want to claim them
// position increases by modifier if no available edges from current position
// 
// 
// 