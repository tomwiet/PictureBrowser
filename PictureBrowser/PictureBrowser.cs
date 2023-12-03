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
            LoadPreviousPicture();
           

        }

        public void LoadPreviousPicture()
        {
            var fileHelper = new FileHelper();

            var picturePath = fileHelper.RestorePicturePathFromFile();
            
            if(picturePath != null)
            {

                pbPicture.ImageLocation = picturePath;
                pbPicture.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }
        

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if(ofdOpenPicture.ShowDialog() == DialogResult.OK)
                {
                    
                    pbPicture.ImageLocation = ofdOpenPicture.FileName;
                    pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
                   
                }
                else
                {
                    throw new Exception("Nee udało się załadować pliku");
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
                pbPicture.Image.Dispose();

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
        }
    }
}
