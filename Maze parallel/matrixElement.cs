using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_parallel
{
    class matrixElement
    {
        public bool element_status;//false for blocked squares
        public int element_type;//0 for ordinary square .. 1 for start square .. 2 for goal square
        public int direction;//0 for car north .. 1 for east .. 2 for south .. 3 for west
        public bool goal_flag;
        public bool visited;

        public matrixElement()
        {
            this.direction = 0;
            this.element_type = 0;
            this.element_status = true;
            this.goal_flag = false;
            this.visited = false;
        }
    }
}
