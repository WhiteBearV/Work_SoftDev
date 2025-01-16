using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projaect2
{
    public partial class MainForm1 : Form
    {
        private VideoCapture _capture = null;
        private VideoWriter _videoWriter;
        private Mat _frame;
        private CascadeClassifier _faceDetector;
        private System.Windows.Forms.Timer Timer = new System.Windows.Forms.Timer();

        CascadeClassifier _cascadeClassifier = new CascadeClassifier(@"C:\Users\ASUS\source\repos\Projaect2\Haar_Model\haarcascade_frontalface_default.xml");

        private bool _isRecording = false;
        private bool isConnected = false; // Track connection state
        private string imageSaveFolder = "";
        private bool isSnapshotActive = false;
        private bool isRecording = false;


        public MainForm1()

        {
            InitializeComponent();
            Starbutton.Enabled = false;
            FlipHorbutton.Enabled = false;
            FlipVerbutton.Enabled = false;
            timerClock.Enabled = true;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;

            TimerSanap.Tick += timerSanap_Tick;

        }



        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_capture == null || _capture.Ptr == IntPtr.Zero) return;

            // ดึงเฟรมจากกล้องโดยใช้ Retrieve
            _capture.Retrieve(_frame);
            if (!_frame.IsEmpty)
            {
                // แปลงเฟรมเป็นรูปแบบ Image<Bgr, Byte>
                using (var imageFrame = _frame.ToImage<Bgr, Byte>())
                {
                    if (imageFrame != null)
                    {
                        // แปลงภาพเป็น Gray สำหรับการตรวจจับใบหน้า
                        using (var grayFrame = imageFrame.Convert<Gray, byte>())
                        {
                            // ตรวจจับใบหน้า
                            var faces = _cascadeClassifier.DetectMultiScale(grayFrame, 1.1, 5);

                            // วาดกรอบรอบใบหน้าที่ตรวจพบ
                            foreach (var face in faces)
                            {
                                imageFrame.Draw(face, new Bgr(Color.Red), 3);
                            }

                            // แสดงผล
                            Invoke(new Action(() =>
                            {
                                imageBoxLive1.Image = imageFrame;

                                // แสดงภาพใบหน้าที่ตัดมาใน
                                if (faces.Length > 0)
                                {
                                    Rectangle face_roi = new Rectangle(faces[0].X, faces[0].Y, 190, 190);
                                    grayFrame.ROI = face_roi;
                                    ShowFacesDetect.Image = grayFrame.Copy();
                                }
                            }));
                        }
                    }
                }
            }
        }




        private async void buttonConnect_Click(object sender, EventArgs e)
        {

            try
            {
                tbCarmera.BackColor = Color.SkyBlue;
                tbCarmera.Text = "Waiting";
                await Task.Delay(500);


                if (isConnected) // If currently connected, disconnect
                {


                    // Disconnect
                    if (_capture != null)
                    {
                        _capture.Pause();
                        _capture.Dispose();
                    }
                    if (_frame != null)
                        _frame.Dispose();

                    Starbutton.Enabled = false;
                    FlipHorbutton.Enabled = false;
                    FlipVerbutton.Enabled = false;
                    isConnected = false; // Update connection state
                    Connectbutton.Text = "Connect"; // Change button text to "Connect"
                    {
                        tbCarmera.BackColor = Color.RosyBrown;
                        tbCarmera.Text = "NOT READY";
                    }
                }
                else // If currently disconnected, connect
                {
                    // Connect
                    FlipHorbutton.Enabled = false;
                    FlipVerbutton.Enabled = false;
                    Starbutton.Enabled = true;
                    _capture = new VideoCapture();
                    _capture.ImageGrabbed += ProcessFrame;


                    _frame = new Mat();

                    isConnected = true; // Update connection state
                    Connectbutton.Text = "Disconnect"; // Change button text to "Disconnect"

                    {
                        tbCarmera.BackColor = Color.LightGreen;
                        tbCarmera.Text = "READY";
                    }
                }

            }



            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (_capture != null)
                _capture.FlipHorizontal = !_capture.FlipHorizontal;
        }

        private bool isRecord = false;
        private async void Starbutton_Click(object sender, EventArgs e)
        {
            try
            {
                tbRecord.BackColor = Color.SkyBlue;
                tbRecord.Text = "Waiting";
                await Task.Delay(500);

                if (isRecord) // If currently capturing, stop
                {
                    // Stop the capture
                    if (_capture != null)
                    {
                        _capture.Stop();
                        Connectbutton.Enabled = true;
                        FlipHorbutton.Enabled = false;
                        FlipVerbutton.Enabled = false;
                    }

                    isRecord = false; // Update capture state
                    Starbutton.Text = "Start"; // Change button text to "Start"
                    {
                        tbRecord.BackColor = Color.RosyBrown;
                        tbRecord.Text = "NOT READY";
                    }
                }
                else // If not capturing, start
                {
                    // Start the capture
                    if (_capture != null)
                    {
                        _capture.Start();
                        Connectbutton.Enabled = false;
                        FlipHorbutton.Enabled = true;
                        FlipVerbutton.Enabled = true;

                    }

                    isRecord = true; // Update capture state
                    Starbutton.Text = "Stop"; // Change button text to "Stop"
                    {
                        tbRecord.BackColor = Color.LightGreen;
                        tbRecord.Text = "READY";
                    }
                }
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void FlipVerbutton_Click(object sender, EventArgs e)
        {
            if (_capture != null)
                _capture.FlipVertical = !_capture.FlipVertical;
        }

        private async Task aaWait(object sender, EventArgs e)
        {
            tbCarmera.BackColor = Color.SkyBlue;
            tbCarmera.Text = "Waiting";
            await Task.Delay(100);
        }

        private void imageBoxLive1_Click(object sender, EventArgs e)
        {

        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            string formatStringClock = "HH:mm:ss";
            string formatStringDate = "yyyy-MMM-dd";

            DateTime dtNow = DateTime.Now;

            // สมมติว่า tbTime และ tbDate เป็น TextBox หรือ Label
            tbTime.Text = dtNow.ToString(formatStringClock);
            tbDate.Text = dtNow.ToString(formatStringDate);
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (_capture != null)
            {
                _capture.Pause();
                _capture.Dispose();
                _capture = null;
            }
            // แสดงข้อความแจ้งเตือน
            DialogResult result = MessageBox.Show("คุณต้องการปิดโปรแกรมใช่หรือไม่?",
                                                  "ยืนยันการปิด",
                                                  MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // ยกเลิกการปิดฟอร์ม
            }
        }

        private void buttonBrowser_Click_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxImageFolder.Text = diag.SelectedPath;
                imageSaveFolder = diag.SelectedPath;
            }
            else
            {
                textBoxImageFolder.Text = "You didn't select any folder! ";
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int interval = (int)numericUpDown1.Value * 1000;


            if (interval == 0)
            {
                if (Timer.Enabled)
                {
                    MessageBox.Show("Interval cannot be 0. Please set a valid time interval.");
                    checkBoxSanapShot.Checked = false;
                    Timer.Stop();
                }
                return;
            }

            Timer.Interval = interval;

            if (isSnapshotActive)
            {
                textBoxLog.AppendText($"Timer Interval updated: {Timer.Interval} ms{Environment.NewLine}");
            }
        }

        private void textBoxImageFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxRecognizer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecognizer.Checked)
            {
                checkBoxSanapShot.Enabled = false;
            }
            else
            {
                checkBoxSanapShot.Enabled = true;
            }
        }

        private void checkBoxSanapShot_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxSanapShot.Checked == true)
            {
                if (isSnapshotActive)
                {
                    MessageBox.Show("Snapshot is currently active. Please stop it before enabling/disabling.");
                    checkBoxSanapShot.Checked = !checkBoxSanapShot.Checked;
                    return;
                }

                if (string.IsNullOrEmpty(imageSaveFolder))
                {
                    MessageBox.Show("Please select a folder to save images first!");
                    checkBoxSanapShot.Checked = false;
                    return;
                }
                try
                {

                    int interval = (int)numericUpDown1.Value * 1000;
                    Timer.Interval = interval;

                    if (interval == 0)
                    {
                        Timer.Stop();
                    }

                    Timer.Start();
                    isSnapshotActive = true;
                    Connectbutton.Enabled = false;
                }
                catch (Exception ex)
                {
                    checkBoxSanapShot.Checked = false;
                    MessageBox.Show("Inverval Should not be 0");

                }

                checkBoxRecognizer.Enabled = false;
            }
            else
            {
                checkBoxRecognizer.Enabled = true;
                Timer.Stop();
                isSnapshotActive = false;
                Connectbutton.Enabled = true;
            }

        }

        private void timerSanap_Tick(object sender, EventArgs e)
        {
            if (!checkBoxSanapShot.Checked || _capture == null || _capture.Ptr == IntPtr.Zero) return;

            try
            {
                using (var imageFrame = new Mat())
                {
                    if (_capture.Retrieve(imageFrame) && !imageFrame.IsEmpty)
                    {
                        using (var grayFrame = imageFrame.ToImage<Gray, Byte>())
                        {
                            var faces = _cascadeClassifier.DetectMultiScale(grayFrame, 1.1, 10);

                            if (faces.Length > 0)
                            {
                                Rectangle face_roi = faces[0];
                                face_roi.Intersect(new Rectangle(0, 0, grayFrame.Width, grayFrame.Height));
                                grayFrame.ROI = face_roi;

                                using (var faceImage = grayFrame.Copy())
                                {
                                    string timestamp = DateTime.Now.ToString("yyyy-MM-ddHH-mm-ss");
                                    string filePath = Path.Combine(imageSaveFolder, $"Snapshot{timestamp}.png");
                                    faceImage.Save(filePath);

                                    textBoxLog.AppendText($"Snapshot saved to: {filePath}{Environment.NewLine}");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during snapshot: {ex.Message}");
            }

        }
               
            
        

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
