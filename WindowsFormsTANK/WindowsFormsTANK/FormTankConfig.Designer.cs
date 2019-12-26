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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelTanks = new System.Windows.Forms.Label();
            this.labelVehicle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(267, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(265, 152);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelVehicle);
            this.groupBox.Controls.Add(this.labelTanks);
            this.groupBox.Location = new System.Drawing.Point(19, 20);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(213, 367);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "тип бронемашины";
            // 
            // labelTanks
            // 
            this.labelTanks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTanks.Location = new System.Drawing.Point(14, 47);
            this.labelTanks.Name = "labelTanks";
            this.labelTanks.Size = new System.Drawing.Size(167, 40);
            this.labelTanks.TabIndex = 0;
            this.labelTanks.Text = "Tank";
            this.labelTanks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTanks_MouseDown);
            // 
            // labelVehicle
            // 
            this.labelVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVehicle.Location = new System.Drawing.Point(17, 110);
            this.labelVehicle.Name = "labelVehicle";
            this.labelVehicle.Size = new System.Drawing.Size(169, 33);
            this.labelVehicle.TabIndex = 1;
            this.labelVehicle.Text = "Vehicle";
            // 
            // FormTankConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "FormTankConfig";
            this.Text = "выбор танка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelVehicle;
        private System.Windows.Forms.Label labelTanks;
    }
}