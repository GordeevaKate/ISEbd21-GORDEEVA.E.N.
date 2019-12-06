using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Collections;
public class Base<T, N> where T : class, ITransport where N : class, IGuns
{
    private Dictionary<int, T> _places;
    private N[] placesGuns;
    private int _maxCount;
    private ArrayList removed;
    private int PictureWidth { get; set; }
   private int PictureHeight { get; set; }
   private const int _placeSizeWidth = 210;
 
    private const int _placeSizeHeight  =80;
    public Base(int sizes, int pictureWidth, int pictureHeight)
    {
        _maxCount = sizes;
        placesGuns = new N[sizes];
        removed = new ArrayList();
        _places = new Dictionary<int, T>();
        PictureWidth = pictureWidth;
        PictureHeight = pictureHeight;
    }
    public static int operator +(Base<T, N> p, T tank)
    {
        if (p._places.Count == p._maxCount)
        {
            return -1;
        }
        for (int i = 0; i < p._maxCount; i++)
        {
            if (p.CheckFreePlace(i))
            {
                p._places.Add(i, tank);
                p._places[i].SetPosition(-90 + i / 5 * _placeSizeWidth + 5,
                 i % 5 * _placeSizeHeight + 28, p.PictureWidth,
                p.PictureHeight);
                return i;
            }
        }
        return -1;
    }
 public static T operator -(Base<T, N> p, int index)
    {
        if (index < 0 || index > p._maxCount)
        {
            return null;
        }
        if (!p.CheckFreePlace(index))
        { 
            T tank = p._places[index-1];
            p._places.Remove(index-1);
            return tank;
        }
        return null;
    }
    public T GetTransportByKey(int key)
    {
        return _places.ContainsKey(key) ? _places[key] : null;
    }
    private bool CheckFreePlace(int index)
    {
        return !_places.ContainsKey(index);
    }
 
    public void Draw(Graphics g)
    {
        DrawMarking(g);
        for (int i = 0; i < _maxCount; i++)
                {
            if (!CheckFreePlace(i))
            {//если место не пустое                     
                _places[i].DrawTank(g);
            }
        }     
    }
   
    private void DrawMarking(Graphics g)
    {
        Pen pen = new Pen(Color.Black, 3);
  
        g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
        for (int i = 0; i < _maxCount / 5; i++)
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
    

