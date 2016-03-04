using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiraUserFriendly
{
    public partial class CIRAUpdater : Form
    {
        private System.Threading.Thread downloadThread;
        private System.Threading.Thread animationThread;
        public CIRAUpdater()
        {
            InitializeComponent();
        }
        private void saveLocation_MouseClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                saveLocation.Text = fbd.SelectedPath + @"\";
        }
        private void CIRAUpdater_Load(object sender, EventArgs e)
        {
            for (int x = 0; x <= 31; x++)
                this.daysToGet.Items.Add(x);
            this.daysToGet.SelectedIndex = 0;
            styleDropdown.Items.Add("Centered");
            styleDropdown.Items.Add("Stretched");
            styleDropdown.Items.Add("Tiled");
            styleDropdown.Items.Add("FlatCenter");
            styleDropdown.SelectedIndex = Properties.Settings.Default.Style;
            this.saveLocation.Text = Properties.Settings.Default.SavePath;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "Stop")
            {
                try { downloadThread.Abort(); }
                catch { }
                this.button1.Text = "Get Images";
                this.button1.ForeColor = Color.FromArgb(255, 255, 128);
                this.currentImageLabel.Text = "";
            }
            else
            {
                if (saveLocation.Text == "")
                {
                    MessageBox.Show("Please select a File Save Location", "U W0T M8?");
                    return;
                }
                if (!Directory.Exists(saveLocation.Text))
                {
                    MessageBox.Show("Directory does not exist! Please select a valid Save Location O.o", "U W0T M8?");
                    return;
                }
                this.button1.Text = "Stop";
                this.button1.ForeColor = Color.LightSalmon;
                downloadThread = new System.Threading.Thread(new System.Threading.ThreadStart(downloadImages));
                downloadThread.Start();
            }
        }
        private void downloadImages()
        {
            string initialPath = "";
            if(this.useHighRes.Checked)
                initialPath = "http://rammb.cira.colostate.edu/ramsdis/online/images/hi_res/himawari-8/full_disk_ahi_true_color/full_disk_ahi_true_color_";
            else
                initialPath = "http://rammb.cira.colostate.edu/ramsdis/online/images/himawari-8/full_disk_ahi_true_color/full_disk_ahi_true_color_";
            //http://rammb.cira.colostate.edu/ramsdis/online/images/himawari-8/full_disk_ahi_true_color/full_disk_ahi_true_color_20160201010000.jpg
            string startDay = DateTime.UtcNow.AddDays(-int.Parse(this.daysToGet.SelectedIndex.ToString())).ToString("yyyyMMdd");
            string endDay = DateTime.UtcNow.ToString("yyyyMMdd");
            int startTime = 0;
            int completedDays = 0;
            while (completedDays <= this.daysToGet.SelectedIndex)
            {
                string fileUri = "";
                fileUri += startDay;
                if (startTime == 0)
                    fileUri += "0000";
                else if (startTime < 100)
                    fileUri += "00" + startTime;
                else if (startTime < 1000)
                    fileUri += "0" + startTime;
                else
                    fileUri += startTime;
                fileUri += "00.jpg";
                string fileName = fileUri;
                fileUri = initialPath + fileUri;
                try
                {
                    this.Invoke((MethodInvoker)delegate { this.currentImageLabel.Text = "Downloading: " + fileName.Substring(0, fileName.Length - 4) + ".bmp"; });
                    System.IO.Stream s = new System.Net.WebClient().OpenRead(fileUri.ToString());
                    System.Drawing.Image img = System.Drawing.Image.FromStream(s);
                    if (this.useHighRes.Checked)
                        System.Drawing.Graphics.FromImage(img).FillRectangle(new SolidBrush(Color.Black), new Rectangle(9, 5088, 944, 405));
                    else
                        System.Drawing.Graphics.FromImage(img).FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 738, 160, 70));
                    img.Save(this.saveLocation.Text + fileName.Substring(0, fileName.Length - 4) + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                }
                catch (Exception)
                {

                }
                startTime += 10;
                if (startTime.ToString().Substring(startTime.ToString().Length - 2) == "60")
                    startTime += 40;
                if (startTime >= 2400)
                {
                    startTime = 0;
                    completedDays++;
                    startDay = DateTime.UtcNow.AddDays((-int.Parse(this.daysToGet.SelectedIndex.ToString())) + completedDays).ToString("yyyyMMdd");
                }
            }
            try
            {
                this.Invoke((MethodInvoker)delegate { this.button1.Text = "Get Images"; this.currentImageLabel.Text = ""; this.button1.ForeColor = Color.FromArgb(255, 255, 128); });
            }
            catch { }
        }
        private void CIRAUpdater_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Style = this.styleDropdown.SelectedIndex;
            Properties.Settings.Default.SavePath = this.saveLocation.Text;
            Properties.Settings.Default.Save();
            Environment.Exit(0);
        }

        private void animateButton_Click(object sender, EventArgs e)
        {
            if (this.animateButton.Text == "Stop")
            {
                try { animationThread.Abort(); }
                catch { }
                this.animateButton.Text = "Animate Directory";
                this.animateButton.ForeColor = Color.FromArgb(255, 255, 128);
            }
            else
            {
                if (saveLocation.Text == "")
                {
                    MessageBox.Show("Please select a Directory to Animate", "U W0T M8?");
                    return;
                }
                if (!Directory.Exists(saveLocation.Text))
                {
                    MessageBox.Show("Directory does not exist! Please select a valid directory to Animate O.o", "U W0T M8?");
                    return;
                }
                try
                {
                    int.Parse(animationDelay.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid delay (0-999999)", "U W0T M8?");
                    return;
                }                    
                this.animateButton.Text = "Stop";
                this.animateButton.ForeColor = Color.LightSalmon;
                animationThread = new System.Threading.Thread(new System.Threading.ThreadStart(animate));
                animationThread.Start();
            }
        }

        private void animate()
        {
            int delay = int.Parse(animationDelay.Text);
            Wallpaper.Style style;
            switch (this.styleDropdown.SelectedIndex)
            {
                case 0:
                    style = Wallpaper.Style.Centered;
                    break;
                case 1:
                    style = Wallpaper.Style.Stretched;
                    break;
                case 2:
                    style = Wallpaper.Style.Tiled;
                    break;
                default:
                    style = Wallpaper.Style.FlatCenter;
                    break;
            }
            while (true)
            {
                foreach (string path in Directory.GetFiles(saveLocation.Text))
                {
                    
                    Wallpaper.SetDT(path, style);
                    System.Threading.Thread.Sleep(delay);
                }
            }
        }
        private void saveLocation_Enter(object sender, EventArgs e)
        {
            this.label1.Focus();
        }
    }
}
