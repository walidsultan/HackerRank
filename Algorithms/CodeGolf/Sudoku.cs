using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.CodeGolf
{
    public class Sudoku
    {
        private IDisplayHandler _console;
        public Sudoku(IDisplayHandler console)
        {
            _console = console;
        }

        List<Block> puzzle = new List<Block>();
        public void Solve(int[,] grid)
        {
            do
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        GetPossibilities(i, j, grid);
                    }
                }

                IEnumerable<Block> d = puzzle.Where(b => b.po.Count == 1);
                if (d.Count() > 0)
                {
                    foreach (Block b in puzzle.Where(b => b.po.Count == 1))
                    {
                        grid[b.x, b.y] = b.po.Single();
                    }
                }
                else
                {
                    Block b = puzzle.FirstOrDefault(p => p.po.Count > 1);
                    if (b != null)
                    {
                        grid[b.x, b.y] = b.po.First();
                        b.po.Clear();
                    }
                }
            } while (puzzle.Count(s => s.po.Count > 1) > 0);
        }

        private void GetPossibilities(int i, int j, int[,] grid)
        {
            Block block = puzzle.SingleOrDefault(b => b.x == i && b.y == j);
            if (block == null)
            {
                block = new Block() { x = i, y = j };
                puzzle.Add(block);
            }
            for (int a = 0; a < 9; a++)
            {
                block.po.Remove(grid[a, j]);
            }
            for (int a = 0; a < 9; a++)
            {
                block.po.Remove(grid[i, a]);
            }
            for (int a = i / 3; a < i / 3 + 3; a++)
            {
                for (int b = j / 3; b < j / 3 + 3; b++)
                {
                    block.po.Remove(grid[a, b]);
                }
            }
        }
    }
    public class Block
    {
        public Block()
        {
            po = Enumerable.Range(1, 9).ToList();
        }
        public int x { get; set; }
        public int y { get; set; }
        public List<int> po { get; set; }
    }
}
