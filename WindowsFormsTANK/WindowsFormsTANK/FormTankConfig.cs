using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTANK
{
    public partial class FormTankConfig : Form
    {
        ITransport tank = null;
        private event TankDelegate eventAddTank;
        public FormTankConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelPurple.MouseDown += panelColor_MouseDown;
            panelFuchsia.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;            buttonCansel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawTank()
        {
            if (tank != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxForVehicle.Width, pictureBoxForVehicle.Height);
                Graphics gr = Graphics.FromImage(bmp);
                tank.SetPosition(5, 45, pictureBoxForVehicle.Width, pictureBoxForVehicle.Height);
                tank.DrawTank(gr);
                pictureBoxForVehicle.Image = bmp;
            }
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
           DragDropEffects.Move | DragDropEffects.Copy);
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
        private void LabelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (tank != null)
            {
                tank.SetPrimaryColor((Color)e.Data.GetData(typeof(Color)));
                DrawTank();
            }
        }
        public void AddEvent(TankDelegate ev)
        {
            if (eventAddTank == null)
            {
                eventAddTank = new TankDelegate(ev);
            }
            else
            {
                eventAddTank += ev;
            }
        }
        private void LabelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void LabelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (tank != null)
            {
                if (tank is Tanks)
                {
                    (tank as
                   Tanks).SetSecondaryColor((Color)e.Data.GetData(typeof(Color)));
                    DrawTank();
                }
            }
        }
        private void ButtonAdd_Click(object sender, System.EventArgs e)
        {
            eventAddTank?.Invoke(tank);
            Close();
        }

    }
}
