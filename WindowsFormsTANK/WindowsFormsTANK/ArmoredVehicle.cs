﻿using System.Drawing;
public abstract class ArmoredVehicle : ITransport
{
    protected float _startPosX;
    protected float _startPosY;
    protected int _pictureWidth;
    protected int _pictureHeight;
    public int MaxSpeed { protected set; get; }
    public float Weight { protected set; get; }
    public Color MainColor { protected set; get; }
    public void SetPosition(int x, int y, int width, int height)
    {
        _startPosX = x;
        _startPosY= y;
        _pictureWidth = width;
        _pictureHeight = height;
    }
    public abstract void MoveTransport(Direction direction);
    public abstract void DrawTank(Graphics g);
    public abstract ITransport Clone();
}

