namespace PictureBrowser
{
    partial class PictureBrowser
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
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.ofdOpenPicture = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.prsPictureLoading = new System.Windows.Forms.ProgressBar();
            this.lblPictureLoadinPercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(12, 12);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(642, 340);
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            this.pbPicture.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pbPicture_LoadCompleted);
            this.pbPicture.LoadProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.pbPicture_LoadProgressChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(239, 394);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 30);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Załaduj";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ofdOpenPicture
            // 
            this.ofdOpenPicture.FileName = "openFileDialog1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(320, 394);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Wyczyść";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // prsPictureLoading
            // 
            this.prsPictureLoading.Location = new System.Drawing.Point(13, 359);
            this.prsPictureLoading.Name = "prsPictureLoading";
            this.prsPictureLoading.Size = new System.Drawing.Size(641, 23);
            this.prsPictureLoading.TabIndex = 4;
            // 
            // lblPictureLoadinPercent
            // 
            this.lblPictureLoadinPercent.AutoSize = true;
            this.lblPictureLoadinPercent.Location = new System.Drawing.Point(661, 365);
            this.lblPictureLoadinPercent.Name = "lblPictureLoadinPercent";
            this.lblPictureLoadinPercent.Size = new System.Drawing.Size(44, 16);
            this.lblPictureLoadinPercent.TabIndex = 5;
            this.lblPictureLoadinPercent.Text = "label1";
            // 
            // PictureBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 445);
            this.Controls.Add(this.lblPictureLoadinPercent);
            this.Controls.Add(this.prsPictureLoading);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pbPicture);
            this.Name = "PictureBrowser";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PictureBrowser_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog ofdOpenPicture;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ProgressBar prsPictureLoading;
        private System.Windows.Forms.Label lblPictureLoadinPercent;
    }
}

