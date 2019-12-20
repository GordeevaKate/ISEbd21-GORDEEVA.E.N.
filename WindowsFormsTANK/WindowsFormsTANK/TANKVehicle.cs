using System.Drawing;
namespace WindowsFormsTANK
{
    public class TANKVehicle : ArmoredVehicle
    {
        public TANKVehicle(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - 245)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > -85)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 20)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - 60)

                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTank(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush spoiler = new SolidBrush(MainColor);
            g.FillRectangle(spoiler, _startPosX + 105, _startPosY - 15, 59, 25);
            Brush sp2 = new SolidBrush(MainColor);
            g.FillRectangle(sp2, _startPosX + 95, _startPosY + 1, 89, 35);
            g.FillRectangle(sp2, _startPosX + 125, _startPosY - 25, 30, 15);
            g.FillEllipse(spoiler, _startPosX + 80, _startPosY + 15, 120, 30);
            Brush pen2 = new SolidBrush(Color.Black);
            g.FillEllipse(pen2, _startPosX + 90, _startPosY + 25, 15, 15);
            g.FillEllipse(pen2, _startPosX + 180, _startPosY + 25, 15, 15);
            g.FillEllipse(pen2, _startPosX + 120, _startPosY + 25, 15, 15);
            g.FillEllipse(pen2, _startPosX + 150, _startPosY + 25, 15, 15);         
        }

    }
}
