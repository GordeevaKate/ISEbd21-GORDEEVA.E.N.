using System.Drawing;
public class DrawShapeOfGunsEllipse : IShapeOfGuns
{
    float x;
    float y;
    public DrawShapeOfGunsEllipse(float _startPosX, float _startPosY)
    {
        x = _startPosX;
        y = _startPosY;
    }
    public void DrawShape(Graphics g, Color DopColor)
    {
        Brush spoiler = new SolidBrush(DopColor);
        g.FillEllipse(spoiler, x + 210, y + 8, 20, 12);
        g.FillEllipse(spoiler, x + 185, y - 12, 20, 12);
        g.FillEllipse(spoiler, x + 165, y - 22, 20, 8);
    }
}

