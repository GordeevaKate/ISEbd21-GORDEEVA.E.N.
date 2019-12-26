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
            this.labelVehicle = new System.Windows.Forms.Label();
            this.labelTank = new System.Windows.Forms.Label();
            this.panelForVehicle = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.pictureBoxForVehicle = new System.Windows.Forms.PictureBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelFuchsia = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.groupBox.SuspendLayout();
            this.panelForVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForVehicle)).BeginInit();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonCansel);
            this.groupBox.Controls.Add(this.buttonAdd);
            this.groupBox.Controls.Add(this.labelVehicle);
            this.groupBox.Controls.Add(this.labelTank);
            this.groupBox.Location = new System.Drawing.Point(19, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(213, 375);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "тип бронемашины";
            // 
            // buttonCansel
            // 
            this.buttonCansel.Location = new System.Drawing.Point(14, 261);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(169, 32);
            this.buttonCansel.TabIndex = 3;
            this.buttonCansel.Text = "отмена";
            this.buttonCansel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(17, 201);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(169, 32);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // labelVehicle
            // 
            this.labelVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVehicle.Location = new System.Drawing.Point(17, 110);
            this.labelVehicle.Name = "labelVehicle";
            this.labelVehicle.Size = new System.Drawing.Size(169, 33);
            this.labelVehicle.TabIndex = 1;
            this.labelVehicle.Text = "Vehicle";
            this.labelVehicle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelVehicle_MouseDown);
            // 
            // labelTank
            // 
            this.labelTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTank.Location = new System.Drawing.Point(14, 47);
            this.labelTank.Name = "labelTank";
            this.labelTank.Size = new System.Drawing.Size(167, 40);
            this.labelTank.TabIndex = 0;
            this.labelTank.Text = "Tank";
            this.labelTank.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTanks_MouseDown);
            // 
            // panelForVehicle
            // 
            this.panelForVehicle.AllowDrop = true;
            this.panelForVehicle.Controls.Add(this.labelDopColor);
            this.panelForVehicle.Controls.Add(this.labelMainColor);
            this.panelForVehicle.Controls.Add(this.pictureBoxForVehicle);
            this.panelForVehicle.Location = new System.Drawing.Point(252, 16);
            this.panelForVehicle.Name = "panelForVehicle";
            this.panelForVehicle.Size = new System.Drawing.Size(302, 401);
            this.panelForVehicle.TabIndex = 2;
            this.panelForVehicle.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelForVehicle_DragDrop);
            this.panelForVehicle.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelForVehicle_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(23, 345);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(249, 37);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Dop Color";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(22, 284);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(249, 37);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Main Color";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelMainColor_DragEnter);
            this.labelMainColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelVehicle_MouseDown);
            // 
            // pictureBoxForVehicle
            // 
            this.pictureBoxForVehicle.Location = new System.Drawing.Point(23, 18);
            this.pictureBoxForVehicle.Name = "pictureBoxForVehicle";
            this.pictureBoxForVehicle.Size = new System.Drawing.Size(262, 212);
            this.pictureBoxForVehicle.TabIndex = 0;
            this.pictureBoxForVehicle.TabStop = false;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelPurple);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelFuchsia);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Location = new System.Drawing.Point(572, 16);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(216, 401);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "цвета";
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(110, 257);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(52, 43);
            this.panelPurple.TabIndex = 7;
            this.panelPurple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(25, 257);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(52, 43);
            this.panelYellow.TabIndex = 6;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(110, 187);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(52, 43);
            this.panelBlue.TabIndex = 5;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelFuchsia
            // 
            this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelFuchsia.Location = new System.Drawing.Point(25, 187);
            this.panelFuchsia.Name = "panelFuchsia";
            this.panelFuchsia.Size = new System.Drawing.Size(52, 43);
            this.panelFuchsia.TabIndex = 4;
            this.panelFuchsia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(110, 119);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(52, 43);
            this.panelGreen.TabIndex = 3;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(25, 119);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(52, 43);
            this.panelWhite.TabIndex = 2;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(110, 49);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(52, 43);
            this.panelBlack.TabIndex = 1;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(25, 49);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(52, 43);
            this.panelRed.TabIndex = 0;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // FormTankConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelForVehicle);
            this.Controls.Add(this.groupBox);
            this.Name = "FormTankConfig";
            this.Text = "выбор танка";
            this.groupBox.ResumeLayout(false);
            this.panelForVehicle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForVehicle)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelVehicle;
        private System.Windows.Forms.Label labelTank;
        private System.Windows.Forms.Panel panelForVehicle;
        private System.Windows.Forms.PictureBox pictureBoxForVehicle;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelFuchsia;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.Button buttonAdd;
    }
}