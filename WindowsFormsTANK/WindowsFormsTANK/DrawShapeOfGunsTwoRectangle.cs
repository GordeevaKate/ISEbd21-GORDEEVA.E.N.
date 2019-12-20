using System.Drawing;
public class DrawShapeOfGunsTwoRectangle : IShapeOfGuns
{
    float x;
    float y;
    public DrawShapeOfGunsTwoRectangle(float _startPosX, float _startPosY)
    {
        x = _startPosX;
        y = _startPosY;
    }
    public void DrawShape(Graphics g, Color DopColor)
    {
        Brush spoiler = new SolidBrush(DopColor);
        g.FillRectangle(spoiler, x + 210, y + 8, 20, 12);
        g.FillRectangle(spoiler, x + 185, y - 12, 20, 12);
        g.FillRectangle(spoiler, x + 165, y - 22, 20, 8);
        g.FillRectangle(spoiler, x + 222, y + 10, 18, 10);
        g.FillRectangle(spoiler, x + 197, y - 10, 18, 10);
        g.FillRectangle(spoiler, x + 173, y - 20, 18, 6);
    }
}