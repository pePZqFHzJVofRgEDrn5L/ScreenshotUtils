using NLog;
using ScreenshotUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenshotTest
{

    public partial class Form1 : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StartCapture(true);
            }
            catch (Exception)
            {

            }

        }

        //启动截图
        public void StartCapture(bool fromClip)
        {
            CaptureForm capture = new CaptureForm();
            capture.Finishing += Capture_Finish;
            try
            {
                if (!CaptureForm.isAlive)
                {
                    capture.IsCaptureCursor = false;
                    capture.IsFromClipBoard = fromClip;
                    capture.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Capture_Finish(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)sender;
            img.Save("E:\\a.jpg");
        }
    }
}
