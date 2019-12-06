using System;
using System.Drawing;


public class GunsWithPattern : IGuns
{
    public float _startPosX;
    public float _startPosY;
    public GunsWithPattern(float x, float y)
    {
        _startPosX = x;
        _startPosY = y;
    }
   

    public void GunsDraw(Graphics g, Guns numberOfGuns, Color color)
    {
        int n = (int)numberOfGuns;
        Brush br1 = new SolidBrush(color);
        Brush br2 = new SolidBrush(Color.White);
        Brush br3 = new SolidBrush(Color.Blue);
        Brush br4 = new SolidBrush(Color.Red);

        if (n >= 0)
        {
            g.FillRectangle(br1, _startPosX + 145, _startPosY - 20, 35, 4);
            g.FillRectangle(br2, _startPosX + 170, _startPosY - 22, 20, 8);
            if (n >= 1)
            {
                g.FillRectangle(br1, _startPosX + 160, _startPosY - 10, 35, 8);
                g.FillRectangle(br3, _startPosX + 195, _startPosY - 12, 20, 12);
                if (n >= 2)
                {
                    g.FillRectangle(br1, _startPosX + 185, _startPosY + 10, 35, 8);
                    g.FillRectangle(br4, _startPosX + 220, _startPosY + 8, 20, 12);
                }
            }
        }
       
    }
}