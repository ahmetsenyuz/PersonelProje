
namespace PersonelProje
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dTOYaklaşımıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anonimYaklaşımıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şehirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.şehirToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dTOYaklaşımıToolStripMenuItem,
            this.anonimYaklaşımıToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.personelToolStripMenuItem.Text = "Personel";
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
            // 
            // dTOYaklaşımıToolStripMenuItem
            // 
            this.dTOYaklaşımıToolStripMenuItem.Name = "dTOYaklaşımıToolStripMenuItem";
            this.dTOYaklaşımıToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.dTOYaklaşımıToolStripMenuItem.Text = "DTO Yaklaşımı";
            this.dTOYaklaşımıToolStripMenuItem.Click += new System.EventHandler(this.dTOYaklaşımıToolStripMenuItem_Click);
            // 
            // anonimYaklaşımıToolStripMenuItem
            // 
            this.anonimYaklaşımıToolStripMenuItem.Name = "anonimYaklaşımıToolStripMenuItem";
            this.anonimYaklaşımıToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.anonimYaklaşımıToolStripMenuItem.Text = "Anonim Yaklaşımı";
            this.anonimYaklaşımıToolStripMenuItem.Click += new System.EventHandler(this.anonimYaklaşımıToolStripMenuItem_Click);
            // 
            // şehirToolStripMenuItem
            // 
            this.şehirToolStripMenuItem.Name = "şehirToolStripMenuItem";
            this.şehirToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.şehirToolStripMenuItem.Text = "Şehir";
            this.şehirToolStripMenuItem.Click += new System.EventHandler(this.şehirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şehirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dTOYaklaşımıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anonimYaklaşımıToolStripMenuItem;
    }
}

