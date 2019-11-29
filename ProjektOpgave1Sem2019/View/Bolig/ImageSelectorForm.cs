using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOpgave1Sem2019.View.Bolig
{
    //martin
    public partial class ImageSelectorForm : Form
    {
        public ImageSelectorForm()
        {
            InitializeComponent();
        }

        private void ImageSelectorForm_Load(object sender, EventArgs e)
        {
            try
            {
                PictureHelper.LoadImages();
                foreach (Image i in PictureHelper.Images)
                {
                    LBPictures.Items.Add(i.Tag);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to load Images. The path in PictureHelper class is somehow wrong (Probably because Martin made it and it works on his machine. Boop");
                this.Close();
            }
        }

        private void LBPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBPictures.SelectedIndex != -1) //-1 er none selected
            {
                PBSelectedPic.Image = PictureHelper.Images[LBPictures.SelectedIndex]; 
            }
        }
    }
}
