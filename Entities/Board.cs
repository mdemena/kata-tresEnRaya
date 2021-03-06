﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_tresEnRaya.Entities
{
    public class Board:List<Cell>
    {
        public Piece LastPiece { get; set; }

        public Board(int _length, int _width)
        {
            for (int x = 0; x < _length; x++)
            {
                for (int y = 0; y < _width; y++) {
                    this.Add(new Cell(x,y));
                }
            }
        }

        public void PutPiece(Piece _piece, int _posX, int _posY)
        {
            try
            {
                if (PositonOccuped(_posX, _posY))
                {
                    throw new Exception();
                }
                else if (LastPiece != null && LastPiece.Color.Equals(_piece.Color))
                {
                    throw new Exception();
                }
                this.Find(x => x.PosX.Equals(_posX) & x.PosY.Equals(_posY)).Piece = LastPiece = _piece;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public bool PositonOccuped(int _posX, int _posY)
        {
            return this.Find(x => x.PosX.Equals(_posX) & x.PosY.Equals(_posY)).Piece != null;
        }
    }
}
