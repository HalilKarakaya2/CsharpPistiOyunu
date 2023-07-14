namespace pisti
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_puan_rakip = new System.Windows.Forms.Label();
            this.lbl_puan_kullanici = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnl_arka = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_toplam_puan_kulla = new System.Windows.Forms.Label();
            this.lbl_toplam_puan_rakip = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcb_pisti = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pcb_cards = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bilgisayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_arka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_pisti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(256, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 112);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(296, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 120);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(256, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 112);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_puan_rakip
            // 
            this.lbl_puan_rakip.AutoSize = true;
            this.lbl_puan_rakip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_puan_rakip.Location = new System.Drawing.Point(159, 102);
            this.lbl_puan_rakip.Name = "lbl_puan_rakip";
            this.lbl_puan_rakip.Size = new System.Drawing.Size(19, 20);
            this.lbl_puan_rakip.TabIndex = 2;
            this.lbl_puan_rakip.Text = "0";
            // 
            // lbl_puan_kullanici
            // 
            this.lbl_puan_kullanici.AutoSize = true;
            this.lbl_puan_kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_puan_kullanici.Location = new System.Drawing.Point(143, 431);
            this.lbl_puan_kullanici.Name = "lbl_puan_kullanici";
            this.lbl_puan_kullanici.Size = new System.Drawing.Size(19, 20);
            this.lbl_puan_kullanici.TabIndex = 3;
            this.lbl_puan_kullanici.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(694, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pnl_arka
            // 
            this.pnl_arka.BackColor = System.Drawing.Color.Green;
            this.pnl_arka.Controls.Add(this.pictureBox4);
            this.pnl_arka.Controls.Add(this.lbl_toplam_puan_kulla);
            this.pnl_arka.Controls.Add(this.lbl_toplam_puan_rakip);
            this.pnl_arka.Controls.Add(this.pictureBox2);
            this.pnl_arka.Controls.Add(this.pcb_pisti);
            this.pnl_arka.Controls.Add(this.pictureBox3);
            this.pnl_arka.Controls.Add(this.pcb_cards);
            this.pnl_arka.Controls.Add(this.panel3);
            this.pnl_arka.Controls.Add(this.pictureBox1);
            this.pnl_arka.Controls.Add(this.panel1);
            this.pnl_arka.Controls.Add(this.lbl_puan_kullanici);
            this.pnl_arka.Controls.Add(this.panel2);
            this.pnl_arka.Controls.Add(this.lbl_puan_rakip);
            this.pnl_arka.Location = new System.Drawing.Point(534, 317);
            this.pnl_arka.Name = "pnl_arka";
            this.pnl_arka.Size = new System.Drawing.Size(904, 564);
            this.pnl_arka.TabIndex = 5;
            this.pnl_arka.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_arka_Paint);
            this.pnl_arka.MouseHover += new System.EventHandler(this.pnl_arka_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(600, 431);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(194, 106);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lbl_toplam_puan_kulla
            // 
            this.lbl_toplam_puan_kulla.AutoSize = true;
            this.lbl_toplam_puan_kulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam_puan_kulla.Location = new System.Drawing.Point(143, 470);
            this.lbl_toplam_puan_kulla.Name = "lbl_toplam_puan_kulla";
            this.lbl_toplam_puan_kulla.Size = new System.Drawing.Size(19, 20);
            this.lbl_toplam_puan_kulla.TabIndex = 11;
            this.lbl_toplam_puan_kulla.Text = "0";
            // 
            // lbl_toplam_puan_rakip
            // 
            this.lbl_toplam_puan_rakip.AutoSize = true;
            this.lbl_toplam_puan_rakip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam_puan_rakip.Location = new System.Drawing.Point(159, 138);
            this.lbl_toplam_puan_rakip.Name = "lbl_toplam_puan_rakip";
            this.lbl_toplam_puan_rakip.Size = new System.Drawing.Size(19, 20);
            this.lbl_toplam_puan_rakip.TabIndex = 10;
            this.lbl_toplam_puan_rakip.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pcb_pisti
            // 
            this.pcb_pisti.Location = new System.Drawing.Point(22, 257);
            this.pcb_pisti.Name = "pcb_pisti";
            this.pcb_pisti.Size = new System.Drawing.Size(156, 120);
            this.pcb_pisti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_pisti.TabIndex = 5;
            this.pcb_pisti.TabStop = false;
            this.pcb_pisti.Tag = "1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 407);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(126, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pcb_cards
            // 
            this.pcb_cards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_cards.Location = new System.Drawing.Point(561, 257);
            this.pcb_cards.Name = "pcb_cards";
            this.pcb_cards.Size = new System.Drawing.Size(102, 120);
            this.pcb_cards.TabIndex = 2;
            this.pcb_cards.Paint += new System.Windows.Forms.PaintEventHandler(this.pcb_cards_Paint);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(657, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Yeni Oyun";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(1071, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Green;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sen,
            this.Bilgisayar});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(110, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(202, 207);
            this.dataGridView1.TabIndex = 8;
            // 
            // Sen
            // 
            this.Sen.Frozen = true;
            this.Sen.HeaderText = "Sen";
            this.Sen.Name = "Sen";
            this.Sen.ReadOnly = true;
            // 
            // Bilgisayar
            // 
            this.Bilgisayar.Frozen = true;
            this.Bilgisayar.HeaderText = "Bilgisayar";
            this.Bilgisayar.Name = "Bilgisayar";
            this.Bilgisayar.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(634, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "PİŞTİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(902, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Font Rengi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1599, 1008);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnl_arka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_arka.ResumeLayout(false);
            this.pnl_arka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_pisti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_puan_rakip;
        private System.Windows.Forms.Label lbl_puan_kullanici;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel pnl_arka;
        private System.Windows.Forms.Panel pcb_cards;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pcb_pisti;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bilgisayar;
        private System.Windows.Forms.Label lbl_toplam_puan_kulla;
        private System.Windows.Forms.Label lbl_toplam_puan_rakip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

