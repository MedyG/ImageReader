using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing.Drawing2D;
using System.Threading;

namespace DMBproject
{
    public partial class Form1 : Form
    {
        public Image img;
        public Image srcImg;
        public Form1()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PictureBox1.Image == null)
            {
                menuOpen_Click(null, null);
            }
        }
        // This method handles the FileOK event.  It opens each file 
        // selected and loads the image from a stream into PictureBox1.
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.Activate();
            string file = OpenFileDialog1.FileName;
            PictureBox1.Visible = false;
            img = Image.FromFile(file);
            srcImg = (System.Drawing.Image)img.Clone();
            PictureBox1.Image = img;//draw the image on the PictureBox
            PictureBox1.Visible = true;
            imageProcessing.Enabled = true;
            Application.DoEvents();
        }
        private void InitializeOpenFileDialog()
        {
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();

            // Set the file dialog to filter for graphics files.
            this.OpenFileDialog1.Filter =
                "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|" +
                "All files (*.*)|*.*";

            // Allow the user to select multiple images.
            this.OpenFileDialog1.Title = "打开图片";
            this.OpenFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string path = saveFileDialog1.FileName;
            try
            {
                if (PictureBox1.Image != null)
                {
                    PictureBox1.Image.Save(path);
                }
                else
                {
                    MessageBox.Show("没有预览图片");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem saving the file." +
                    "Check the file permissions.");
            }
            
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void menuQuit_Click(object sender, EventArgs e)
        {
            try
            {
                img.Dispose();
            }
            catch {}
            this.Dispose();
        }

        private void menuGIT_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            int width = img.Width;
            int height = img.Height;
            Bitmap oldBitmap = (Bitmap)img;
            Bitmap result = new Bitmap(width, height);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixel = oldBitmap.GetPixel(x, y);
                    int r, g, b, intensity = 0;
                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;
                    intensity = rounding((r * 38 + g * 75 + b * 15) >> 7);
                    result.SetPixel(x, y, Color.FromArgb(intensity, intensity, intensity));
                }
            }
            img = result;
            PictureBox1.Image = img;
            TimeSpan span = DateTime.Now - start;
            timeUsing.Text = span.TotalMilliseconds.ToString() + " ms";
        }
        
        //四舍五入
        private int rounding(double number)
        {
            if (number - (int)number >= 0.5)
            {
                return (int)number + 1;
            }
            else
            {
                return (int)number;
            }
        }

        private void menuBAW_Click(object sender, EventArgs e)
        {
            int threshold = 128;//阀值
            Form f = new Form();
            TextBox t = new TextBox();
            Button btn = new Button();
            btn.Text = "确定";
            btn.Click += (o, j) =>
                {
                    int.TryParse(t.Text, out threshold);
                    if (threshold <= 255 && threshold >=1)
                    {
                        rgbToBinaryImage(threshold);
                    }
                    else
                    {
                        MessageBox.Show("请输入在1-255之间的整数");
                    }
                    f.Dispose();
                };
            //btn.Click += new EventHandler(threshold_Click);
            f.Controls.Add(t);
            f.Controls.Add(btn);
            f.Text = "请输入域值(1-255)";
            btn.Location = new Point(6, 20);
            f.Width = 150;
            f.Height = 75;
            f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            f.ShowDialog();
        }
        private void rgbToBinaryImage(int threshold)
        {
            DateTime start = DateTime.Now;
            int width = img.Width;
            int height = img.Height;
            Bitmap oldBitmap = (Bitmap)img;
            Bitmap result = new Bitmap(width, height);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixel = oldBitmap.GetPixel(x, y);
                    int r, g, b, intensity = 0;
                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;
                    intensity = rounding((r * 38 + g * 75 + b * 15) >> 7);//著名心理学灰度转换公式
                    if (intensity >= threshold)
                    {
                        intensity = 255;
                    }
                    else
                    {
                        intensity = 0;
                    }
                    result.SetPixel(x, y, Color.FromArgb(intensity, intensity, intensity));
                }
            }
            img = result;
            PictureBox1.Image = img;
            TimeSpan span = DateTime.Now - start;
            timeUsing.Text = span.TotalMilliseconds.ToString() + " ms";
        }
        private void sourceImage_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                img = (System.Drawing.Image)srcImg.Clone();
                PictureBox1.Image = img;
            }
        }
        private void sourceImage_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.Modifiers == (int)Keys.Control && e.KeyCode == Keys.R)
            {
                sourceImage_Click(null, null);
            }
        }

        private void menuZoom_Click(object sender, EventArgs e)
        {
            //创建窗口
            Form f = new Form();
            Label l1 = new Label();
            Label l2 = new Label();
            TextBox t1 = new TextBox();
            TextBox t2 = new TextBox();
            Button btn = new Button();
            l1.Text = "长(width)";
            l2.Text = "宽(height)";
            btn.Text = "确定";
            l1.TextAlign = ContentAlignment.MiddleCenter;
            l2.TextAlign = ContentAlignment.MiddleCenter;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            l1.Width = 70;
            l2.Width = 70;
            l2.Location = new Point(0, 25);
            t1.Location = new Point(80, 0);
            t2.Location = new Point(80, 25);
            btn.Location = new Point(60, 50);

            btn.Click += (o, j) =>
                {
                    DateTime start = DateTime.Now;
                    int width, height;
                    if (int.TryParse(t1.Text, out width) 
                        && int.TryParse(t2.Text, out height))
                    {
                        try
                        {
                            Bitmap bmp = new Bitmap(img, width, height);//缩放
                            img = (System.Drawing.Image)bmp.Clone();
                            PictureBox1.Image = img;
                            bmp.Dispose();
                            f.Dispose();
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("参数无效");
                        }
                    }
                    else
                    {
                        MessageBox.Show("参数无效或不存在");
                    }
                    TimeSpan span = DateTime.Now - start;
                    timeUsing.Text = span.TotalMilliseconds.ToString() + " ms";
                };

            f.Controls.Add(l1);
            f.Controls.Add(l2);
            f.Controls.Add(t1);
            f.Controls.Add(t2);
            f.Controls.Add(btn);
            f.Text = "请输入缩放之后的长和宽";
            f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            f.Width = 200;
            f.Height = 110;
            f.ShowDialog();
        }

        private void rotateL_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                PictureBox1.Image = img;
            }
            
        }

        private void rotateR_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                PictureBox1.Image = img;
            }
        }

        private void flash_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            this.Activate();
            string path = openFileDialog2.FileName;
            PictureBox1.Visible = false;
            sourceImage.Visible = false;
            rotateL.Visible = false;
            rotateR.Visible = false;
            flashPlayer.Visible = true;
            playOrPause.Visible = true;
            stopFlash.Visible = true;
            flashPlayer.Movie = path;
            flashPlayer.Play();//播放flash动画
            file.Enabled = false;
            imageProcessing.Enabled = false;
            Application.DoEvents();
        }

        private void playOrPause_Click(object sender, EventArgs e)
        {
            if (flashPlayer.IsPlaying())
            {
                flashPlayer.Stop();
                playOrPause.Text = "播放";
            }
            else
            {
                flashPlayer.Play();
                playOrPause.Text = "暂停";
            }
        }

        private void stopFlash_Click(object sender, EventArgs e)
        {
            flashPlayer.StopPlay();
            PictureBox1.Visible = true;
            sourceImage.Visible = true;
            rotateL.Visible = true;
            rotateR.Visible = true;
            flashPlayer.Visible = false;
            playOrPause.Visible = false;
            stopFlash.Visible = false;
            file.Enabled = true;
        }

        private void about_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            Label info = new Label();
            Label maker = new Label();
            info.AutoSize = true;
            maker.AutoSize = true;
            maker.Location = new Point(50, 200);
            info.Text = "看图器 版本v0.1.1";
            info.TextAlign = ContentAlignment.MiddleCenter;
            maker.Text = "详情请访问:https://github.com/MedyG \nlast modified in 2016-11-20";
            maker.TextAlign = ContentAlignment.MiddleCenter;
            f.Controls.Add(info);
            f.Controls.Add(maker);
            f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            f.Visible = true;
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(helpEXE);
            Thread helpThread = new Thread(threadStart);
            helpThread.Start();
        }

        /// <summary>
        /// 打开帮助程序
        /// </summary>
        private void helpEXE()
        {
            //System.Windows.Forms.MessageBox.Show("打开帮助程序");
            System.Diagnostics.Process pExecuteEXE = new System.Diagnostics.Process();
            pExecuteEXE.StartInfo.FileName = System.Windows.Forms.Application.StartupPath + "\\help\\help.exe";
            try
            {
                pExecuteEXE.Start();
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                Console.WriteLine("系统找不到指定的程序文件。\r{0}", ex);
            }
            finally
            {
                pExecuteEXE.WaitForExit();
            }
            //System.Windows.Forms.MessageBox.Show("帮助程序关闭");
        }
    }
}
