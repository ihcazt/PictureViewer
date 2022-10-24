using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class PictureViewerForm : Form
    {
        public PictureViewerForm()
        {
            InitializeComponent();
        }

        private void streacCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box, 
            // change the PictureBox's
            // SizeMode property to "Stretch". If the user clears 
            // the check box, change it to "Normal".
            if (streacCheckBox.Checked)
                thePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                thePictureBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void showAPictureButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            if (theOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                thePictureBox.Load(theOpenFileDialog.FileName);
            }
        }

        private void clearAPictureButton_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            thePictureBox.Image = null;
        }

        private void setTheBackgroudColorButton_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            if (theColorDialog.ShowDialog() == DialogResult.OK)
                thePictureBox.BackColor = theColorDialog.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
