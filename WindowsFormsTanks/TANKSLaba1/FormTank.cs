using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace WindowsFormsTanks
{
    public partial class FormTank : Form
    {

        private Tanks tank;
        public FormTank()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTanks.Width, pictureBoxTanks.Height);
            Graphics gr = Graphics.FromImage(bmp);         
            tank.DrawTank(gr);
            pictureBoxTanks.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tank.MoveTransport(Direction.Left);
            Draw();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            tank = new Tanks(200, 2000, Color.Green, Color.Yellow, true, true,true, true, true  ); 
       
            tank.SetPosition(50, 50, pictureBoxTanks.Width,
             pictureBoxTanks.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    tank.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    tank.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    tank.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    tank.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void ButtonUp_Click(object sender, EventArgs e)
        {
            tank.MoveTransport(Direction.Up);
            Draw();
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            tank.MoveTransport(Direction.Right);
            Draw();
        }
        private void ButtonDown_Click(object sender, EventArgs e)
        {
            
            tank.MoveTransport(Direction.Down);
           
            Draw();
        }
    }
}
