using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIO2.App
{
    public class Grid
    {
        enum Direction
        {
            Up,
            Right,
            Down,
            Left
        }

        

        Square[,] grid = new Square[6, 6];

        int p1pos, p1modifier, p2pos, p2modifier;

        public Grid(int p1pos, int p1modifier, int p2pos, int p2modifier)
        {
            this.p1pos = p1pos;
            this.p1modifier = p1modifier;
            this.p2pos = p2pos;
            this.p2modifier = p2modifier;
        }

        public void Play(int turns)
        {
            for (int turn = 0; turn < turns; ++turn)
            {
                TakeTurn(ref p1pos, p1modifier);
                TakeTurn(ref p2pos, p2modifier);
            }

        }

        void TakeTurn(ref int pos, int modifier) // ref allows for variable to be changed by function
        {
            int column = (pos - 1) % 6;
            int row = (pos - 1) / 6;

            if (EdgeAvailable(row, column, Direction.Up))
            {
                ClaimEdge(row, column, Direction.Up);
            }
            else if (EdgeAvailable(row, column, Direction.Right))
            {

            }
            else if (EdgeAvailable(row, column, Direction.Down))
            {

            }
            else if (EdgeAvailable(row, column, Direction.Left))
            {

            }
            else
            {

            }
        }

        bool EdgeAvailable(int row, int column, Direction dir)
        {
            if (dir == Direction.Up && row == 0 || dir == Direction.Left && column == 0 || dir == Direction.Down && row == 5 || dir == Direction.Right && column == 5)
                return false;

            switch(dir)
            {
                case Direction.Up:
                    return !grid[row - 1, column].left;
                case Direction.Right:
                    return !grid[row, column].top;
                case Direction.Down:
                    return !grid[row, column].left;
                case Direction.Left:
                    return !grid[row, column - 1].top;
                default: 
                    return false;

            }
        }

        void ClaimEdge(int row, int column, Direction dir)
        {
            if (dir == Direction.Up && row == 0 || dir == Direction.Left && column == 0 || dir == Direction.Down && row == 5 || dir == Direction.Right && column == 5)
                return;

            switch (dir)
            {
                case Direction.Up:
                    grid[row - 1, column].left = true;
                    break;
                case Direction.Right:
                    grid[row, column].top = true;
                    break;
                case Direction.Down:
                    grid[row, column].left = true;
                    break;
                case Direction.Left:
                    grid[row, column - 1].top = true;
                    break;

            }
        }

    }
}
