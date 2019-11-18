using System.Drawing;
namespace WindowsFormsTANK
{
    public class Tanks
    { 
     public Color MainColor { private set; get; }
    public Color DopColor { private set; get; }
    public bool Guns { private set; get; }// 
    public bool Wheels { private set; get; }// 
    public bool Symbol { private set; get; }//   
    public bool ArmoredTank { private set; get; }//    armored car
    private float _startPosX;
    private float _startPosY;
    private int _pictureWidth;
    private int _pictureHeight;    public float Weight { private set; get; }
    public int MaxSpeed { private set; get; }
    public Tanks(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool frontSpoiler, bool wheels, bool armoredTank, bool guns, bool symbol)
    {
        Weight = weight;
        MaxSpeed = maxSpeed;
        MainColor = mainColor;
        DopColor = dopColor;
        Wheels = wheels;
        Guns = guns;
        Symbol = symbol;
        ArmoredTank = armoredTank;

    }
    public void SetPosition(int x, int y, int width, int height)
    {
        _startPosX = x;
        _startPosY = y;
        _pictureWidth = width;
        _pictureHeight = height;
    }
    public void MoveTransport(Direction direction)
    {
        float step = MaxSpeed * 100 / Weight;
        switch (direction)
        {
            // вправо
            case Direction.Right:
                if (_startPosX + step < _pictureWidth - 245)
                {
                    _startPosX += step;
                }
                break;
            //влево
            case Direction.Left:
                if (_startPosX - step > -85)
                {
                    _startPosX -= step;
                }
                break;
            //вверх
            case Direction.Up:
                if (_startPosY - step > 20)
                {
                    _startPosY -= step;
                }
                break;
            //вниз
            case Direction.Down:
                if (_startPosY + step < _pictureHeight - 60)

                {
                    _startPosY += step;
                }
                break;
        }
    }
    public void DrawTank(Graphics g)
    {
        Pen pen = new Pen(Color.Black);
        Brush spoiler = new SolidBrush(MainColor);
        if (ArmoredTank)
        {
            g.FillRectangle(spoiler, _startPosX + 105, _startPosY - 15, 59, 25);
            Brush sp2 = new SolidBrush(MainColor);
            g.FillRectangle(sp2, _startPosX + 95, _startPosY + 1, 89, 35);
            g.FillRectangle(sp2, _startPosX + 125, _startPosY - 25, 30, 15);
            g.FillEllipse(spoiler, _startPosX + 80, _startPosY + 15, 120, 30);
        }
        Brush dopBrush = new SolidBrush(DopColor);
        if (Wheels)
        {
            g.FillEllipse(dopBrush, _startPosX + 90, _startPosY + 25, 15, 15);
            g.FillEllipse(dopBrush, _startPosX + 180, _startPosY + 25, 15, 15);
            g.FillEllipse(dopBrush, _startPosX + 120, _startPosY + 25, 15, 15);
            g.FillEllipse(dopBrush, _startPosX + 150, _startPosY + 25, 15, 15);
        }

        if (Guns)
        {
                g.FillRectangle(spoiler, _startPosX + 145, _startPosY - 20, 35, 4);
                g.FillRectangle(spoiler, _startPosX + 160, _startPosY - 10, 35, 8);
                g.FillRectangle(spoiler, _startPosX + 185, _startPosY + 10, 35, 8);
            }

        if (Symbol)
        {
            Pen sp = new Pen(DopColor);
            g.DrawLine(sp, _startPosX + 150, _startPosY + 18, _startPosX + 125, _startPosY + 5);
            g.DrawLine(sp, _startPosX + 150, _startPosY + 5, _startPosX + 125, _startPosY + 18);
        }
    }
    }
}
