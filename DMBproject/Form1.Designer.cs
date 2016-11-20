namespace DMBproject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.imageProcessing = new System.Windows.Forms.ToolStripMenuItem();
            this.menuZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuGIT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBAW = new System.Windows.Forms.ToolStripMenuItem();
            this.flash = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timeUsing = new System.Windows.Forms.Label();
            this.sourceImage = new System.Windows.Forms.Button();
            this.rotateR = new System.Windows.Forms.Button();
            this.rotateL = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.flashPlayer = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.playOrPause = new System.Windows.Forms.Button();
            this.stopFlash = new System.Windows.Forms.Button();
            this.教程ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.imageProcessing,
            this.flash,
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(360, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.saveAs,
            this.toolStripSeparator1,
            this.menuQuit});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(44, 21);
            this.file.Text = "文件";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(112, 22);
            this.menuOpen.Text = "打开";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(112, 22);
            this.saveAs.Text = "保存为";
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(112, 22);
            this.menuQuit.Text = "退出";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
            // 
            // imageProcessing
            // 
            this.imageProcessing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuZoom,
            this.toolStripSeparator2,
            this.menuGIT,
            this.menuBAW});
            this.imageProcessing.Enabled = false;
            this.imageProcessing.Name = "imageProcessing";
            this.imageProcessing.Size = new System.Drawing.Size(68, 21);
            this.imageProcessing.Text = "图像处理";
            // 
            // menuZoom
            // 
            this.menuZoom.Name = "menuZoom";
            this.menuZoom.Size = new System.Drawing.Size(152, 22);
            this.menuZoom.Text = "缩放";
            this.menuZoom.Click += new System.EventHandler(this.menuZoom_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // menuGIT
            // 
            this.menuGIT.Name = "menuGIT";
            this.menuGIT.Size = new System.Drawing.Size(152, 22);
            this.menuGIT.Text = "灰度变换";
            this.menuGIT.Click += new System.EventHandler(this.menuGIT_Click);
            // 
            // menuBAW
            // 
            this.menuBAW.Name = "menuBAW";
            this.menuBAW.Size = new System.Drawing.Size(152, 22);
            this.menuBAW.Text = "黑白变换";
            this.menuBAW.Click += new System.EventHandler(this.menuBAW_Click);
            // 
            // flash
            // 
            this.flash.Name = "flash";
            this.flash.Size = new System.Drawing.Size(71, 21);
            this.flash.Text = "flash播放";
            this.flash.Click += new System.EventHandler(this.flash_Click);
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.教程ToolStripMenuItem,
            this.about});
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 21);
            this.help.Text = "帮助";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(152, 22);
            this.about.Text = "关于";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(0, 25);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(360, 223);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.Title = "打开图片";
            this.OpenFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PnG Image|*.png|Wmf  Image|*." +
    "wmf";
            this.saveFileDialog1.Title = "保存图像";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // timeUsing
            // 
            this.timeUsing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeUsing.AutoSize = true;
            this.timeUsing.BackColor = System.Drawing.SystemColors.MenuBar;
            this.timeUsing.Font = new System.Drawing.Font("SimSun", 15F);
            this.timeUsing.Location = new System.Drawing.Point(229, 2);
            this.timeUsing.Name = "timeUsing";
            this.timeUsing.Size = new System.Drawing.Size(129, 20);
            this.timeUsing.TabIndex = 2;
            this.timeUsing.Text = "time spanned";
            this.timeUsing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sourceImage
            // 
            this.sourceImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sourceImage.Location = new System.Drawing.Point(44, 254);
            this.sourceImage.Name = "sourceImage";
            this.sourceImage.Size = new System.Drawing.Size(95, 31);
            this.sourceImage.TabIndex = 3;
            this.sourceImage.Text = "原图(ctrl+R)";
            this.sourceImage.UseVisualStyleBackColor = true;
            this.sourceImage.Click += new System.EventHandler(this.sourceImage_Click);
            this.sourceImage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sourceImage_KeyDown);
            // 
            // rotateR
            // 
            this.rotateR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rotateR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rotateR.BackgroundImage")));
            this.rotateR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rotateR.Location = new System.Drawing.Point(259, 254);
            this.rotateR.Name = "rotateR";
            this.rotateR.Size = new System.Drawing.Size(31, 31);
            this.rotateR.TabIndex = 4;
            this.rotateR.UseVisualStyleBackColor = true;
            this.rotateR.Click += new System.EventHandler(this.rotateR_Click);
            // 
            // rotateL
            // 
            this.rotateL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rotateL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rotateL.BackgroundImage")));
            this.rotateL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rotateL.Location = new System.Drawing.Point(227, 254);
            this.rotateL.Name = "rotateL";
            this.rotateL.Size = new System.Drawing.Size(31, 31);
            this.rotateL.TabIndex = 5;
            this.rotateL.UseVisualStyleBackColor = true;
            this.rotateL.Click += new System.EventHandler(this.rotateL_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Flash文件|*.swf";
            this.openFileDialog2.Title = "打开Flash动画文件";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // flashPlayer
            // 
            this.flashPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flashPlayer.Enabled = true;
            this.flashPlayer.Location = new System.Drawing.Point(0, 25);
            this.flashPlayer.Name = "flashPlayer";
            this.flashPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("flashPlayer.OcxState")));
            this.flashPlayer.Size = new System.Drawing.Size(358, 223);
            this.flashPlayer.TabIndex = 6;
            this.flashPlayer.Visible = false;
            // 
            // playOrPause
            // 
            this.playOrPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playOrPause.Location = new System.Drawing.Point(137, 254);
            this.playOrPause.Name = "playOrPause";
            this.playOrPause.Size = new System.Drawing.Size(40, 31);
            this.playOrPause.TabIndex = 7;
            this.playOrPause.Text = "暂停";
            this.playOrPause.UseVisualStyleBackColor = true;
            this.playOrPause.Visible = false;
            this.playOrPause.Click += new System.EventHandler(this.playOrPause_Click);
            // 
            // stopFlash
            // 
            this.stopFlash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.stopFlash.Location = new System.Drawing.Point(183, 254);
            this.stopFlash.Name = "stopFlash";
            this.stopFlash.Size = new System.Drawing.Size(38, 31);
            this.stopFlash.TabIndex = 8;
            this.stopFlash.Text = "停止";
            this.stopFlash.UseVisualStyleBackColor = true;
            this.stopFlash.Visible = false;
            this.stopFlash.Click += new System.EventHandler(this.stopFlash_Click);
            // 
            // 教程ToolStripMenuItem
            // 
            this.教程ToolStripMenuItem.Name = "教程ToolStripMenuItem";
            this.教程ToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "教程";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(360, 284);
            this.Controls.Add(this.rotateL);
            this.Controls.Add(this.rotateR);
            this.Controls.Add(this.sourceImage);
            this.Controls.Add(this.timeUsing);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.flashPlayer);
            this.Controls.Add(this.playOrPause);
            this.Controls.Add(this.stopFlash);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "看图器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.ToolStripMenuItem imageProcessing;
        private System.Windows.Forms.ToolStripMenuItem menuZoom;
        private System.Windows.Forms.ToolStripMenuItem menuGIT;
        private System.Windows.Forms.ToolStripMenuItem menuBAW;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem flash;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label timeUsing;
        private System.Windows.Forms.Button sourceImage;
        private System.Windows.Forms.Button rotateR;
        private System.Windows.Forms.Button rotateL;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private AxShockwaveFlashObjects.AxShockwaveFlash flashPlayer;
        private System.Windows.Forms.Button playOrPause;
        private System.Windows.Forms.Button stopFlash;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator 教程ToolStripMenuItem;
    }
}

