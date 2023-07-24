
namespace TestJobV2Group
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСФайламиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.SearchPointButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripBackButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchPointButton,
            this.toolStripBackButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСФайламиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСФайламиToolStripMenuItem
            // 
            this.работаСФайламиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьФайлToolStripMenuItem,
            this.сохранитьФайлToolStripMenuItem});
            this.работаСФайламиToolStripMenuItem.Name = "работаСФайламиToolStripMenuItem";
            this.работаСФайламиToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.работаСФайламиToolStripMenuItem.Text = "Работа с файлами";
            // 
            // загрузитьФайлToolStripMenuItem
            // 
            this.загрузитьФайлToolStripMenuItem.Name = "загрузитьФайлToolStripMenuItem";
            this.загрузитьФайлToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьФайлToolStripMenuItem.Text = "Загрузить файл";
            this.загрузитьФайлToolStripMenuItem.Click += new System.EventHandler(this.загрузитьФайлToolStripMenuItem_Click);
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            this.сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            this.сохранитьФайлToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьФайлToolStripMenuItem.Text = "Сохранить файл";
            this.сохранитьФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьФайлToolStripMenuItem_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(0, 49);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(800, 401);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // SearchPointButton
            // 
            this.SearchPointButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchPointButton.Image = global::TestJobV2Group.Properties.Resources._1822947;
            this.SearchPointButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchPointButton.Name = "SearchPointButton";
            this.SearchPointButton.Size = new System.Drawing.Size(23, 22);
            this.SearchPointButton.Text = "toolStripButton1";
            this.SearchPointButton.Click += new System.EventHandler(this.SearchPointButton_Click);
            // 
            // toolStripBackButton
            // 
            this.toolStripBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBackButton.Image = global::TestJobV2Group.Properties.Resources._17445;
            this.toolStripBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBackButton.Name = "toolStripBackButton";
            this.toolStripBackButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripBackButton.Text = "Удалить последнюю точку";
            this.toolStripBackButton.Click += new System.EventHandler(this.toolStripBackButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton SearchPointButton;
        private System.Windows.Forms.ToolStripButton toolStripBackButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСФайламиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьФайлToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

