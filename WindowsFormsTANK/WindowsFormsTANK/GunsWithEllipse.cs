using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

public class GunsWithEllipse : IGuns
{
    public float _startPosX;
    public float _startPosY;
    public GunsWithEllipse(float x, float y)
    {
        _startPosX = x;
        _startPosY = y;
    }
    public void GunsDraw(Graphics g, Guns numberOfGuns, Color color)
    {
        int n = (int)numberOfGuns;
        Brush br1 = new SolidBrush(color);
           if (n >= 0)
        {
            g.FillRectangle(br1, _startPosX + 145, _startPosY - 20, 35, 4);
            g.FillEllipse(br1, _startPosX + 210, _startPosY + 8, 20, 12); if (n >= 1)
            {
                g.FillRectangle(br1, _startPosX + 160, _startPosY - 10, 35, 8);
                g.FillEllipse(br1, _startPosX + 185, _startPosY - 12, 20, 12); if (n >= 2)
                {
                    g.FillRectangle(br1, _startPosX + 185, _startPosY + 10, 35, 8);
                    g.FillEllipse(br1, _startPosX + 165, _startPosY - 22, 20, 8);
                }
            }
        }
    }
}
