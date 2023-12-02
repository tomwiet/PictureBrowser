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
            Picture picture= new Picture();
            InitializeComponent();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Picture picture = new Picture();

            if (ofdOpenPicture.ShowDialog() == DialogResult.OK)
            {
                picture.picturePath = ofdOpenPicture.FileName;
                pbPicture.ImageLocation = picture.picturePath;
                pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
                MessageBox.Show(pbPicture.ClientSize.Width.ToString() +" " + pbPicture.ClientSize.Height.ToString());
                
            }
        }
    }
}
