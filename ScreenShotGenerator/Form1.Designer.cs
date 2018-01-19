namespace ScreenShotGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.deviceCombo = new System.Windows.Forms.ComboBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deviceRefresh = new System.Windows.Forms.Button();
            this.copyToClipboard = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.screenCaptureBtn = new System.Windows.Forms.Button();
            this.deviceImagePotrait = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceImagePotrait)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Devices";
            // 
            // deviceCombo
            // 
            this.deviceCombo.FormattingEnabled = true;
            this.deviceCombo.Location = new System.Drawing.Point(81, 44);
            this.deviceCombo.Name = "deviceCombo";
            this.deviceCombo.Size = new System.Drawing.Size(230, 21);
            this.deviceCombo.TabIndex = 7;
            this.deviceCombo.TabStop = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Image File|*.png";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.deviceRefresh);
            this.panel1.Controls.Add(this.copyToClipboard);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.screenCaptureBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.deviceCombo);
            this.panel1.Location = new System.Drawing.Point(355, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 154);
            this.panel1.TabIndex = 11;
            // 
            // deviceRefresh
            // 
            this.deviceRefresh.Image = ((System.Drawing.Image)(resources.GetObject("deviceRefresh.Image")));
            this.deviceRefresh.Location = new System.Drawing.Point(81, 94);
            this.deviceRefresh.Name = "deviceRefresh";
            this.deviceRefresh.Size = new System.Drawing.Size(39, 39);
            this.deviceRefresh.TabIndex = 11;
            this.deviceRefresh.UseVisualStyleBackColor = true;
            this.deviceRefresh.Click += new System.EventHandler(this.deviceRefresh_Click);
            // 
            // copyToClipboard
            // 
            this.copyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("copyToClipboard.Image")));
            this.copyToClipboard.Location = new System.Drawing.Point(272, 94);
            this.copyToClipboard.Name = "copyToClipboard";
            this.copyToClipboard.Size = new System.Drawing.Size(39, 39);
            this.copyToClipboard.TabIndex = 13;
            this.copyToClipboard.UseVisualStyleBackColor = true;
            this.copyToClipboard.Click += new System.EventHandler(this.copyToClipboard_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(216, 94);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(39, 39);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // screenCaptureBtn
            // 
            this.screenCaptureBtn.Image = ((System.Drawing.Image)(resources.GetObject("screenCaptureBtn.Image")));
            this.screenCaptureBtn.Location = new System.Drawing.Point(156, 94);
            this.screenCaptureBtn.Name = "screenCaptureBtn";
            this.screenCaptureBtn.Size = new System.Drawing.Size(39, 39);
            this.screenCaptureBtn.TabIndex = 9;
            this.screenCaptureBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.screenCaptureBtn.UseVisualStyleBackColor = true;
            this.screenCaptureBtn.Click += new System.EventHandler(this.screenCaptureBtn_Click);
            // 
            // deviceImagePotrait
            // 
            this.deviceImagePotrait.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deviceImagePotrait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deviceImagePotrait.Location = new System.Drawing.Point(12, 53);
            this.deviceImagePotrait.Name = "deviceImagePotrait";
            this.deviceImagePotrait.Size = new System.Drawing.Size(294, 518);
            this.deviceImagePotrait.TabIndex = 6;
            this.deviceImagePotrait.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.deviceImagePotrait);
            this.panel2.Location = new System.Drawing.Point(18, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 640);
            this.panel2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 672);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Screen Shot Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceImagePotrait)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox deviceImagePotrait;
        private System.Windows.Forms.Button screenCaptureBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deviceCombo;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deviceRefresh;
        private System.Windows.Forms.Button copyToClipboard;
        private System.Windows.Forms.Panel panel2;
    }
}

