﻿using System.Drawing;
    interface ITransport
   {
        void SetPosition(int x, int y, int width, int height);
        void MoveTransport(Direction direction);
        void DrawTank(Graphics g);
    }


