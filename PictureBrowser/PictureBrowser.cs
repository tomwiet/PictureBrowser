using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBrowser
{
    public partial class PictureBrowser : Form
    {
        public PictureBrowser()
        {
            
            InitializeComponent();
            btnClear.Enabled = false;
            pbPicture.WaitOnLoad = false;
            prsPictureLoading.Visible = false;
            lblPictureLoadinPercent.Visible = false;
            LoadPreviousPicture();
           

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
            //pbPicture.ImageLocation = picturePath;
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            prsPictureLoading.Visible = true;
            lblPictureLoadinPercent.Visible = true;
            try
            {
                if(ofdOpenPicture.ShowDialog() == DialogResult.OK)
                {
                    
                    ShowInPictureBox(ofdOpenPicture.FileName);
                 
                }
                else
                {
                    throw new Exception("Nie udało się załadować pliku");
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
                //pbPicture.Image.Dispose();

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
        }

        private void pbPicture_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            btnClear.Enabled = true;
            prsPictureLoading.Visible = false;
            lblPictureLoadinPercent.Visible = false;
        }

        private void pbPicture_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prsPictureLoading.Value = e.ProgressPercentage;
            lblPictureLoadinPercent.Text = e.ProgressPercentage.ToString() + "%";
        }
    }
}
