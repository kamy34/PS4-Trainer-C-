﻿namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    partial class DBZF
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBZF));
            this.btnAttach = new theme.FlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tglHealth = new theme.FlatToggle();
            this.flatLabel2 = new theme.FlatLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numEXP = new theme.FlatNumeric();
            this.flatLabel1 = new theme.FlatLabel();
            this.btnEXP = new theme.FlatButton();
            this.tmrHealth = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.numZeni = new theme.FlatNumeric();
            this.flatLabel3 = new theme.FlatLabel();
            this.btnZeni = new theme.FlatButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numPZC = new theme.FlatNumeric();
            this.flatLabel4 = new theme.FlatLabel();
            this.btnPZC = new theme.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.Transparent;
            this.btnAttach.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAttach.Location = new System.Drawing.Point(394, 3);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Rounded = false;
            this.btnAttach.Size = new System.Drawing.Size(118, 44);
            this.btnAttach.TabIndex = 104;
            this.btnAttach.Text = "Attach";
            this.btnAttach.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(351, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 103;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 28);
            this.label4.TabIndex = 101;
            this.label4.Text = "Cheater : Kraken";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label3.Location = new System.Drawing.Point(389, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 100;
            this.label3.Text = "CUSA08992";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(312, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 99;
            this.label1.Text = "Game Version : 1.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 349);
            this.panel1.TabIndex = 102;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.tglHealth);
            this.panel4.Controls.Add(this.flatLabel2);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 73);
            this.panel4.TabIndex = 47;
            // 
            // tglHealth
            // 
            this.tglHealth.BackColor = System.Drawing.Color.Transparent;
            this.tglHealth.Checked = false;
            this.tglHealth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglHealth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglHealth.Location = new System.Drawing.Point(287, 19);
            this.tglHealth.Name = "tglHealth";
            this.tglHealth.Options = theme.FlatToggle._Options.Style3;
            this.tglHealth.Size = new System.Drawing.Size(76, 33);
            this.tglHealth.TabIndex = 5;
            this.tglHealth.Text = "flatToggle1";
            this.tglHealth.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglHealth_CheckedChanged);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(13, 24);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(103, 20);
            this.flatLabel2.TabIndex = 2;
            this.flatLabel2.Text = "Infinite Health";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.numEXP);
            this.panel3.Controls.Add(this.flatLabel1);
            this.panel3.Controls.Add(this.btnEXP);
            this.panel3.Location = new System.Drawing.Point(381, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 73);
            this.panel3.TabIndex = 46;
            // 
            // numEXP
            // 
            this.numEXP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numEXP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numEXP.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.numEXP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numEXP.ForeColor = System.Drawing.Color.White;
            this.numEXP.Location = new System.Drawing.Point(103, 20);
            this.numEXP.Maximum = ((long)(9999999));
            this.numEXP.Minimum = ((long)(0));
            this.numEXP.Name = "numEXP";
            this.numEXP.Size = new System.Drawing.Size(145, 30);
            this.numEXP.TabIndex = 3;
            this.numEXP.Text = "flatNumeric1";
            this.numEXP.Value = ((long)(0));
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(13, 24);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(34, 20);
            this.flatLabel1.TabIndex = 2;
            this.flatLabel1.Text = "EXP";
            // 
            // btnEXP
            // 
            this.btnEXP.BackColor = System.Drawing.Color.Transparent;
            this.btnEXP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnEXP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEXP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEXP.Location = new System.Drawing.Point(254, 14);
            this.btnEXP.Name = "btnEXP";
            this.btnEXP.Rounded = false;
            this.btnEXP.Size = new System.Drawing.Size(112, 44);
            this.btnEXP.TabIndex = 0;
            this.btnEXP.Text = "Set";
            this.btnEXP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnEXP.Click += new System.EventHandler(this.btnEXP_Click);
            // 
            // tmrHealth
            // 
            this.tmrHealth.Interval = 500;
            this.tmrHealth.Tick += new System.EventHandler(this.tmrHealth_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.numZeni);
            this.panel2.Controls.Add(this.flatLabel3);
            this.panel2.Controls.Add(this.btnZeni);
            this.panel2.Location = new System.Drawing.Point(3, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 73);
            this.panel2.TabIndex = 47;
            // 
            // numZeni
            // 
            this.numZeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numZeni.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numZeni.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.numZeni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numZeni.ForeColor = System.Drawing.Color.White;
            this.numZeni.Location = new System.Drawing.Point(103, 20);
            this.numZeni.Maximum = ((long)(9999999));
            this.numZeni.Minimum = ((long)(0));
            this.numZeni.Name = "numZeni";
            this.numZeni.Size = new System.Drawing.Size(145, 30);
            this.numZeni.TabIndex = 3;
            this.numZeni.Text = "flatNumeric1";
            this.numZeni.Value = ((long)(0));
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(13, 24);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(38, 20);
            this.flatLabel3.TabIndex = 2;
            this.flatLabel3.Text = "Zeni";
            // 
            // btnZeni
            // 
            this.btnZeni.BackColor = System.Drawing.Color.Transparent;
            this.btnZeni.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnZeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZeni.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnZeni.Location = new System.Drawing.Point(254, 14);
            this.btnZeni.Name = "btnZeni";
            this.btnZeni.Rounded = false;
            this.btnZeni.Size = new System.Drawing.Size(112, 44);
            this.btnZeni.TabIndex = 0;
            this.btnZeni.Text = "Set";
            this.btnZeni.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnZeni.Click += new System.EventHandler(this.btnZeni_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel5.Controls.Add(this.numPZC);
            this.panel5.Controls.Add(this.flatLabel4);
            this.panel5.Controls.Add(this.btnPZC);
            this.panel5.Location = new System.Drawing.Point(381, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(374, 73);
            this.panel5.TabIndex = 47;
            // 
            // numPZC
            // 
            this.numPZC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numPZC.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numPZC.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.numPZC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numPZC.ForeColor = System.Drawing.Color.White;
            this.numPZC.Location = new System.Drawing.Point(103, 20);
            this.numPZC.Maximum = ((long)(9999999));
            this.numPZC.Minimum = ((long)(0));
            this.numPZC.Name = "numPZC";
            this.numPZC.Size = new System.Drawing.Size(145, 30);
            this.numPZC.TabIndex = 3;
            this.numPZC.Text = "flatNumeric1";
            this.numPZC.Value = ((long)(0));
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(9, 18);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(85, 40);
            this.flatLabel4.TabIndex = 2;
            this.flatLabel4.Text = "Premium Z \r\nCoins";
            // 
            // btnPZC
            // 
            this.btnPZC.BackColor = System.Drawing.Color.Transparent;
            this.btnPZC.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnPZC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPZC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPZC.Location = new System.Drawing.Point(254, 14);
            this.btnPZC.Name = "btnPZC";
            this.btnPZC.Rounded = false;
            this.btnPZC.Size = new System.Drawing.Size(112, 44);
            this.btnPZC.TabIndex = 0;
            this.btnPZC.Text = "Set";
            this.btnPZC.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnPZC.Click += new System.EventHandler(this.btnPZC_Click);
            // 
            // DBZF
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "DBZF";
            this.Size = new System.Drawing.Size(758, 455);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private theme.FlatButton btnAttach;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private theme.FlatToggle tglHealth;
        private theme.FlatLabel flatLabel2;
        private System.Windows.Forms.Panel panel3;
        private theme.FlatNumeric numEXP;
        private theme.FlatLabel flatLabel1;
        private theme.FlatButton btnEXP;
        private System.Windows.Forms.Timer tmrHealth;
        private System.Windows.Forms.Panel panel5;
        private theme.FlatNumeric numPZC;
        private theme.FlatLabel flatLabel4;
        private theme.FlatButton btnPZC;
        private System.Windows.Forms.Panel panel2;
        private theme.FlatNumeric numZeni;
        private theme.FlatLabel flatLabel3;
        private theme.FlatButton btnZeni;
    }
}
