
using System.Drawing;
public class DrawGuns {
   
    public Guns guns { private get; set; }
    float x;
    float y;
    Color dopcolor;
    public DrawGuns(Guns numberOfGuns,float _startPosX, float _startPosY, Color DopColor)
    {
        dopcolor = DopColor;
        guns = numberOfGuns;
        x = _startPosX;
        y = _startPosY;
    }
    private int ConvertToInt(Guns numberOfGuns)
    {
        return (int)numberOfGuns + 1;
    }
    public void GunsDraw(Graphics g)
    {
        Pen pen = new Pen(Color.Black);
        int n = ConvertToInt(guns);
        if ((n >= 1)&&(n<=3)) {
            Brush spoiler = new SolidBrush(dopcolor);
            g.FillRectangle(spoiler, x + 185, y + 10, 35, 8);
            if (n >= 2)
            {
            
                g.FillRectangle(spoiler, x + 160, y - 10, 35, 8);
                if (n == 3)
                {

                    g.FillRectangle(spoiler, x + 145, y - 20, 35, 4);
                }

            }
        }
      
    }
}
