using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_tresEnRaya.Entities
{
    public class Pieces:List<Piece>
    {
        public Pieces() {
            this.Add(new Piece("White"));
            this.Add(new Piece("White"));
            this.Add(new Piece("White"));
            this.Add(new Piece("Red"));
            this.Add(new Piece("Red"));
            this.Add(new Piece("Red"));
        }
    }
}
