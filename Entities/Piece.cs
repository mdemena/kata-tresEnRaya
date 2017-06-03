using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_tresEnRaya.Entities
{
    public class Piece
    {
        public string Color { get; set; }
        public Piece(string _color) {
            Color = _color;
        }
    }
}
