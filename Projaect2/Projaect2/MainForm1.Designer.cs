namespace Projaect2
{
    partial class MainForm1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageBoxLive1 = new Emgu.CV.UI.ImageBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FlipVerbutton = new System.Windows.Forms.Button();
            this.FlipHorbutton = new System.Windows.Forms.Button();
            this.Starbutton = new System.Windows.Forms.Button();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.tbCarmera = new System.Windows.Forms.TextBox();
            this.tbRecord = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.FacesDetectBox = new System.Windows.Forms.GroupBox();
            this.ShowFacesDetect = new Emgu.CV.UI.ImageBox();
            this.RecogBox = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.textBoxImageFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxSanapShot = new System.Windows.Forms.CheckBox();
            this.checkBoxRecognizer = new System.Windows.Forms.CheckBox();
            this.Log_Part = new System.Windows.Forms.GroupBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TimerSanap = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLive1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.FacesDetectBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowFacesDetect)).BeginInit();
            this.RecogBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Log_Part.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.imageBoxLive1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Live View";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageBoxLive1
            // 
            this.imageBoxLive1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBoxLive1.Location = new System.Drawing.Point(6, 12);
            this.imageBoxLive1.Name = "imageBoxLive1";
            this.imageBoxLive1.Size = new System.Drawing.Size(421, 339);
            this.imageBoxLive1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxLive1.TabIndex = 2;
            this.imageBoxLive1.TabStop = false;
            this.imageBoxLive1.Click += new System.EventHandler(this.imageBoxLive1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.FlipVerbutton);
            this.groupBox2.Controls.Add(this.FlipHorbutton);
            this.groupBox2.Controls.Add(this.Starbutton);
            this.groupBox2.Controls.Add(this.Connectbutton);
            this.groupBox2.Location = new System.Drawing.Point(12, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1195, 308);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cont";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // FlipVerbutton
            // 
            this.FlipVerbutton.Location = new System.Drawing.Point(143, 146);
            this.FlipVerbutton.Name = "FlipVerbutton";
            this.FlipVerbutton.Size = new System.Drawing.Size(131, 119);
            this.FlipVerbutton.TabIndex = 5;
            this.FlipVerbutton.Text = "FlipVer";
            this.FlipVerbutton.UseVisualStyleBackColor = true;
            this.FlipVerbutton.Click += new System.EventHandler(this.FlipVerbutton_Click);
            // 
            // FlipHorbutton
            // 
            this.FlipHorbutton.Location = new System.Drawing.Point(6, 146);
            this.FlipHorbutton.Name = "FlipHorbutton";
            this.FlipHorbutton.Size = new System.Drawing.Size(131, 119);
            this.FlipHorbutton.TabIndex = 4;
            this.FlipHorbutton.Text = "FlipHor";
            this.FlipHorbutton.UseVisualStyleBackColor = true;
            this.FlipHorbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // Starbutton
            // 
            this.Starbutton.Location = new System.Drawing.Point(143, 21);
            this.Starbutton.Name = "Starbutton";
            this.Starbutton.Size = new System.Drawing.Size(131, 119);
            this.Starbutton.TabIndex = 2;
            this.Starbutton.Text = "Start";
            this.Starbutton.UseVisualStyleBackColor = true;
            this.Starbutton.Click += new System.EventHandler(this.Starbutton_Click);
            // 
            // Connectbutton
            // 
            this.Connectbutton.Location = new System.Drawing.Point(6, 21);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(131, 119);
            this.Connectbutton.TabIndex = 0;
            this.Connectbutton.Text = "Connect";
            this.Connectbutton.UseVisualStyleBackColor = true;
            this.Connectbutton.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // tbCarmera
            // 
            this.tbCarmera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCarmera.Location = new System.Drawing.Point(754, 709);
            this.tbCarmera.Multiline = true;
            this.tbCarmera.Name = "tbCarmera";
            this.tbCarmera.ReadOnly = true;
            this.tbCarmera.Size = new System.Drawing.Size(105, 26);
            this.tbCarmera.TabIndex = 6;
            this.tbCarmera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRecord
            // 
            this.tbRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecord.Location = new System.Drawing.Point(865, 709);
            this.tbRecord.Multiline = true;
            this.tbRecord.Name = "tbRecord";
            this.tbRecord.ReadOnly = true;
            this.tbRecord.Size = new System.Drawing.Size(100, 26);
            this.tbRecord.TabIndex = 7;
            this.tbRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTime
            // 
            this.tbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTime.Location = new System.Drawing.Point(999, 712);
            this.tbTime.Multiline = true;
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(59, 18);
            this.tbTime.TabIndex = 8;
            this.tbTime.Text = "Time";
            this.tbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDate
            // 
            this.tbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDate.Location = new System.Drawing.Point(1107, 709);
            this.tbDate.Multiline = true;
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(100, 26);
            this.tbDate.TabIndex = 9;
            this.tbDate.Text = "07 / 11 / 2599";
            this.tbDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // FacesDetectBox
            // 
            this.FacesDetectBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FacesDetectBox.Controls.Add(this.ShowFacesDetect);
            this.FacesDetectBox.Location = new System.Drawing.Point(506, 24);
            this.FacesDetectBox.Name = "FacesDetectBox";
            this.FacesDetectBox.Size = new System.Drawing.Size(315, 270);
            this.FacesDetectBox.TabIndex = 10;
            this.FacesDetectBox.TabStop = false;
            this.FacesDetectBox.Text = "Faces";
            // 
            // ShowFacesDetect
            // 
            this.ShowFacesDetect.Location = new System.Drawing.Point(6, 18);
            this.ShowFacesDetect.Name = "ShowFacesDetect";
            this.ShowFacesDetect.Size = new System.Drawing.Size(303, 260);
            this.ShowFacesDetect.TabIndex = 2;
            this.ShowFacesDetect.TabStop = false;
            // 
            // RecogBox
            // 
            this.RecogBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecogBox.Controls.Add(this.numericUpDown1);
            this.RecogBox.Controls.Add(this.buttonBrowser);
            this.RecogBox.Controls.Add(this.textBoxImageFolder);
            this.RecogBox.Controls.Add(this.label3);
            this.RecogBox.Controls.Add(this.label2);
            this.RecogBox.Controls.Add(this.checkBoxSanapShot);
            this.RecogBox.Controls.Add(this.checkBoxRecognizer);
            this.RecogBox.Location = new System.Drawing.Point(827, 24);
            this.RecogBox.Name = "RecogBox";
            this.RecogBox.Size = new System.Drawing.Size(380, 277);
            this.RecogBox.TabIndex = 6;
            this.RecogBox.TabStop = false;
            this.RecogBox.Text = "Recognizer";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(202, 57);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.Location = new System.Drawing.Point(241, 181);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(133, 52);
            this.buttonBrowser.TabIndex = 6;
            this.buttonBrowser.Text = "Browse";
            this.buttonBrowser.UseVisualStyleBackColor = true;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonBrowser_Click_Click);
            // 
            // textBoxImageFolder
            // 
            this.textBoxImageFolder.Location = new System.Drawing.Point(15, 130);
            this.textBoxImageFolder.Multiline = true;
            this.textBoxImageFolder.Name = "textBoxImageFolder";
            this.textBoxImageFolder.ReadOnly = true;
            this.textBoxImageFolder.Size = new System.Drawing.Size(359, 32);
            this.textBoxImageFolder.TabIndex = 5;
            this.textBoxImageFolder.TextChanged += new System.EventHandler(this.textBoxImageFolder_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Training Image(s) Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seconds/Image";
            // 
            // checkBoxSanapShot
            // 
            this.checkBoxSanapShot.AutoSize = true;
            this.checkBoxSanapShot.Location = new System.Drawing.Point(15, 30);
            this.checkBoxSanapShot.Name = "checkBoxSanapShot";
            this.checkBoxSanapShot.Size = new System.Drawing.Size(155, 20);
            this.checkBoxSanapShot.TabIndex = 1;
            this.checkBoxSanapShot.Text = "ON / OFF SanapShot";
            this.checkBoxSanapShot.UseVisualStyleBackColor = true;
            this.checkBoxSanapShot.CheckedChanged += new System.EventHandler(this.checkBoxSanapShot_CheckedChanged);
            // 
            // checkBoxRecognizer
            // 
            this.checkBoxRecognizer.AutoSize = true;
            this.checkBoxRecognizer.Location = new System.Drawing.Point(15, 58);
            this.checkBoxRecognizer.Name = "checkBoxRecognizer";
            this.checkBoxRecognizer.Size = new System.Drawing.Size(157, 20);
            this.checkBoxRecognizer.TabIndex = 0;
            this.checkBoxRecognizer.Text = "ON / OFF Recognizer";
            this.checkBoxRecognizer.UseVisualStyleBackColor = true;
            this.checkBoxRecognizer.CheckedChanged += new System.EventHandler(this.checkBoxRecognizer_CheckedChanged);
            // 
            // Log_Part
            // 
            this.Log_Part.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Log_Part.Controls.Add(this.textBoxLog);
            this.Log_Part.Location = new System.Drawing.Point(512, 314);
            this.Log_Part.Name = "Log_Part";
            this.Log_Part.Size = new System.Drawing.Size(618, 75);
            this.Log_Part.TabIndex = 11;
            this.Log_Part.TabStop = false;
            this.Log_Part.Text = "Log";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLog.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxLog.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxLog.Location = new System.Drawing.Point(6, 21);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(606, 46);
            this.textBoxLog.TabIndex = 0;
            this.textBoxLog.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // TimerSanap
            // 
            this.TimerSanap.Enabled = true;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 739);
            this.Controls.Add(this.Log_Part);
            this.Controls.Add(this.RecogBox);
            this.Controls.Add(this.FacesDetectBox);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbRecord);
            this.Controls.Add(this.tbCarmera);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm1_FormClosing_1);
            this.Load += new System.EventHandler(this.MainForm1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLive1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.FacesDetectBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowFacesDetect)).EndInit();
            this.RecogBox.ResumeLayout(false);
            this.RecogBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Log_Part.ResumeLayout(false);
            this.Log_Part.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Emgu.CV.UI.ImageBox imageBoxLive1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button FlipVerbutton;
        private System.Windows.Forms.Button FlipHorbutton;
        private System.Windows.Forms.Button Starbutton;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.TextBox tbCarmera;
        private System.Windows.Forms.TextBox tbRecord;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.GroupBox FacesDetectBox;
        private Emgu.CV.UI.ImageBox ShowFacesDetect;
        private System.Windows.Forms.GroupBox RecogBox;
        private System.Windows.Forms.GroupBox Log_Part;
        private System.Windows.Forms.CheckBox checkBoxSanapShot;
        private System.Windows.Forms.CheckBox checkBoxRecognizer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxImageFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBrowser;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer TimerSanap;
    }
}

