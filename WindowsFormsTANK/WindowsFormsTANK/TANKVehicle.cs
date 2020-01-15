using System;
using System.Drawing;
namespace WindowsFormsTANK
{
    public class TANKVehicle : ArmoredVehicle, IComparable<TANKVehicle>, IEquatable<TANKVehicle>
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
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
        public TANKVehicle(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
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
        public int CompareTo(TANKVehicle other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        public bool Equals(TANKVehicle other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is TANKVehicle tankObj))
            {
                return false;
            }
            else
            {
                return Equals(tankObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
