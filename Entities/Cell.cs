using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_tresEnRaya.Entities
{
    public class Cell
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Piece Piece { get; set; }
        public Cell(int _posX, int _posY) {
            this.PosX = _posX;
            this.PosY = _posY;
        }
    }
}
