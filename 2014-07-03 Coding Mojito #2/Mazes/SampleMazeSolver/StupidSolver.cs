﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mazes.Core;

namespace SampleMazeSolver
{
    public class StupidSolver: IMazeSolver, IDisposable
    {
        private IMaze Maze;
        private IMouse Mouse;

        public void Init(IMaze maze, IMouse mouse)
        {
            Maze = maze;
            Mouse = mouse;
        }

        public void YourTurn()
        {
            if(Maze.CanIMove())
                Mouse.Move();
            else
                Mouse.TurnLeft();            
        }

        public void YouWin()
        {
            ReleaseInterfaces();            
        }

        public void YouLoose()
        {
            ReleaseInterfaces();            
        }

        private void ReleaseInterfaces()
        {
            Maze = null;
            Mouse = null;            
        }

        public void Dispose()
        {
            ReleaseInterfaces();
        }
    }
}
