using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_and__sound_project
{
    public partial class image_and_sound : Form
    {
        public image_and_sound()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            System.IO.Stream myStream = myAssembly.GetManifestResourceStream("ProjectName.Resources.ImageFileName.jpg");

            Bitmap bmp_Object = new Bitmap(myStream);

            PictureBox_Name.Image = bmp_Object;


        }
    }
}
