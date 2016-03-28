﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class StrategoGame
    {

        /// <summary>
        /// The default amount of pieces for each piece. (EX: 0 0s; 1 1; 1 2; 2 3s; 4 4s; etc..)
        /// </summary>
        public readonly int[] defaults = new int[13] { 0, 1, 1, 2, 3, 4, 4, 4, 5, 8, 1, 6, 1 };
        //public readonly int[] defaults = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
        //public readonly int[] defaults = new int[13] { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 

        /// <summary>
        /// Width of the enclosing panel in pixels
        /// </summary>
        public int panelWidth { get; set; }

        /// <summary>
        /// Height of the enclosing panel in pixels
        /// </summary>
        public int panelHeight { get; set; }

        /// <summary>
        /// The 2DArray full of all pieces on the board
        /// </summary>
        public int[,] boardState { get; set; }

        /// <summary>
        /// The array which holds information on how many pieces of each type can still be placed
        /// </summary>
        public int[] placements;

        /// <summary>
        /// Whether or not the pre game has begun
        /// </summary>
        public bool preGameActive { get; set; }

        /// <summary>
        /// -1 for player2 and 1 for player 1. 0 when game isn't started. 
        /// 2 for transition from player1 to player2; -2 for transition from player2 to player1.
        /// </summary>
        public int turn { get; set; }

        /// <summary>
        /// Coordinates of the piece that is currently selected in the array
        /// </summary>
        public Point pieceSelectedCoords { get; set; }

        /// <summary>
        /// Just a boolean indicating if a piece is currently selected or not
        /// </summary>
        public Boolean pieceIsSelected { get; set; }

        /// <summary>
        /// Whether player 2 is an AI or not
        /// </summary>
        public Boolean isSinglePlayer { get; set; }

        /// <summary>
        /// If bombs can be moved
        /// </summary>
        public Boolean movableBombs { get; set; }

        /// <summary>
        /// If flags can be moved
        /// </summary>
        public Boolean movableFlags { get; set; }

        /// <summary>
        /// Coordinates of the last piece to win a battle
        /// </summary>
        public Point lastFought { get; set; }

        /// <summary>
        /// The AI that the player will play against, if they choose single player.
        /// </summary>
        public AI ai;

        /// <summary>
        /// If levels can be skipped using keypresses
        /// </summary>
        private Boolean skippableLevels { get; set; }

        /// <summary>
        /// Current level of the game. Equals -1 if not in campaign mode
        /// </summary>
        public int level { get; set; }

        public StrategoGame() {
            this.turn = 0;
            this.preGameActive = false;
            this.skippableLevels = false;
            this.isSinglePlayer = false;
            this.lastFought = new Point(-1, -1);
            this.movableBombs = false;
            this.movableFlags = false;
            this.level = -1;

            boardState = new int[10, 10];
            for (int row = 0; row < 6; row++) fillRow(42, row);

            //    this.ai = new AI(this, -1);

        }
      //  public StrategoGame(int windowWidth, int windowHeight, int[,] boardState)
      //  {
      //      this.boardState = boardState;
      //      this.panelWidth = windowWidth;
      //      this.panelHeight = windowHeight;
      //      this.placements = (int[])this.defaults.Clone();
      //      this.preGameActive = false;
      //      this.isSinglePlayer = false;
      //      this.lastFought = new Point(-1, -1);
      //      this.movableBombs = false;
      //      this.movableFlags = false;
      ////      this.ai = new AI(this, -1);
      //  }

        /// <summary>
        /// Gets the piece at a given board cell
        /// </summary>
        /// <param name="x">x-coordinate of the cell we want</param>
        /// <param name="y">y-coordinate of the cell we want</param>
        /// <returns>The number of the piece located at (x,y)</returns>
        public int getPiece(int x, int y)
        {
            return this.boardState[x, y];
        }

        /// <summary>
        /// Fills the given row in the board state with the given value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="row"></param>
        public void fillRow(int value, int row)
        {
            for (int x = 0; x < this.boardState.GetLength(0); x++) this.boardState[x, row] = value;
        }

        /// <summary>
        /// Retrieves the number of pieces still available for
        /// placement of a given type
        /// </summary>
        /// <param name="piece">Type of the piece you want to check</param>
        /// <returns>Number of pieces available for placement</returns>
        public int getPiecesLeft(int piece)
        {
            return this.placements[piece];
        }

        /// <summary>
        /// Places a piece at the given coordinates
        /// </summary>
        /// <param name="piece">Number of the piece you want to place</param>
        /// <param name="x">x-coordinate you want to place it at</param>
        /// <param name="y">y-coordinate you want to place it at</param>
        /// <returns>Whether or not the placement was successful</returns>
        public bool? placePiece(int piece, int x, int y)
        {
            if (turn == 0 || Math.Abs(turn) == 2) return false;
            if (Math.Abs(piece) > 12 || x < 0 || y < 0 || x > this.panelWidth || y > this.panelHeight) throw new ArgumentException();
            if ((Math.Sign(piece) != Math.Sign(this.turn)) && (piece != 0)) return false;
            Boolean retVal = true;
            int scaleX = this.panelWidth / this.boardState.GetLength(0);
            int scaleY = this.panelHeight / this.boardState.GetLength(1);
            int pieceAtPos = this.boardState[x / scaleX, y / scaleY];

            if (piece == 0 && pieceAtPos != 42)
            {
                // We are trying to remove
                if (Math.Sign(pieceAtPos) != Math.Sign(this.turn)) return false;
                if (pieceAtPos == 0) retVal = false;
                this.placements[Math.Abs(pieceAtPos)]++;
            }
            else if (pieceAtPos == 0 && this.placements[Math.Abs(piece)] > 0)
            {
                // We are trying to add
                this.placements[Math.Abs(piece)] -= 1;
            }
            else retVal = false;

            if (retVal) this.boardState[x / scaleX, y / scaleY] = piece;
            return retVal;
        }

        /// <summary>
        /// Looks at the current turn, and changes it to whatever the next turn should be.
        /// Handles global game variables like the stage of the game and so on.
        /// Also sends a call to the AI to notify it that it's time to take its turn when necessary.
        /// </summary>
        public void nextTurn()
        {
            // We just came here from the main menu
            if (this.turn == 0)
            {
                preGameActive = true;
                this.turn = 1;
            }
            // It's blue player's turn
            else if (this.turn == 1)
            {
                if (this.preGameActive)
                {
                    this.turn = -1;
                    this.placements = this.defaults;
                }
                else
                {
                    this.turn = 2;
                }
            }
            // It's red player's turn
            else if (this.turn == -1)
            {
                if (this.preGameActive)
                {
                    for (int i = 4; i < 6; i++)
                    {
                        for (int x = 0; x < 2; x++)
                            this.boardState[x, i] = 0;
                        for (int x = 4; x < 6; x++)
                            this.boardState[x, i] = 0;
                        for (int x = 8; x < 10; x++)
                            this.boardState[x, i] = 0;
                    }
                    this.preGameActive = false;
                }
                if (!this.isSinglePlayer || (this.lastFought != new Point(-1, -1))) this.turn = -2;
                else this.turn = 1;
            }
            else if (this.turn == -2)
            {
                turn = 1;
            }
            else
            {
                turn = -1;
            }

            if (this.isSinglePlayer && this.turn == this.ai.team)
            {
                if (this.preGameActive)
                    this.ai.placePieces();
                else
                    this.ai.takeTurn();
            }
        }
        /// <summary>
        /// Selects a piece if no piece is selected.
        /// </summary>
        /// <param name="x">x coords of the click in pixels</param>
        /// <param name="y">y coord of the click in pixels</param>
        /// <returns></returns>
        public bool? SelectPiece(int x, int y)
        {
            if ((Math.Abs(turn) == 2) || (turn == -1 && isSinglePlayer)) return false;
            int scaleX = this.panelWidth / this.boardState.GetLength(0);
            int scaleY = this.panelHeight / this.boardState.GetLength(1);
            if ((this.pieceSelectedCoords == new Point(x / scaleX, y / scaleY)) && this.pieceIsSelected)
            {
                this.pieceIsSelected = false;
                return false;
            }
            if (((Math.Abs(this.boardState[x / scaleX, y / scaleY]) == 11 && !this.movableBombs) || (Math.Abs(this.boardState[x / scaleX, y / scaleY]) == 12) && !this.movableFlags) ||
                  Math.Sign(this.boardState[x / scaleX, y / scaleY]) != Math.Sign(this.turn))
            {
                return false;
            }
            this.pieceSelectedCoords = new Point(x / scaleX, y / scaleY);
            this.pieceIsSelected = true;
            return true;
        }

        /// <summary>
        /// Moves the selected piece(if there is one) to the tile tile which corresponds to the x,y coords (if valid)
        /// </summary>
        /// <param name="x">x coordinate of the mouse click of where to move (pixels)</param>
        /// <param name="y">y coordinate of the mouse click of where to move (pixels)</param>
        /// <returns>true if a piece was moved, false otherwise</returns>
        public bool MovePiece(int x, int y)
        {
            int scaleX = this.panelWidth / this.boardState.GetLength(0);
            int scaleY = this.panelHeight / this.boardState.GetLength(1);
            if (!this.pieceIsSelected)
                return false;
            this.pieceIsSelected = false;
            if (Piece.attack(this.boardState[this.pieceSelectedCoords.X, this.pieceSelectedCoords.Y],
                this.boardState[x / scaleX, y / scaleY]) == null)
                return false;
            if (Math.Abs(this.boardState[this.pieceSelectedCoords.X, this.pieceSelectedCoords.Y]) != 9)
            {
                if (Math.Abs((x / scaleX) - this.pieceSelectedCoords.X) > 1 || Math.Abs((y / scaleY) - this.pieceSelectedCoords.Y) > 1)
                    return false;
            }
            else
            {
                //Check for the scout's special cases
                if (Math.Abs((x / scaleX) - this.pieceSelectedCoords.X) > 1)
                {
                    if (((x / scaleX) - this.pieceSelectedCoords.X) > 1)
                    {
                        for (int i = 1; i < (x / scaleX) - this.pieceSelectedCoords.X; i++)
                        {
                            if (this.boardState[this.pieceSelectedCoords.X + i, this.pieceSelectedCoords.Y] != 0)
                                return false;
                        }
                    }
                    else if (((x / scaleX) - this.pieceSelectedCoords.X) < -1)
                    {
                        for (int i = -1; i > (x / scaleX) - this.pieceSelectedCoords.X; i--)
                        {
                            if (this.boardState[this.pieceSelectedCoords.X + i, this.pieceSelectedCoords.Y] != 0)
                                return false;
                        }
                    }
                }
                else if (Math.Abs((y / scaleY) - this.pieceSelectedCoords.Y) > 1)
                {
                    if (((y / scaleY) - this.pieceSelectedCoords.Y) > 1)
                    {
                        for (int i = 1; i < (y / scaleY) - this.pieceSelectedCoords.Y; i++)
                        {
                            if (this.boardState[this.pieceSelectedCoords.X, this.pieceSelectedCoords.Y + i] != 0)
                                return false;
                        }
                    }
                    else if (((y / scaleY) - this.pieceSelectedCoords.Y) < -1)
                    {
                        for (int i = -1; i > (y / scaleY) - this.pieceSelectedCoords.Y; i--)
                        {
                            if (this.boardState[this.pieceSelectedCoords.X, this.pieceSelectedCoords.Y + i] != 0)
                                return false;
                        }
                    }
                }
            }
            if (Math.Abs((x / scaleX) - this.pieceSelectedCoords.X) >= 1 && Math.Abs((y / scaleY) - this.pieceSelectedCoords.Y) >= 1)
                return false;
            if (Math.Abs((x / scaleX) - this.pieceSelectedCoords.X) == 0 && Math.Abs((y / scaleY) - this.pieceSelectedCoords.Y) == 0)
                return false;
            int defender = this.boardState[x / scaleX, y / scaleY];
            this.boardState[x / scaleX, y / scaleY] = Piece.attack(this.boardState[this.pieceSelectedCoords.X, this.pieceSelectedCoords.Y], this.boardState[x / scaleX, y / scaleY]).Value;
            if ((defender == 0) || this.boardState[x / scaleX, y / scaleY] == 0)
                this.lastFought = new Point(-1, -1);
            else
                this.lastFought = new Point(x / scaleX, y / scaleY);
            this.boardState[this.pieceSelectedCoords.X, this.pieceSelectedCoords.Y] = 0;
            if (Math.Abs(defender) != 12)
            {
                this.nextTurn();
            }
            return true;
        }

        /// <summary>
        /// Finds all of the possible moves for a piece with the given X and Y coordinates using the board state passed in.
        /// </summary>
        /// <param name="X">>X position in the board state (not in pixels)</param>
        /// <param name="Y">Y position in the board state (not in pixels)</param>
        /// <param name="boardState">A 2D array representing the state of the board.</param>
        /// <returns>A 2D array containing 1 in every space where the deisgnated piece can move and 0 otherwise</returns>
        public int[,] GetPieceMoves(int X, int Y, GamePiece[,] boardState)
        {
            int xDirLength = boardState.GetLength(0);
            int yDirLength = boardState.GetLength(1);
            int[,] moveArray = new int[xDirLength, yDirLength];
            for (int i = 0; i < xDirLength; i++)
            {
                for(int j = 0; j < yDirLength; j++)
                {
                    moveArray[i, j] = 0;
                }
            }
            GamePiece selectedPiece = boardState[X, Y];
            return moveArray;
            /*
            if ((Math.Abs(boardState[X, Y]) == 0) || (Math.Abs(boardState[X, Y]) == 11 && !this.movableBombs) || (Math.Abs(boardState[X, Y]) == 12 && !this.movableFlags) || (Math.Abs(boardState[X, Y]) == 42))
                return moveArray;
            if (Math.Abs(boardState[X, Y]) == 9)
            {
                //for (int yD = Y + 1; yD < boardState.GetLength(1) && boardState[X, yD] == 0; yD++)
                //    moveArray[X, yD] = 1;
                //for (int yU = Y - 1; yU >= 0 && boardState[X, yU] == 0; yU--)
                //    moveArray[X, yU] = 1;
                //for (int xR = X + 1; xR < boardState.GetLength(0) && boardState[xR, Y] == 0; xR++)
                //    moveArray[xR, Y] = 1;
                //for (int xL = X - 1; xL >= 0 && boardState[xL, Y] == 0; xL--)
                //    moveArray[xL, Y] = 1;
                for (int yD = Y + 1; yD < boardState.GetLength(1) && ((Math.Sign(boardState[X, yD]) != Math.Sign(boardState[X, Y])) && boardState[X, yD] != 42); yD++)
                {
                    moveArray[X, yD] = 1;
                    if ((Math.Sign(boardState[X, yD]) != Math.Sign(boardState[X, Y])) && (Math.Sign(boardState[X, yD]) != 0))
                        break;
                }
                for (int yU = Y - 1; yU >= 0 && ((Math.Sign(boardState[X, yU]) != Math.Sign(boardState[X, Y])) && boardState[X, yU] != 42); yU--)
                {
                    moveArray[X, yU] = 1;
                    if ((Math.Sign(boardState[X, yU]) != Math.Sign(boardState[X, Y])) && (Math.Sign(boardState[X, yU]) != 0))
                        break;
                }
                for (int xR = X + 1; xR < boardState.GetLength(0) && ((Math.Sign(boardState[xR, Y]) != Math.Sign(boardState[X, Y])) && boardState[xR, Y] != 42); xR++)
                {
                    moveArray[xR, Y] = 1;
                    if ((Math.Sign(boardState[xR, Y]) != Math.Sign(boardState[X, Y])) && (Math.Sign(boardState[xR, Y]) != 0))
                        break;
                }
                for (int xL = X - 1; xL >= 0 && ((Math.Sign(boardState[xL, Y]) != Math.Sign(boardState[X, Y])) && boardState[xL, Y] != 42); xL--)
                {
                    moveArray[xL, Y] = 1;
                    if ((Math.Sign(boardState[xL, Y]) != Math.Sign(boardState[X, Y])) && (Math.Sign(boardState[xL, Y]) != 0))
                        break;
                }
            }
            if (Y > 0)
                if ((Math.Sign(boardState[X, Y - 1]) != Math.Sign(boardState[X, Y])) && boardState[X, Y - 1] != 42)
                    moveArray[X, Y - 1] = 1;
            if (Y < boardState.GetLength(1) - 1)
                if ((Math.Sign(boardState[X, Y + 1]) != Math.Sign(boardState[X, Y])) && boardState[X, Y + 1] != 42)
                    moveArray[X, Y + 1] = 1;
            if (X < boardState.GetLength(0) - 1)
                if ((Math.Sign(boardState[X + 1, Y]) != Math.Sign(boardState[X, Y])) && boardState[X + 1, Y] != 42)
                    moveArray[X + 1, Y] = 1;
            if (X > 0)
                if ((Math.Sign(boardState[X - 1, Y]) != Math.Sign(boardState[X, Y])) && boardState[X - 1, Y] != 42)
                    moveArray[X - 1, Y] = 1;
            */
        }
        public Boolean checkMoves()
        {
            /*
            for (int x1 = 0; x1 < this.boardState.GetLength(0); x1++)
            {
                for (int y1 = 0; y1 < this.boardState.GetLength(1); y1++)
                {
                    int piece = boardState[x1, y1];
                    if ((piece < 0 && (this.turn == -1 || this.turn == 2)) || (piece > 0 && (this.turn == 1 || turn == -2)))
                    {
                        int[,] validPlaces = GetPieceMoves(x1, y1, this.boardState);
                        for (int x2 = 0; x2 < this.boardState.GetLength(0); x2++)
                        {
                            for (int y2 = 0; y2 < this.boardState.GetLength(1); y2++)
                            {
                                if (validPlaces[x2, y2] == 1)
                                    return true;
                            }
                        }
                    }
                }
            }
            */

            return false;
        }
    }
}
