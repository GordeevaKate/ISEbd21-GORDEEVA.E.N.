using System;
using System.Drawing;
namespace WindowsFormsTANK
{
    public class Tanks : TANKVehicle
    { 
    public Color DopColor { private set; get; }
    public bool Guns { private set; get; }// 
    public bool Wheels { private set; get; }// 
    public bool Symbol { private set; get; }//   
        private int GunsType;
        public Guns NumberOfGuns { private set; get; }
        public bool ArmoredTank { private set; get; }//    armored car
 
    public Tanks(int maxSpeed, float weight, Color mainColor, Color dopColor,
         bool wheels, bool armoredTank, bool guns, bool symbol, Guns numberOfGuns, int gunsType) : base(maxSpeed, weight, mainColor)

        {
            NumberOfGuns = numberOfGuns;
            GunsType = gunsType;
            Weight = weight;
        MaxSpeed = maxSpeed;
        MainColor = mainColor;
        DopColor = dopColor;
        Wheels = wheels;
        Guns = guns;
        Symbol = symbol;
        ArmoredTank = armoredTank;
            Random rnd = new Random();
        }
   
    public override void DrawTank(Graphics g)
    {
            base.DrawTank(g);
            Brush spoiler = new SolidBrush(DopColor);
            IGuns guns;
            switch (GunsType)
            {
                case 0:
                    guns = new SimpleGuns(_startPosX, _startPosY);
                    break;
                case 1:
                    guns = new GunsWithPattern(_startPosX, _startPosY);
                    break;
                case 2:
                    guns = new GunsWithAngle(_startPosX, _startPosY);
                    break;

                default:
                    guns = new SimpleGuns(_startPosX, _startPosY);
                    break;
            }
            guns.GunsDraw(g, NumberOfGuns, DopColor);
            if (Symbol)
            {
                Pen sp = new Pen(DopColor);
                g.DrawLine(sp, _startPosX + 150, _startPosY + 18, _startPosX + 125, _startPosY + 5);
                g.DrawLine(sp, _startPosX + 150, _startPosY + 5, _startPosX + 125, _startPosY + 18);
            }        
    }
        public void SetDopColor(Color color)
        {
            DopColor = color;
          
        }
        public void SetGunType(int type)
        {
            GunsType = type;
        }
    }
}
