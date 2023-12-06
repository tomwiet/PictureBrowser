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
            this.gbxPictureProperties = new System.Windows.Forms.GroupBox();
            this.gbxPicture = new System.Windows.Forms.GroupBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbxPictureProperties.SuspendLayout();
            this.gbxPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPicture
            // 
            this.pbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPicture.Location = new System.Drawing.Point(6, 21);
            this.pbPicture.MaximumSize = new System.Drawing.Size(800, 800);
            this.pbPicture.MinimumSize = new System.Drawing.Size(100, 100);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(609, 350);
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            this.pbPicture.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pbPicture_LoadCompleted);
            this.pbPicture.LoadProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.pbPicture_LoadProgressChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(206, 406);
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
            this.btnClear.Location = new System.Drawing.Point(287, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Wyczyść";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // prsPictureLoading
            // 
            this.prsPictureLoading.Location = new System.Drawing.Point(6, 377);
            this.prsPictureLoading.Name = "prsPictureLoading";
            this.prsPictureLoading.Size = new System.Drawing.Size(565, 23);
            this.prsPictureLoading.TabIndex = 4;
            // 
            // lblPictureLoadinPercent
            // 
            this.lblPictureLoadinPercent.AutoSize = true;
            this.lblPictureLoadinPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPictureLoadinPercent.Location = new System.Drawing.Point(577, 377);
            this.lblPictureLoadinPercent.Name = "lblPictureLoadinPercent";
            this.lblPictureLoadinPercent.Size = new System.Drawing.Size(49, 25);
            this.lblPictureLoadinPercent.TabIndex = 5;
            this.lblPictureLoadinPercent.Text = "0 %";
            // 
            // gbxPictureProperties
            // 
            this.gbxPictureProperties.Controls.Add(this.lblHeight);
            this.gbxPictureProperties.Controls.Add(this.lblWidth);
            this.gbxPictureProperties.Location = new System.Drawing.Point(692, 6);
            this.gbxPictureProperties.Name = "gbxPictureProperties";
            this.gbxPictureProperties.Size = new System.Drawing.Size(171, 452);
            this.gbxPictureProperties.TabIndex = 6;
            this.gbxPictureProperties.TabStop = false;
            this.gbxPictureProperties.Text = "Właściwości obrazu";
            // 
            // gbxPicture
            // 
            this.gbxPicture.Controls.Add(this.pbPicture);
            this.gbxPicture.Controls.Add(this.prsPictureLoading);
            this.gbxPicture.Controls.Add(this.lblPictureLoadinPercent);
            this.gbxPicture.Controls.Add(this.btnLoad);
            this.gbxPicture.Controls.Add(this.btnClear);
            this.gbxPicture.Location = new System.Drawing.Point(12, 6);
            this.gbxPicture.MaximumSize = new System.Drawing.Size(663, 452);
            this.gbxPicture.Name = "gbxPicture";
            this.gbxPicture.Size = new System.Drawing.Size(663, 452);
            this.gbxPicture.TabIndex = 7;
            this.gbxPicture.TabStop = false;
            this.gbxPicture.Text = "Obraz";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWidth.Location = new System.Drawing.Point(6, 42);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(89, 18);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Szerokość: ";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeight.Location = new System.Drawing.Point(6, 81);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(88, 18);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Wysokość: ";
            // 
            // PictureBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 472);
            this.Controls.Add(this.gbxPicture);
            this.Controls.Add(this.gbxPictureProperties);
            this.MaximumSize = new System.Drawing.Size(900, 520);
            this.Name = "PictureBrowser";
            this.Text = "Przeglądarka obrazów";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PictureBrowser_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.gbxPictureProperties.ResumeLayout(false);
            this.gbxPictureProperties.PerformLayout();
            this.gbxPicture.ResumeLayout(false);
            this.gbxPicture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog ofdOpenPicture;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ProgressBar prsPictureLoading;
        private System.Windows.Forms.Label lblPictureLoadinPercent;
        private System.Windows.Forms.GroupBox gbxPictureProperties;
        private System.Windows.Forms.GroupBox gbxPicture;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
    }
}

