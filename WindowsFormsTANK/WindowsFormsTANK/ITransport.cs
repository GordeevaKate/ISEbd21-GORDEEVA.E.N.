using System.Drawing;
  public  interface ITransport
   {
        void SetPosition(int x, int y, int width, int height);
        void MoveTransport(Direction direction);
        void DrawTank(Graphics g);
    void SetMainColor(Color color);
}


