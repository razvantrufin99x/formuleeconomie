namespace formuleeconomie
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.formuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procentDinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splashScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formuleToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(629, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // formuleToolStripMenuItem
            // 
            this.formuleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procenteToolStripMenuItem});
            this.formuleToolStripMenuItem.Name = "formuleToolStripMenuItem";
            this.formuleToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.formuleToolStripMenuItem.Text = "Formule";
            // 
            // procenteToolStripMenuItem
            // 
            this.procenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procentToolStripMenuItem,
            this.procentDinToolStripMenuItem});
            this.procenteToolStripMenuItem.Name = "procenteToolStripMenuItem";
            this.procenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.procenteToolStripMenuItem.Text = "Procente";
            // 
            // procentToolStripMenuItem
            // 
            this.procentToolStripMenuItem.Name = "procentToolStripMenuItem";
            this.procentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.procentToolStripMenuItem.Text = "Procent";
            this.procentToolStripMenuItem.Click += new System.EventHandler(this.procentToolStripMenuItem_Click);
            // 
            // procentDinToolStripMenuItem
            // 
            this.procentDinToolStripMenuItem.Name = "procentDinToolStripMenuItem";
            this.procentDinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.procentDinToolStripMenuItem.Text = "ProcentDin";
            this.procentDinToolStripMenuItem.Click += new System.EventHandler(this.procentDinToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1,
            this.splashScreenToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // splashScreenToolStripMenuItem
            // 
            this.splashScreenToolStripMenuItem.Name = "splashScreenToolStripMenuItem";
            this.splashScreenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.splashScreenToolStripMenuItem.Text = "SplashScreen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 453);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calcule formule economie";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procentDinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem splashScreenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

