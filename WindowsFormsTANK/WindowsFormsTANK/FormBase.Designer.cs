namespace WindowsFormsTANK
{
    partial class FormBase
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
            this.pictureBoxBase = new System.Windows.Forms.PictureBox();
            this.buttonSetVehicle = new System.Windows.Forms.Button();
            this.groupBoxBase = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeTank = new System.Windows.Forms.PictureBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.labelBaseTank = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelBase = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.afqkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Sort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).BeginInit();
            this.groupBoxBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTank)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBase
            // 
            this.pictureBoxBase.Location = new System.Drawing.Point(-1, 28);
            this.pictureBoxBase.Name = "pictureBoxBase";
            this.pictureBoxBase.Size = new System.Drawing.Size(873, 478);
            this.pictureBoxBase.TabIndex = 0;
            this.pictureBoxBase.TabStop = false;
            // 
            // buttonSetVehicle
            // 
            this.buttonSetVehicle.Location = new System.Drawing.Point(878, 129);
            this.buttonSetVehicle.Name = "buttonSetVehicle";
            this.buttonSetVehicle.Size = new System.Drawing.Size(101, 24);
            this.buttonSetVehicle.TabIndex = 2;
            this.buttonSetVehicle.Text = "припарковать";
            this.buttonSetVehicle.UseVisualStyleBackColor = true;
            this.buttonSetVehicle.Click += new System.EventHandler(this.ButtonSetVehicle_Click);
            // 
            // groupBoxBase
            // 
            this.groupBoxBase.Controls.Add(this.pictureBoxTakeTank);
            this.groupBoxBase.Controls.Add(this.buttonTake);
            this.groupBoxBase.Controls.Add(this.labelBaseTank);
            this.groupBoxBase.Controls.Add(this.maskedTextBox);
            this.groupBoxBase.Controls.Add(this.labelBase);
            this.groupBoxBase.Location = new System.Drawing.Point(879, 207);
            this.groupBoxBase.Name = "groupBoxBase";
            this.groupBoxBase.Size = new System.Drawing.Size(180, 299);
            this.groupBoxBase.TabIndex = 3;
            this.groupBoxBase.TabStop = false;
            // 
            // pictureBoxTakeTank
            // 
            this.pictureBoxTakeTank.Location = new System.Drawing.Point(5, 132);
            this.pictureBoxTakeTank.Name = "pictureBoxTakeTank";
            this.pictureBoxTakeTank.Size = new System.Drawing.Size(175, 163);
            this.pictureBoxTakeTank.TabIndex = 4;
            this.pictureBoxTakeTank.TabStop = false;
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(5, 104);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(91, 22);
            this.buttonTake.TabIndex = 3;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.ButtonTake_Click);
            // 
            // labelBaseTank
            // 
            this.labelBaseTank.AutoSize = true;
            this.labelBaseTank.Location = new System.Drawing.Point(6, 78);
            this.labelBaseTank.Name = "labelBaseTank";
            this.labelBaseTank.Size = new System.Drawing.Size(38, 13);
            this.labelBaseTank.TabIndex = 2;
            this.labelBaseTank.Text = "место";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(63, 75);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(33, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(6, 48);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(75, 13);
            this.labelBase.TabIndex = 0;
            this.labelBase.Text = "Забрать танк";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(878, 28);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(155, 95);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.ListBoxLevels_SelectedIndexChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afqkToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1258, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // afqkToolStripMenuItem
            // 
            this.afqkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.afqkToolStripMenuItem.Name = "afqkToolStripMenuItem";
            this.afqkToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.afqkToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.ЗагрузитьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(878, 159);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(101, 23);
            this.Sort.TabIndex = 6;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 506);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBoxBase);
            this.Controls.Add(this.buttonSetVehicle);
            this.Controls.Add(this.pictureBoxBase);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormBase";
            this.Text = "База";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).EndInit();
            this.groupBoxBase.ResumeLayout(false);
            this.groupBoxBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTank)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBase;
        private System.Windows.Forms.Button buttonSetVehicle;
        private System.Windows.Forms.GroupBox groupBoxBase;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.PictureBox pictureBoxTakeTank;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Label labelBaseTank;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem afqkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button Sort;
    }
}