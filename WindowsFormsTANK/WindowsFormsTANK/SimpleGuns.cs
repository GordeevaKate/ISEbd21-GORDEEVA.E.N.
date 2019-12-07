


using System.Drawing;

class SimpleGuns : IGuns
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


        Pen pen = new Pen(color);
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
