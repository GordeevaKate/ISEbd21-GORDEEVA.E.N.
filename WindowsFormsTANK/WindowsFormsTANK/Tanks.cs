using System.Drawing;
namespace WindowsFormsTANK
{
    public class Tanks : TANKVehicle
    { 
    public Color DopColor { private set; get; }
    public bool Guns { private set; get; }// 
    public bool Wheels { private set; get; }// 
    public bool Symbol { private set; get; }//   
    public bool Shape { private set; get; }
    public string ShapeForm;
    public bool ArmoredTank { private set; get; }//    armored car
 
    public Tanks(int maxSpeed, float weight, Color mainColor, Color dopColor,
         bool wheels, bool armoredTank, bool guns, bool symbol,bool shape, string shapeform) : base(maxSpeed, weight, mainColor)

        {
            ShapeForm = shapeform;
            Shape = shape;
            Weight = weight;
        MaxSpeed = maxSpeed;
        MainColor = mainColor;
        DopColor = dopColor;
        Wheels = wheels;
        Guns = guns;
        Symbol = symbol;
        ArmoredTank = armoredTank;
    }
   
    public override void DrawTank(Graphics g)
    {
            base.DrawTank(g);
            Brush spoiler = new SolidBrush(DopColor);
            if (Guns)
        {
                g.FillRectangle(spoiler, _startPosX + 145, _startPosY - 20, 35, 4);
                g.FillRectangle(spoiler, _startPosX + 160, _startPosY - 10, 35, 8);
                g.FillRectangle(spoiler, _startPosX + 185, _startPosY + 10, 35, 8);
            }
            if (Shape)
            {
                IShapeOfGuns shape;
                switch (ShapeForm)
                {
                    case "Rectangle":
                        shape = new DrawShapeOfGunsRectangle(_startPosX, _startPosY);
                        break;
                    case "Ellipse":
                        shape = new DrawShapeOfGunsEllipse(_startPosX, _startPosY);
                        break;
                    case "TwoRectangle":
                        shape = new DrawShapeOfGunsTwoRectangle(_startPosX, _startPosY);
                        break;
                    default:
                        shape = new DrawShapeOfGunsRectangle(_startPosX, _startPosY);
                        break;
                }
                shape.DrawShape(g, Color.Red);
            }
            base.DrawTank(g);
            if (Symbol)
            {
                Pen sp = new Pen(DopColor);
                g.DrawLine(sp, _startPosX + 150, _startPosY + 18, _startPosX + 125, _startPosY + 5);
                g.DrawLine(sp, _startPosX + 150, _startPosY + 5, _startPosX + 125, _startPosY + 18);
            }        
    }
    }
}
