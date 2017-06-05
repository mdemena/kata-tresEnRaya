using System;
using TechTalk.SpecFlow;
using kata_tresEnRaya.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kata_tresEnRaya.Steps
{
    [Binding]
    public class TresEnRayaFase2Steps
    {
        private Board _board;

        [Given(@"I have a empty 3x3 board"), Scope(Tag = "TresEnRayaFase2")]
        public void GivenIHaveAEmptyBoard()
        {
            _board = new Board(3,3);
        }
        
        [When(@"In a turn we put a new piece in a empty cell")]
        public void WhenInATurnWePutANewPieceInAEmptyCell()
        {
            _board.PutPiece(new Piece("White"),0,0);
        }
        
        [Then(@"Not is possible to put two sequence pieces with the same color")]
        public void ThenNotIsPossibleToPutTwoSequencePiecesWithTheSameColor()
        {
            Assert.IsTrue(!_board.LastPiece.Equals(new Piece("Red")));            
        }
    }
}
