using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBrowser
{
    internal class FileHelper
    {
        private string _picturePath = null;
        public void SavePicturePathToFile(string picturePath) 
        {
            try
            {
        
                StreamWriter sw = new StreamWriter(Program.FilePath);
                
                sw.WriteLine(picturePath);
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string RestorePicturePathFromFile() 
        {
            try
            {
                if(File.Exists(Program.FilePath))
                {
                    StreamReader sr = new StreamReader(Program.FilePath);

                    _picturePath = sr.ReadLine();
                    sr.Close();
                }
                

               
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            
            return _picturePath;

        }

        public void RemoveFile()
        {
            File.Delete(Program.FilePath);
        }
    }
}
