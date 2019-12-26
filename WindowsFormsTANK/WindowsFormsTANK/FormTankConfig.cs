using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTANK
{
    public partial class FormTankConfig : Form
    {
        ITransport tank = null;
        private event TankDelegate eventAddTank;
        private void DrawTank()
        {
            if (tank != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxForVehicle.Width, pictureBoxForVehicle.Height);
                Graphics gr = Graphics.FromImage(bmp);
                tank.SetPosition(5, 5, pictureBoxForVehicle.Width, pictureBoxForVehicle.Height);
                tank.DrawTank(gr);
                pictureBoxForVehicle.Image = bmp;
            }
        }
        public FormTankConfig()
        {
            InitializeComponent();
        }

        private void LabelTanks_MouseDown(object sender, MouseEventArgs e)
        {
            labelTank.DoDragDrop(labelTank.Text, DragDropEffects.Move |
            DragDropEffects.Copy);
        }

        private void LabelVehicle_MouseDown(object sender, MouseEventArgs e)
        {
            labelVehicle.DoDragDrop(labelVehicle.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }
        private void PanelForVehicle_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Vehicle":
                    tank = new TANKVehicle(100, 500, Color.White);
                    break;
                case "Tank":
                    tank = new Tanks(100, 500, Color.White, Color.Black, true, true, true,
                   true);
                    break;
            }
            DrawTank();
        }

        private void PanelForVehicle_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

       
    }
}
