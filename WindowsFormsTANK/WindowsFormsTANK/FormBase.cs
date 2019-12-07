using System;
using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsTANK
{
    public partial class FormBase : Form
    {
        Base<ITransport, IGuns> basa;
        public FormBase()
        {
            InitializeComponent();
            basa = new Base<ITransport, IGuns>(20, pictureBoxBase.Width,
pictureBoxBase.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBase.Width, pictureBoxBase.Height);
            Graphics gr = Graphics.FromImage(bmp);
            basa.Draw(gr);
            pictureBoxBase.Image = bmp;
        }

        private void ButtonSetTank_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var tank = new Tanks(100, 1000, dialog.Color, dialogDop.Color,
                   true, true, true,true, Guns.Three);
                    int place = basa + tank;
                    Draw();
                }
            }
        }

        private void ButtonSetVehicle_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var vehicle = new TANKVehicle(100, 1000, dialog.Color);
                int place = basa + vehicle;
                Draw();
            }
        }

        private void ButtonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var vehicle = basa - Convert.ToInt32(maskedTextBox.Text);
                if (vehicle != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeTank.Width,
                   pictureBoxTakeTank.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    vehicle.SetPosition(-45, 40, pictureBoxTakeTank.Width,
                   pictureBoxTakeTank.Height);
                    vehicle.DrawTank(gr);
                    pictureBoxTakeTank.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeTank.Width,
                   pictureBoxTakeTank.Height);
                    pictureBoxTakeTank.Image = bmp;
                }
                Draw();
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            int place = basa / 15;
            Draw();
        }

        private void ButtonSetAll_Click(object sender, EventArgs e)
        {
            int place = basa * 15;
            Draw();
        }

        private void Buttontaketank_Click(object sender, EventArgs e)
        {
            int place = basa * 15;
            Draw();
        }

      //  private void Buttonremovetank_Click(object sender, EventArgs e)
      //  {
      //      int place = basa /\ 15;
       //     Draw();
      //  }
    }
}
