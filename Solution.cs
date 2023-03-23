﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazeing
{
    public class Solution
    {
        // === ATTRIBUTES ======================================================================
        private Maze maze;
        private string algorithm;
        private long execTime;
        private int visitedNode;
        private Route route;
        private int treasureFound;

        // === CONSTRUCTOR =====================================================================
        public Solution(int id, Maze maze)
        {
            this.maze = maze;

            if (id == 0)
            {
                this.algorithm = "BFS";
            }
            else
            {
                this.algorithm = "DFS";
            }

            this.execTime = 0;
            this.visitedNode = 0;
            this.route = new Route();
            this.treasureFound = 0;
        }

        // === GETTER SETTER ===================================================================
        public Maze Maze
        {
            get { return this.maze; }
            set { this.maze = value; }
        }

        public long ExecTime
        {
            get { return this.execTime; }
            set { this.execTime = value; }
        }
    }
}
