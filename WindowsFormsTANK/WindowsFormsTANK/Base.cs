using System.Drawing;
using System.Collections.Generic;
public class Base<T,N> where T : class, ITransport where N : class, IGuns
{
    private T[] _places; private N[] placesGuns;
    private int PictureWidth { get; set; }
   private int PictureHeight { get; set; }
   private const int _placeSizeWidth = 210;
    private const int _placeSizeHeight  =80;
    public Base(int sizes, int pictureWidth, int pictureHeight)
    {
        _places = new T[sizes]; placesGuns = new N[sizes];
        PictureWidth = pictureWidth;
        PictureHeight = pictureHeight;
        for (int i = 0; i < _places.Length; i++)
        {
            _places[i] = null;
        }
    }
    public static int operator +(Base<T,N> p, T tank)
    {
        for (int i = 0; i < p._places.Length; i++)
        {
            if (p.CheckFreePlace(i))
            {
                p._places[i] = tank;
                p._places[i].SetPosition(-90 + i / 5 * _placeSizeWidth + 5,
                 i % 5 * _placeSizeHeight + 28, p.PictureWidth,
                p.PictureHeight);
                return i;
            }
        }
        return -1;
    }
    public static T operator -(Base<T,N> p, int index)
    {
        if (index < 0 || index > p._places.Length)
        {
            return null;
        }
        if (!p.CheckFreePlace(index))     
        {
            T tank = p._places[index-1];
            p._places[index-1] = null;
            return tank;
        }
        return null;
    }

    public static int operator *(Base<T,N> p, int size)
    {
        List<T> clones = new List<T>();
        if (p._places.Length + 1 < size)
        {
            return -1;
        }
        for (int i = 0; i < p._places.Length; i++)
        {
            if (!p.CheckFreePlace(i))
            {
                clones.Add(p._places[i]);
            }
        }
        foreach (T vehicle in clones)
        {
            for (int i = 0; i < size; i++)
            {
                T newVehicle = (T)vehicle.Clone();
                int index = p + newVehicle;
            }
        }
        return 1;
    }
    public static int operator /(Base<T,N> p, int x)
    {
        for (int i = 0; i < x; i++)
        {
            p._places[i] = null;
        }
        return 1;
    }
    private bool CheckFreePlace(int index)
    {
        return _places[index] == null;
    }
    public void Draw(Graphics g)
    {
        DrawMarking(g);
        for (int i = 0; i < _places.Length; i++)
        {
            if (!CheckFreePlace(i))
            {
                _places[i].DrawTank(g);
            }
        }
    }
    private void DrawMarking(Graphics g)
    {
        Pen pen = new Pen(Color.Black, 3);
  
        g.DrawRectangle(pen, 0, 0, (_places.Length / 5) * _placeSizeWidth, 480);
        for (int i = 0; i < _places.Length / 5; i++)
        {
            for (int j = 0; j < 6; ++j)
            {
                g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                i * _placeSizeWidth + 110, j * _placeSizeHeight);
            }
            g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
        }
    }
}
    

