using System.Drawing;
public class DrawShapeOfGuns3 : IShapeOfGuns
{
    float x;
    float y;
    public DrawShapeOfGuns3(float _startPosX, float _startPosY)
    {
        x = _startPosX;
        y = _startPosY;
    }
    public void DrawShape(Graphics g, Color DopColor)
    {
        Brush spoiler = new SolidBrush(DopColor);
        g.FillEllipse(spoiler, x + 210, y + 28, 20, 32);
        g.FillEllipse(spoiler, x + 185, y - 62, 20, 62);
        g.FillEllipse(spoiler, x + 165, y - 42, 20, 28);
    }
}