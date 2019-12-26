using System;
using System.Windows.Forms;
using System.Drawing;
using NLog;
namespace WindowsFormsTANK
{
    public partial class FormBase : Form
    {
        private Logger logger;
        MultiLevelBase basa;
        private const int countLevel = 5;
        FormTankConfig form;
        public FormBase()
        {
            logger = LogManager.GetCurrentClassLogger();
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
                    try {
                        var tank = basa[listBoxLevels.SelectedIndex] -
                       Convert.ToInt32(maskedTextBox.Text);

                        Bitmap bmp = new Bitmap(pictureBoxTakeTank.Width,
                       pictureBoxTakeTank.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        tank.SetPosition(-45, 40, pictureBoxTakeTank.Width,
                       pictureBoxTakeTank.Height);
                        tank.DrawTank(gr);
                        pictureBoxTakeTank.Image = bmp;
                        logger.Info("Изъят tank " + tank.ToString() + " с места "
                           + maskedTextBox.Text);
                    }
                    catch (BasaNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
    MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTakeTank.Width,
                            pictureBoxTakeTank.Height);
                        pictureBoxTakeTank.Image = bmp;
                        logger.Error("Парковка не найдена");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.Error("Неизвестная ошибка");
                    }
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
                try
                {
                    int place = basa[listBoxLevels.SelectedIndex] + tank;
                    logger.Info("Добавлен tank " + tank.ToString() + " на место "
   + place);
                    Draw();
                }
                catch (BasaOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error); logger.Error("Переполнение парковки");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка");
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
                try
                {
                    basa.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                 MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    logger.Error("Неизвестная ошибка при сохранении");
                }


            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try  {

                   basa.LoadData(openFileDialog.FileName);
                  
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (BasaOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Место занято");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка при загрузке");
                }
                Draw();
            }
        }
    }
}
