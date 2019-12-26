using System;
using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsTANK
{
    public partial class FormBase : Form
    {
        MultiLevelBase basa;
        private const int countLevel = 5;
        FormTankConfig form;
        public FormBase()
        {
            InitializeComponent();
            basa = new MultiLevelBase(countLevel, pictureBoxBase.Width,
pictureBoxBase.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxBase.Width,
               pictureBoxBase.Height);
                Graphics gr = Graphics.FromImage(bmp);
                basa[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxBase.Image = bmp;

            }
        }
            private void ButtonSetTank_Click(object sender, EventArgs e)
            {
                if (listBoxLevels.SelectedIndex > -1)
                {
                    ColorDialog dialog = new ColorDialog();
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        ColorDialog dialogDop = new ColorDialog();
                        if (dialogDop.ShowDialog() == DialogResult.OK)
                        {
                            var car = new Tanks(100, 1000, dialog.Color,
                           dialogDop.Color, true,true, true, true);
                            int place = basa[listBoxLevels.SelectedIndex] + car;
                            if (place == -1)
                            {
                                MessageBox.Show("Нет свободных мест", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            Draw();
                        }
                    }
                }
            }
            private void ButtonSetVehicle_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var car = new TANKVehicle(100, 1000, dialog.Color);
                    int place = basa[listBoxLevels.SelectedIndex] + car;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }
        private void ButtonTake_Click(object sender, EventArgs e)
        {

            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var tank = basa[listBoxLevels.SelectedIndex] -
                   Convert.ToInt32(maskedTextBox.Text);
                    if (tank != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeTank.Width,
                       pictureBoxTakeTank.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        tank.SetPosition(-45, 40, pictureBoxTakeTank.Width,
                       pictureBoxTakeTank.Height);
                        tank.DrawTank(gr);
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
        }

        private void ListBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
