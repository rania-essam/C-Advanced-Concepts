using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class isudoko
    {
        private int[,] sudoko;


        // intiallize sudoko matrix 
        public isudoko(int[,] _grid)
        {
            sudoko = _grid;
        }

        // indexing 

        public int this[int row,int col]
        {
            get
            {
                if(row < 0 || row >= sudoko.GetLength(0) || col <0 || col >= sudoko.GetLength(1))
                {
                    return -1;
                }
                return sudoko[row, col];
            }
            set
            {
                if(value< 0 || value > 9|| row < 0 || row >= sudoko.GetLength(0) || col < 0 || col >= sudoko.GetLength(1))
                {
                    return;
                }
                sudoko[row, col] = value;
            }
        }
    }
}
