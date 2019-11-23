namespace WindowsFormsTANK
{
    partial class FormTankConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labeltank = new System.Windows.Forms.Label();
            this.labelVehicle = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.labelDopColors = new System.Windows.Forms.Label();
            this.labelVainColors = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.groupBox.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonCansel);
            this.groupBox.Controls.Add(this.buttonAdd);
            this.groupBox.Controls.Add(this.labeltank);
            this.groupBox.Controls.Add(this.labelVehicle);
            this.groupBox.Location = new System.Drawing.Point(10, 15);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(173, 407);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "тип машины";
            // 
            // buttonCansel
            // 
            this.buttonCansel.Location = new System.Drawing.Point(12, 192);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(148, 23);
            this.buttonCansel.TabIndex = 3;
            this.buttonCansel.Text = "отмена";
            this.buttonCansel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 157);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(142, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // labeltank
            // 
            this.labeltank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeltank.Location = new System.Drawing.Point(6, 30);
            this.labeltank.Name = "labeltank";
            this.labeltank.Size = new System.Drawing.Size(131, 34);
            this.labeltank.TabIndex = 1;
            this.labeltank.Text = "Tank";
            this.labeltank.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Labeltank_MouseDown);
            // 
            // labelVehicle
            // 
            this.labelVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVehicle.Location = new System.Drawing.Point(6, 81);
            this.labelVehicle.Name = "labelVehicle";
            this.labelVehicle.Size = new System.Drawing.Size(131, 34);
            this.labelVehicle.TabIndex = 0;
            this.labelVehicle.Text = "Vehicle";
            this.labelVehicle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelVehicle_MouseDown);
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.Controls.Add(this.labelDopColors);
            this.panel.Controls.Add(this.labelVainColors);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(189, 1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(356, 421);
            this.panel.TabIndex = 2;
            this.panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // labelDopColors
            // 
            this.labelDopColors.AllowDrop = true;
            this.labelDopColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColors.Location = new System.Drawing.Point(38, 359);
            this.labelDopColors.Name = "labelDopColors";
            this.labelDopColors.Size = new System.Drawing.Size(277, 41);
            this.labelDopColors.TabIndex = 2;
            this.labelDopColors.Text = "Дополнительный цвет";
            this.labelDopColors.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDopColors_DragDrop);
            this.labelDopColors.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelVainColors_DragEnter);
            // 
            // labelVainColors
            // 
            this.labelVainColors.AllowDrop = true;
            this.labelVainColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVainColors.Location = new System.Drawing.Point(38, 298);
            this.labelVainColors.Name = "labelVainColors";
            this.labelVainColors.Size = new System.Drawing.Size(277, 41);
            this.labelVainColors.TabIndex = 1;
            this.labelVainColors.Text = "Основной цвет";
            this.labelVainColors.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelVainColors_DragDrop);
            this.labelVainColors.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelVainColors_DragEnter);
            this.labelVainColors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelVehicle_MouseDown);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(26, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(313, 237);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelPink);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Location = new System.Drawing.Point(564, 20);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(226, 401);
            this.groupBoxColors.TabIndex = 3;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(113, 251);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(58, 53);
            this.panelOrange.TabIndex = 10;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(19, 251);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(58, 53);
            this.panelYellow.TabIndex = 9;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Fuchsia;
            this.panelPink.Location = new System.Drawing.Point(104, 172);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(58, 53);
            this.panelPink.TabIndex = 9;
            this.panelPink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelGreen.Location = new System.Drawing.Point(19, 172);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(58, 53);
            this.panelGreen.TabIndex = 9;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelBlue.Location = new System.Drawing.Point(104, 100);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(58, 53);
            this.panelBlue.TabIndex = 9;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(19, 100);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(58, 53);
            this.panelBlack.TabIndex = 9;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(104, 32);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(58, 53);
            this.panelRed.TabIndex = 9;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(19, 32);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(58, 53);
            this.panelWhite.TabIndex = 8;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // FormTankConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox);
            this.Name = "FormTankConfig";
            this.Text = "FormTankConfig";
            this.groupBox.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labeltank;
        private System.Windows.Forms.Label labelVehicle;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelDopColors;
        private System.Windows.Forms.Label labelVainColors;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelOrange;
    }
}