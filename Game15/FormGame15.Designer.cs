namespace Game15
{
    partial class FormGame15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame15));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_start = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_level = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_level_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_level_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_level_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_level_6 = new System.Windows.Forms.ToolStripMenuItem();
            this.окончитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_start,
            this.menu_level,
            this.окончитьИгруToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(621, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip2";
            // 
            // menu_start
            // 
            this.menu_start.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_start.Name = "menu_start";
            this.menu_start.Size = new System.Drawing.Size(92, 20);
            this.menu_start.Text = "Начать игру";
            this.menu_start.Click += new System.EventHandler(this.Menu_start_Click);
            // 
            // menu_level
            // 
            this.menu_level.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_level_3,
            this.menu_level_4,
            this.menu_level_5,
            this.menu_level_6});
            this.menu_level.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu_level.Name = "menu_level";
            this.menu_level.Size = new System.Drawing.Size(67, 20);
            this.menu_level.Text = "Уровень";
            // 
            // menu_level_3
            // 
            this.menu_level_3.Name = "menu_level_3";
            this.menu_level_3.Size = new System.Drawing.Size(102, 22);
            this.menu_level_3.Text = "3 х 3";
            this.menu_level_3.Click += new System.EventHandler(this.Menu_level_3_Click);
            // 
            // menu_level_4
            // 
            this.menu_level_4.Name = "menu_level_4";
            this.menu_level_4.Size = new System.Drawing.Size(102, 22);
            this.menu_level_4.Text = "4 х 4";
            this.menu_level_4.Click += new System.EventHandler(this.Menu_level_4_Click);
            // 
            // menu_level_5
            // 
            this.menu_level_5.Name = "menu_level_5";
            this.menu_level_5.Size = new System.Drawing.Size(102, 22);
            this.menu_level_5.Text = "5 х 5";
            this.menu_level_5.Click += new System.EventHandler(this.Menu_level_5_Click);
            // 
            // menu_level_6
            // 
            this.menu_level_6.Name = "menu_level_6";
            this.menu_level_6.Size = new System.Drawing.Size(102, 22);
            this.menu_level_6.Text = "6 x 6";
            this.menu_level_6.Click += new System.EventHandler(this.Menu_level_6_Click);
            // 
            // окончитьИгруToolStripMenuItem
            // 
            this.окончитьИгруToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.окончитьИгруToolStripMenuItem.Name = "окончитьИгруToolStripMenuItem";
            this.окончитьИгруToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.окончитьИгруToolStripMenuItem.Text = "Окончить игру";
            this.окончитьИгруToolStripMenuItem.Click += new System.EventHandler(this.ОкончитьИгруToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(458, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кол-во нажатий:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(580, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 437);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(25, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // FormGame15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGame15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пятнашки";
            this.Load += new System.EventHandler(this.FormGame15_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menu_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem menu_level;
        private System.Windows.Forms.ToolStripMenuItem menu_level_3;
        private System.Windows.Forms.ToolStripMenuItem menu_level_4;
        private System.Windows.Forms.ToolStripMenuItem menu_level_5;
        private System.Windows.Forms.ToolStripMenuItem menu_level_6;
        private System.Windows.Forms.ToolStripMenuItem окончитьИгруToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

