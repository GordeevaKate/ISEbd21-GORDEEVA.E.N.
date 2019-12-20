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
            panelYellow.MouseDown +=panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
           panelWhite.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;            buttonCansel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
           DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void DrawTanks()
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
        private void LabelVehicle_MouseDown(object sender, MouseEventArgs e)
        {
            labelVehicle.DoDragDrop(labelVehicle.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void Labeltank_MouseDown(object sender, MouseEventArgs e)
        {
            labeltank.DoDragDrop(labeltank.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void PanelVehicle_DragEnter(object sender, DragEventArgs e)
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

        private void PanelVehicle_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Vehicle":
                    tank = new TANKVehicle(100, 500, Color.White);
                    break;
                case "Tank":
                    tank = new Tanks(100, 500, Color.White, Color.Black,true, true, true,
                   true);
                    break;
            }
            DrawTanks();
        }

        private void LabelMainColors_DragDrop(object sender, DragEventArgs e)
        {
            if (tank != null)
            {
                tank.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawTanks();
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
        private void LabelDopColors_DragDrop(object sender, DragEventArgs e)
        {
            if (tank != null)
            {
                if (tank is Tanks)
                {
                    (tank as
                   Tanks).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawTanks();
                }
            }
        }
        private void LabelMainColors_DragEnter(object sender, DragEventArgs e)
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

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            eventAddTank?.Invoke(tank);
            Close();
        }
        private void PanelWhite_MouseDown(object sender, MouseEventArgs e)
        {
            panelWhite.DoDragDrop(labeltank.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void PanelRed_MouseDown(object sender, MouseEventArgs e)
        {
            panelRed.DoDragDrop(labeltank.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

      
    }
}
