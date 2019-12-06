using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
public class SimpleGuns : IGuns
{
    public float _startPosX;
    public float _startPosY;
    public SimpleGuns(float x, float y)
    {
        _startPosX = x;
        _startPosY = y;
    }
    public void GunsDraw(Graphics g, Guns numberOfGuns, Color color)
    {
        int n = (int)numberOfGuns;
        Brush br1 = new SolidBrush(color);
        g.FillRectangle(br1, _startPosX + 22, _startPosY + 5, 47, 15);
        Pen pen = new Pen(Color.Black);
        if (n >= 0)
        {
            g.FillRectangle(br1, _startPosX + 145, _startPosY - 20, 35, 4);
            if (n >= 1)
            {
                g.FillRectangle(br1, _startPosX + 160, _startPosY - 10, 35, 8);
                if (n >= 2)
                {
                    g.FillRectangle(br1, _startPosX + 185, _startPosY + 10, 35, 8);
                }
            }
        }





    }
}