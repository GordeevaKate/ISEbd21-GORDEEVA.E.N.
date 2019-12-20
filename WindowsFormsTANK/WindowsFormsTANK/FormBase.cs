using System;
using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsTANK
{
    public partial class FormBase : Form
    {
        MultiLevelBase basa;
        FormTankConfig form;
        private const int countLevel = 5;
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
      private void Draw()//
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

          
            private void ButtonSetVehicle_Click(object sender, EventArgs e)
        {
                form = new FormTankConfig();
                form.AddEvent(AddTank);
                form.Show();         
        }
        private void AddTank(ITransport tank)//
        {
            if (tank != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = basa[listBoxLevels.SelectedIndex] + tank;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }
        private void ButtonTake_Click(object sender, EventArgs e)//
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
            Draw();//
        }
        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (basa.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (basa.LoadData(openFileDialog.FileName))
                {
                 
                MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}
