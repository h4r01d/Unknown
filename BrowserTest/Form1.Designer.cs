namespace BrowserTest
{
    partial class Zecram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zecram));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sitelabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.printScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairESCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairESCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menufavorite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.nextbutton = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sitelabel,
            this.progressbar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 357);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(944, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sitelabel
            // 
            this.sitelabel.Name = "sitelabel";
            this.sitelabel.Size = new System.Drawing.Size(0, 17);
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(100, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu1,
            this.menufavorite});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu1
            // 
            this.Menu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.printScreenToolStripMenuItem,
            this.históricoToolStripMenuItem,
            this.sairESCToolStripMenuItem,
            this.sairESCToolStripMenuItem1});
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(50, 20);
            this.Menu1.Text = "Menu";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Ir";
            // 
            // printScreenToolStripMenuItem
            // 
            this.printScreenToolStripMenuItem.Name = "printScreenToolStripMenuItem";
            this.printScreenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.printScreenToolStripMenuItem.Text = "PrintScreen";
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.históricoToolStripMenuItem.Text = "Histórico";
            // 
            // sairESCToolStripMenuItem
            // 
            this.sairESCToolStripMenuItem.Name = "sairESCToolStripMenuItem";
            this.sairESCToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.sairESCToolStripMenuItem.Text = "Sobre o Zecram..";
            this.sairESCToolStripMenuItem.Click += new System.EventHandler(this.sairESCToolStripMenuItem_Click);
            // 
            // sairESCToolStripMenuItem1
            // 
            this.sairESCToolStripMenuItem1.Name = "sairESCToolStripMenuItem1";
            this.sairESCToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.sairESCToolStripMenuItem1.Text = "Sair     (ESC)";
            this.sairESCToolStripMenuItem1.Click += new System.EventHandler(this.sairESCToolStripMenuItem1_Click);
            // 
            // menufavorite
            // 
            this.menufavorite.Name = "menufavorite";
            this.menufavorite.Size = new System.Drawing.Size(67, 20);
            this.menufavorite.Text = "Favoritos";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(944, 379);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(944, 379);
            this.toolStripContainer1.TabIndex = 16;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // nextbutton
            // 
            this.nextbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextbutton.BackgroundImage")));
            this.nextbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextbutton.Location = new System.Drawing.Point(62, 5);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(44, 41);
            this.nextbutton.TabIndex = 13;
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Location = new System.Drawing.Point(160, 18);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(698, 20);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // refreshbutton
            // 
            this.refreshbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshbutton.BackgroundImage")));
            this.refreshbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshbutton.Location = new System.Drawing.Point(116, 13);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(38, 29);
            this.refreshbutton.TabIndex = 14;
            this.refreshbutton.UseVisualStyleBackColor = true;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(876, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Ir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbutton.BackgroundImage")));
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbutton.Location = new System.Drawing.Point(12, 5);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(44, 41);
            this.backbutton.TabIndex = 12;
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(3, 52);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(941, 281);
            this.webBrowser1.TabIndex = 15;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.Xprocess);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Controls.Add(this.backbutton);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.refreshbutton);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.nextbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 333);
            this.panel1.TabIndex = 15;
            // 
            // timer
            // 
            this.timer.Interval = 120;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Zecram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Zecram";
            this.Text = "Zecram";
            this.Load += new System.EventHandler(this.Zecram_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressX);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem printScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairESCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairESCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripStatusLabel sitelabel;
        private System.Windows.Forms.ToolStripProgressBar progressbar;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button refreshbutton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem menufavorite;
    }
}

