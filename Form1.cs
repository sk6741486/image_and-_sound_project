using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

           // Assembly myAssembly = Assembly.GetExecutingAssembly();

            //Stream myStream = myAssembly.GetManifestResourceStream("image_and_sound_project.Resources.gun.jpg");

         //   Bitmap bmp_Object = new Bitmap(myStream);

            pictureBox1.Image = image_and__sound_project.Properties.Resources.gunload;




        }
    }
}
