﻿using System;
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
        private void AddTank(ITransport tank)
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
                    MessageBox.Show("Тank не удалось поставить :(");
                }
            }
        }
        private void ButtonRequestTank_Click_1(object sender, EventArgs e)
        {
            form = new FormTankConfig();
            form.AddEvent(AddTank);
            form.Show();
        }
        private void SaveToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void SaveLavelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFIleDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (basa.SaveLevel(listBoxLevels.SelectedIndex, loadFIleDialog.FileName))
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

        private void LoadLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (basa.LoadLevel(listBoxLevels.SelectedIndex, openFileDialog.FileName))
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
