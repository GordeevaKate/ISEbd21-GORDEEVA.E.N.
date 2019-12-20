using System;
using System.Drawing;

namespace WindowsFormsTANK
{
    public class Tanks : TANKVehicle
    {
        private int GunType;
        public Guns NumberOfGuns { private set; get; }
        public Color DopColor { private set; get; }
    public bool Guns1 { private set; get; }// 
    public bool Wheels { private set; get; }// 
    public bool Symbol { private set; get; }//   
    public bool ArmoredTank { private set; get; }//    armored car
 
    public Tanks(int maxSpeed, float weight, Color mainColor, Color dopColor,
         bool wheels, bool armoredTank, bool guns, bool symbol, Guns numberOfGuns) : base(maxSpeed, weight, mainColor)

        {
        GunType = new Random().Next(0, 3);
        Weight = weight;
        MaxSpeed = maxSpeed;
        MainColor = mainColor;
        DopColor = dopColor;
        Wheels = wheels;
        Guns1 = guns;
        Symbol = symbol;
        ArmoredTank = armoredTank;
    }
   
    public override void DrawTank(Graphics g)
    {
            base.DrawTank(g);
            Brush spoiler = new SolidBrush(DopColor);
            if (Guns1)
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
            IGuns guns;
            switch (GunType)
            {
                case 0:
                    guns = new SimpleGuns(_startPosX, _startPosY);
                    break;
                case 1:
                    guns = new GunsWithOneColor(_startPosX, _startPosY);
                    break;
                case 2:
                    guns = new GunsWithEllipse(_startPosX, _startPosY);
                    break;

                default:
                    guns = new SimpleGuns(_startPosX, _startPosY);
                    break;
            }
            guns.GunsDraw(g, NumberOfGuns, DopColor);
        }
    public override ITransport Clone()
    {
        return new Tanks(200, 2000, Color.Green, Color.Yellow, true, true, true, true, Guns.Three);

    }
    }
}
