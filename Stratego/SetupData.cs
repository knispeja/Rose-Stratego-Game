﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    /// <summary>
    /// Simple data structure to hold any save data passed to and from setup save/load operations
    /// </summary>
    public struct SetupData
    {
        public Gameboard boardState { get; private set; }
        public Dictionary<String, int> placements { get; private set; }
        public int turn { get; private set; }

        public SetupData(Gameboard boardState, Dictionary<String, int> placements, int turn) : this()
        {
            this.boardState = boardState;
            this.placements = placements;
            this.turn = turn;
        }
    }
}
