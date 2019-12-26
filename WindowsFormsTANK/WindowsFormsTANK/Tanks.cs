using System;
using System.Drawing;
namespace WindowsFormsTANK
{
    public class Tanks : TANKVehicle
    {

        public bool Guns { private set; get; }
        public Color DopColor { private set; get; }
    public bool Wheels { private set; get; }
    public bool Symbol { private set; get; }
    public bool ArmoredTank { private set; get; }
 
    public Tanks(int maxSpeed, float weight, Color mainColor, Color dopColor,
    bool wheels, bool armoredTank, bool guns, bool symbol) : base(maxSpeed, weight, mainColor)

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
        public void SetSecondaryColor(Color color)
        {
            DopColor = color;
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
            if (Symbol)
            {
                Pen sp = new Pen(DopColor);
                g.DrawLine(sp, _startPosX + 150, _startPosY + 18, _startPosX + 125, _startPosY + 5);
                g.DrawLine(sp, _startPosX + 150, _startPosY + 5, _startPosX + 125, _startPosY + 18);
            }        
        }
        public Tanks(string info) : base(info)
        {
            Console.WriteLine(info);
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Wheels = Convert.ToBoolean(strs[4]);
                ArmoredTank = Convert.ToBoolean(strs[5]);
                Guns = Convert.ToBoolean(strs[6]);
                Symbol = Convert.ToBoolean(strs[7]);
            }
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Wheels + ";" +
            ArmoredTank + ";" + Guns + ";" + Symbol;
        }
    }
}
