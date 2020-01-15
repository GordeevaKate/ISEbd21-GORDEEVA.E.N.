using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System;
using System.Collections;
using WindowsFormsTANK;

public class Base<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Base<T>>  where T : class, ITransport
{
    private int _currentIndex;
    private Dictionary<int, T> _places;
    private int _maxCount;
    private int PictureWidth { get; set; }
   private int PictureHeight { get; set; }
   private const int _placeSizeWidth = 210;
 
    private const int _placeSizeHeight  =80;
    public Base(int sizes, int pictureWidth, int pictureHeight)
    {
        _maxCount = sizes;
        _places = new Dictionary<int, T>();
        PictureWidth = pictureWidth;
        PictureHeight = pictureHeight;
    }
    public int GetKey
    {
        get
        {
            return _places.Keys.ToList()[_currentIndex];
        }
    }
    public T Current
    {
        get
        {
            return _places[_places.Keys.ToList()[_currentIndex]];
        }
    }
    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }
    public void Dispose()
    {
        _places.Clear();
    }

    public bool MoveNext()
    {
        if (_currentIndex + 1 >= _places.Count)
        {
            Reset();
            return false;
        }
        _currentIndex++;
        return true;
    }

    public void Reset()
    {
        _currentIndex = -1;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int CompareTo(Base<T> other)
    {
        if (_places.Count > other._places.Count)
        {
            return -1;
        }
        else if (_places.Count < other._places.Count)
        {
            return 1;
        }
        else if (_places.Count > 0)
        {
            var thisKeys = _places.Keys.ToList();
            var otherKeys = other._places.Keys.ToList();
            for (int i = 0; i < _places.Count; ++i)
            {
                if (_places[thisKeys[i]] is TANKVehicle && other._places[thisKeys[i]] is
               Tanks)
                {
                    return 1;
                }
                if (_places[thisKeys[i]] is Tanks && other._places[thisKeys[i]]
                is TANKVehicle)
                {
                    return -1;
                }
                if (_places[thisKeys[i]] is TANKVehicle && other._places[thisKeys[i]] is
                TANKVehicle)
                {
                    return (_places[thisKeys[i]] is
                  TANKVehicle).CompareTo(other._places[thisKeys[i]] is TANKVehicle);
                }
                if (_places[thisKeys[i]] is Tanks && other._places[thisKeys[i]]
                is Tanks)
                {
                    return (_places[thisKeys[i]] is
                   Tanks).CompareTo(other._places[thisKeys[i]] is Tanks);
                }
            }
        }
        return 0;
    }
    public static int operator +(Base<T> p, T tank)
    {
        if (p._places.Count == p._maxCount)
        {
            throw new BasaOverflowException();
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
 public static T operator -(Base<T> p, int index)
    {
        if (!p.CheckFreePlace(index))      
       {
            T tank = p._places[index-1];
            p._places.Remove(index-1);
            return tank;
        }
        throw new BasaNotFoundException(index);
    }
    private bool CheckFreePlace(int index)
    {
        return !_places.ContainsKey(index);
    }
    public void Draw(Graphics g)
    {
        DrawMarking(g);
        var keys = _places.Keys.ToList();
        for (int i = 0; i < keys.Count; i++)
        {
                _places[i].DrawTank(g);
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
    public T this[int ind]
    {
        get
        {
            if (_places.ContainsKey(ind))
            {
                return _places[ind];
            }
            throw new BasaNotFoundException(ind);
        }
        set
        {
            if (CheckFreePlace(ind))
            {
                _places.Add(ind, value);
                _places[ind].SetPosition(-55 + ind / 5 * _placeSizeWidth + 5,
                 ind % 5 * _placeSizeHeight + 28, PictureWidth, PictureHeight);
            }
            else
            {
                throw new BasaOccupiedPlaceException(ind);
            }
        }
    }
}
    

