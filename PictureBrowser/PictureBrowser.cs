using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBrowser
{
    public partial class PictureBrowser : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        public PictureBrowser()
        {
            
            InitializeComponent();
            SetControlsState();
            LoadPreviousPicture();
           

        }

        private void SetControlsState()
        {
            btnClear.Enabled = false;
            pbPicture.WaitOnLoad = false;
            prsPictureLoading.Visible = false;
            lblPictureLoadinPercent.Visible = false;
        }

        public void LoadPreviousPicture()
        {
            var fileHelper = new FileHelper();

            var picturePath = fileHelper.RestorePicturePathFromFile();
            
            if(picturePath != null)
            {

                ShowInPictureBox(picturePath);

            }
        }

        private void ShowInPictureBox(string picturePath)
        {
            pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbPicture.LoadAsync(picturePath);
            gbxPicture.Text = Path.GetFileName(picturePath);

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(ofdOpenPicture.ShowDialog() == DialogResult.OK)
                {
                    prsPictureLoading.Visible = true;
                    lblPictureLoadinPercent.Visible = true;
                    ShowInPictureBox(ofdOpenPicture.FileName);

                }
                
            }
            
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }

        }

        private void PictureBrowser_FormClosing(object sender, FormClosingEventArgs e)
        { 
            var fileHelper = new FileHelper();
            
            if(pbPicture.Image != null)
            {
               
                fileHelper.SavePicturePathToFile(pbPicture.ImageLocation);

            }
            else
            {
                fileHelper.RemoveFile();
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
            btnClear.Enabled = false;
            lblWidth.Text = "Szerokość:";
            lblHeight.Text = "Wysokość:";
            gbxPicture.Text = "Obraz";
        }

        private void pbPicture_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            btnClear.Enabled = true;
            lblWidth.Text = $"Szerokość: {pbPicture.ClientSize.Width.ToString()} px";
            lblHeight.Text = $"Wysokość: {pbPicture.ClientSize.Height.ToString()} px";
            
            
        }

        private void pbPicture_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prsPictureLoading.Value = e.ProgressPercentage;
            lblPictureLoadinPercent.Text = e.ProgressPercentage.ToString() + "%";
            if(e.ProgressPercentage == 100)
            {
                //Thread.Sleep(1000);
                prsPictureLoading.Visible = false;
                lblPictureLoadinPercent.Visible = false;
            }
        }
    }
}
