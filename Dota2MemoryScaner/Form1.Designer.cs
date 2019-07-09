namespace Dota2MemoryScaner
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.gold = new System.Windows.Forms.NumericUpDown();
            this.bust = new System.Windows.Forms.NumericUpDown();
            this.portrait = new System.Windows.Forms.NumericUpDown();
            this.deed = new System.Windows.Forms.NumericUpDown();
            this.herb = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.herb2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.активироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portrait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.herb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.herb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(108, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Золото!";
            // 
            // gold
            // 
            this.gold.Location = new System.Drawing.Point(34, 11);
            this.gold.Maximum = new decimal(new int[] {
            666666666,
            0,
            0,
            0});
            this.gold.Name = "gold";
            this.gold.Size = new System.Drawing.Size(62, 20);
            this.gold.TabIndex = 2;
            this.gold.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.gold.ValueChanged += new System.EventHandler(this.gold_ValueChanged);
            // 
            // bust
            // 
            this.bust.Location = new System.Drawing.Point(36, 37);
            this.bust.Maximum = new decimal(new int[] {
            666666666,
            0,
            0,
            0});
            this.bust.Name = "bust";
            this.bust.Size = new System.Drawing.Size(60, 20);
            this.bust.TabIndex = 3;
            this.bust.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.bust.ValueChanged += new System.EventHandler(this.bust_ValueChanged);
            // 
            // portrait
            // 
            this.portrait.Location = new System.Drawing.Point(34, 64);
            this.portrait.Maximum = new decimal(new int[] {
            666666666,
            0,
            0,
            0});
            this.portrait.Name = "portrait";
            this.portrait.Size = new System.Drawing.Size(62, 20);
            this.portrait.TabIndex = 4;
            this.portrait.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.portrait.ValueChanged += new System.EventHandler(this.portrait_ValueChanged);
            // 
            // deed
            // 
            this.deed.Location = new System.Drawing.Point(34, 90);
            this.deed.Maximum = new decimal(new int[] {
            666666666,
            0,
            0,
            0});
            this.deed.Name = "deed";
            this.deed.Size = new System.Drawing.Size(62, 20);
            this.deed.TabIndex = 5;
            this.deed.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.deed.ValueChanged += new System.EventHandler(this.deed_ValueChanged);
            // 
            // herb
            // 
            this.herb.Location = new System.Drawing.Point(34, 117);
            this.herb.Maximum = new decimal(new int[] {
            666666666,
            0,
            0,
            0});
            this.herb.Name = "herb";
            this.herb.Size = new System.Drawing.Size(62, 20);
            this.herb.TabIndex = 6;
            this.herb.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.herb.ValueChanged += new System.EventHandler(this.herb_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(108, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Бюсты!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(100, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Портреты!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(108, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Купчие!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(111, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Гербы!";
            // 
            // herb2
            // 
            this.herb2.Image = global::Dota2MemoryScaner.Properties.Resources.currency_crest_icon;
            this.herb2.Location = new System.Drawing.Point(8, 115);
            this.herb2.Name = "herb2";
            this.herb2.Size = new System.Drawing.Size(25, 22);
            this.herb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.herb2.TabIndex = 16;
            this.herb2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Dota2MemoryScaner.Properties.Resources.currency_deed_icon;
            this.pictureBox5.Location = new System.Drawing.Point(8, 88);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Dota2MemoryScaner.Properties.Resources.currency_portrait_icon;
            this.pictureBox4.Location = new System.Drawing.Point(8, 62);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Dota2MemoryScaner.Properties.Resources.currency_bust_icon;
            this.pictureBox3.Location = new System.Drawing.Point(8, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dota2MemoryScaner.Properties.Resources.currency_gold_icon;
            this.pictureBox2.Location = new System.Drawing.Point(9, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Dota2MemoryScaner.Properties.Resources.town_event_character;
            this.pictureBox1.Location = new System.Drawing.Point(191, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.активироватьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 147);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(364, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // активироватьToolStripMenuItem
            // 
            this.активироватьToolStripMenuItem.Name = "активироватьToolStripMenuItem";
            this.активироватьToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.активироватьToolStripMenuItem.Text = "Активировать";
            this.активироватьToolStripMenuItem.Click += new System.EventHandler(this.активироватьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 171);
            this.Controls.Add(this.herb2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.herb);
            this.Controls.Add(this.deed);
            this.Controls.Add(this.portrait);
            this.Controls.Add(this.bust);
            this.Controls.Add(this.gold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Darkest Dungeon Trainer +5 by Lur\'Kha";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portrait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.herb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.herb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown gold;
        private System.Windows.Forms.NumericUpDown bust;
        private System.Windows.Forms.NumericUpDown portrait;
        private System.Windows.Forms.NumericUpDown deed;
        private System.Windows.Forms.NumericUpDown herb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox herb2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem активироватьToolStripMenuItem;
    }
}

