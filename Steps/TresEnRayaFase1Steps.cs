using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using kata_tresEnRaya.Entities;

namespace kata_tresEnRaya.Steps
{
    [Binding]
    public class TresEnRayaFase1Steps
    {
        private Board _board;
        private Pieces _pieces;

        [Given(@"I have a empty 3x3 table"), Scope(Tag = "TresEnRayaFase1")]
        public void GivenIHaveAEmptyTable()
        {
            _board = new Board(3,3);
        }
        
        [Given(@"I have white and red pieces and must be placed in board")]
        public void GivenIHaveWhiteAndRedPieces()
        {
            _pieces = new Pieces();
        }
        
        [When(@"I put first piece")]
        public void WhenIPutFirstPiece()
        {
            _board.PutPiece(new Piece("White"),0,0);
        }
        
        [Then(@"The first pice must be white piece")]
        public void ThenTheFirstPiceMustBeWhitePiece()
        {
            Assert.IsTrue(_board.Find(x => x.PosX.Equals(0) & x.PosY.Equals(0)).Piece.Color.Equals("White"));
        }
    }
}
